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

export const Main = () => {
    const navigate = useNavigate();
    const [dentServices, setDentServices] = useState([]);
    const [reportDoctors, setreportDoctors] = useState([]);
    const [reportDoctorSchedole, setreportDoctorSchedole] = useState([]);
    const [dentists, setDentists] = useState([]);

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
        data.endDate = DateConvertor.ConvertDateTime_AddDays_YYYYMMDD_HHMISS(d,5);
        console.log(data);
        BookedService.getDentistSchedule(data.doctor,data.startDate,data.endDate)
        .then(r => {
            console.log(r);
            //TO DO Booked
        })
    };

    return (
        <main b-j3bformqou="" role="main" className="pb-3">
            <Routes>
                <Route path={routeAddresses.home} element={<Home />}></Route>
                <Route path={routeAddresses.dentalServices} element={<DentalServices dentServices={dentServices} />}></Route>
                <Route path={routeAddresses.team} element={<Team dentists={dentists} onBookedSubmit={onBookedSubmit} />}></Route>
                <Route path={routeAddresses.reports} element={<Reports />}></Route>
                <Route path={routeAddresses.reportDentists} element={<ReportDentists reportDoctors={reportDoctors} />}></Route>
                <Route path={routeAddresses.reportDentistSchedule} element={<ReportDoctorShedule reportDoctors={reportDoctors} onGetReportSubmit={onGetReportSubmit} />}></Route>
                <Route path={routeAddresses.reportDentistScheduleResult} element={<ReportDoctorSchaduleResult reportDoctorSchedole={reportDoctorSchedole} />}></Route>
            </Routes>

        </main>
    );
}