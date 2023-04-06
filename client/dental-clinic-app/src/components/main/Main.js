import { Routes, Route, useNavigate } from 'react-router-dom';

import { useEffect, useState } from 'react';

import { routeAddresses } from '../../Router';
import { DentalServices } from './DentalServices/DentalServices';
import * as DateConvertor from '../../utils/ConvertDate';

import * as dentalServicesService from '../../services/DentalServicesService';
import * as ReportService from '../../services/ReportService';
import * as DoctorService from '../../services/DoctorService';
import * as BookedService from '../../services/BookedService';

import { Home } from "./Home";
import { Team } from './Teams/Team';
import { Reports } from './Reports/Reports';
import { ReportDentists } from './Reports/ReportDentists';
import { ReportDoctorShedule } from './Reports/ReportDoctorShedule';
import { ReportDoctorSchaduleResult } from './Reports/ReportDoctorSchaduleResult';
import { Booked } from './Booked/Booked';

export const Main = () => {
    
    const navigate = useNavigate();
    const [user, setuser] = useState([]);
    const [dentServices, setDentServices] = useState([]);
    const [reportDoctors, setreportDoctors] = useState([]);
    const [reportDoctorSchedole, setreportDoctorSchedole] = useState([]);
    const [booked, setBooked] = useState([]);
    const [dentists, setDentists] = useState([]);

    useEffect(() => {
        setuser("2e845fa4-54ea-4718-b341-a15ea4de9f86");
    },[]);  

    useEffect(() => {
        dentalServicesService.getAllDentalServices()
            .then(result => {
                setDentServices(result);
            })
    }, []);

    useEffect(() => {
        ReportService.getReportDoctors()
            .then(result => {
                setreportDoctors(result);
            })
    }, []);

    useEffect(() => {
        DoctorService.getAllDoctors()
            .then(result => {
                setDentists(result);
            })
    }, []);

    const onGetReportSubmit = async (data) => {
        var e = document.getElementById("selectedDoctor").value;
        console.log(data);
        var result = {};
        ReportService.getReportDoctorSchedule(e, data.startDate, data.endDate)
            .then(r => {
                result = r;
                setreportDoctorSchedole(result);
                if (r.length > 0) {
                    navigate(routeAddresses.reportDentistScheduleResult);
                } else {
                    alert("no data");
                }
            })
    };

    const onBookedSubmit = async (data) => {
        var d = new Date();
        data.startDate = DateConvertor.ConvertDateTime_YYYYMMDD_HHMISS(d);
        data.endDate = DateConvertor.ConvertDateTime_AddDays_YYYYMMDD_HHMISS(d, 5);
        BookedService.getDentistSchedule(data.doctor, data.startDate, data.endDate)
            .then(r => {
                r.doctor = data.doctorName;
                setBooked(r);
                navigate(routeAddresses.booked);
            })
    };

    const onGetBookedSubmit = async (data) => {
        //to do login user
        BookedService.Booked(data.doctorId, data.startDate, user)
            .then(r => {

                if (r.status == 200) {
                    console.log(booked);
                    for (const element of booked) {
                        if (element.startDate == data.startDate) {
                            element.who=user;
                            element.isBusy = true;
                        }
                    }
                    alert("Appointment mode successfully!");
                    navigate(routeAddresses.booked);
                } else if (r.status == 400) {
                    r.json()
                        .then(e => {
                            alert(e);
                        });
                } else {
                    alert("Application error.")
                }
            })
    };

    return (
        <main b-j3bformqou="" role="main" className="pb-3">
            <Routes>
                <Route path={routeAddresses.home} element={<Home />}></Route>
                <Route path={routeAddresses.dentalServices} element={<DentalServices dentServices={dentServices} />}></Route>
                <Route path={routeAddresses.team} element={<Team dentists={dentists} onBookedSubmit={onBookedSubmit} />}></Route>
                <Route path={routeAddresses.booked} element={<Booked booked={booked} onGetBookedSubmit={onGetBookedSubmit} user={user}/>}></Route>
                <Route path={routeAddresses.reports} element={<Reports />}></Route>
                <Route path={routeAddresses.reportDentists} element={<ReportDentists reportDoctors={reportDoctors} />}></Route>
                <Route path={routeAddresses.reportDentistSchedule} element={<ReportDoctorShedule reportDoctors={reportDoctors} onGetReportSubmit={onGetReportSubmit} />}></Route>
                <Route path={routeAddresses.reportDentistScheduleResult} element={<ReportDoctorSchaduleResult reportDoctorSchedole={reportDoctorSchedole} />}></Route>
            </Routes>

        </main>
    );
}