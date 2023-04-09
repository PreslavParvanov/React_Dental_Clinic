import { Routes, Route, useNavigate } from 'react-router-dom';

import { useEffect, useState, useContext } from 'react';

import { routeAddresses } from '../../Router';
import { DentalServices } from './DentalServices/DentalServices';
import * as DateConvertor from '../../utils/ConvertDate';
import { AuthContext } from '../../contexts/AuthContext';

import * as dentalServicesService from '../../services/DentalServicesService';
import * as ReportService from '../../services/ReportService';
import * as DoctorService from '../../services/DoctorService';
import * as BookedService from '../../services/BookedService';
import * as UserService from '../../services/UserService';

import { Home } from "./Home";
import { Team } from './Teams/Team';
import { Booked } from './Booked/Booked';
import { Reports } from './Reports/Reports';
import { ReportDentists } from './Reports/ReportDentists';
import { ReportDoctorShedule } from './Reports/ReportDoctorShedule';
import { ReportDoctorSchaduleResult } from './Reports/ReportDoctorSchaduleResult';
import { Dentists } from './Dentists/Dentists';
import { Registration } from './User/Registration';
import { Login } from './User/Login';
import { Logout } from './User/Logout';
import { CreateDentist } from './Dentists/CreateDentist';
import { EditDentist } from './Dentists/EditDentist';
import { CreateSchedule } from './Schedule/CreateSchedule';

export const Main = (
    inputData
) => {
    const navigate = useNavigate();
    const [dentServices, setDentServices] = useState([]);
    const [reportDoctors, setreportDoctors] = useState([]);
    const [reportDoctorSchedole, setreportDoctorSchedole] = useState([]);
    const [booked, setBooked] = useState([]);
    const [dentists, setDentists] = useState([]);
    const [doctor, setDoctor] = useState([]);


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
        BookedService.Booked(data.doctorId, data.startDate, inputData.user.id)
            .then(r => {

                if (r.status == 200) {
                    console.log(booked);
                    for (const element of booked) {
                        if (element.startDate == data.startDate) {
                            element.who = inputData.user;
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

    const onRegistrationSubmit = async (data) => {
        console.log(data);
        UserService.Registration(
            data.firstname,
            data.lastname,
            data.email,
            data.phonenumber,
            data.password,
            data.repassword
        )
            .then(r => {
                console.log(r);

                if (r.status == 200) {
                    alert("Appointment mode successfully!");
                    navigate(routeAddresses.login);
                } else if (r.status == 400) {
                    r.json()
                        .then(e => {
                            if (e.errors != null) {
                                var err = '';
                                for (const element of Object.values(e.errors)) {
                                    err += element;
                                    err += '. ';
                                }
                                console.log(err);
                                alert(err);
                            } else {
                                alert(e);
                            }

                        });

                } else {
                    alert("Application error.")
                }
            })
    };


    const onLogout = async () => {
        inputData.setuser({});
    };

    const onEditDentistClick = async (e) => {
        var doctorId = e.target.parentNode.parentNode.childNodes[2].innerText;
        DoctorService.getDoctorById(doctorId)
            .then(r => {
                setDoctor(r);
            })
        navigate(`/Dentist/Edit/${doctorId}`);
    };

    const onCreateDentistSubmit = async (data) => {

        DoctorService.createDentist(data.name, data.qualification, data.moreInfo, inputData.user)
            .then(r => {
                if (r.status == 200) {
                    alert("Create dentist successfully!");

                    DoctorService.getAllDoctors()
                        .then(result => {
                            setDentists(result);
                        });

                    navigate(routeAddresses.dentists);
                } else if (r.status == 400) {
                    r.json()
                        .then(e => {
                            if (e.errors != null) {
                                var err = '';
                                for (const element of Object.values(e.errors)) {
                                    err += element;
                                    err += '. ';
                                }
                                alert(err);
                            } else {
                                alert(e);
                            }
                        });

                } else {
                    alert("Application error.")
                }
            })

    };

    const onDeleteDentistClick = async (e) => {
        var doctorId = e.target.parentNode.parentNode.childNodes[2].innerText;
        console.log(doctorId);
        DoctorService.deleteDentist(doctorId, inputData.user)
            .then(r => {
                if (r.status == 200) {
                    alert("Delete dentist successfully!");

                    DoctorService.getAllDoctors()
                        .then(result => {
                            setDentists(result);
                        });

                    navigate(routeAddresses.dentists);
                } else if (r.status == 400) {
                    r.json()
                        .then(e => {
                            if (e.errors != null) {
                                var err = '';
                                for (const element of Object.values(e.errors)) {
                                    err += element;
                                    err += '. ';
                                }
                                alert(err);
                            } else {
                                alert(e);
                            }
                        });

                } else {
                    alert("Application error.")
                }
            })

    };


    const onEditDentistSubmit = async (data) => {

        DoctorService.updateDentist(data.id, data.name, data.qualification, data.moreInfo, inputData.user)
            .then(r => {
                if (r.status == 200) {
                    alert("Edit dentist successfully!");

                    DoctorService.getAllDoctors()
                        .then(result => {
                            setDentists(result);
                        });

                    navigate(routeAddresses.dentists);
                } else if (r.status == 400) {
                    r.json()
                        .then(e => {
                            if (e.errors != null) {
                                var err = '';
                                for (const element of Object.values(e.errors)) {
                                    err += element;
                                    err += '. ';
                                }
                                alert(err);
                            } else {
                                alert(e);
                            }
                        });

                } else {
                    alert("Application error.")
                }
            })

    };

    const onCreateScheduleSubmit = async (data) => {
        var doctor = document.getElementById("selectedDoctor").value;
        var selectedStartTime = document.getElementById("selectedStartTime").value;
        var selectedEndTime = document.getElementById("selectedEndTime").value;
        
        DoctorService.createSchedule(doctor, data.startDate,data.endDate,selectedStartTime, selectedEndTime, inputData.user)
        .then(r => {
            if (r.status == 200) {
                alert("Create Schedule successfully!");
            } else if (r.status == 400) {
                r.json()
                    .then(e => {
                        if (e.errors != null) {
                            var err = '';
                            for (const element of Object.values(e.errors)) {
                                err += element;
                                err += '. ';
                            }
                            alert(err);
                        } else {
                            alert(e);
                        }
                    });

            } else {
                alert("Application error.")
            }
        })
    };

    return (
        <main b-j3bformqou="" role="main" className="pb-3">
            <Routes>
                <Route path={routeAddresses.home} element={<Home user={inputData.user} />}></Route>
                <Route path={routeAddresses.dentalServices} element={<DentalServices dentServices={dentServices} />}></Route>
                <Route path={routeAddresses.team} element={<Team dentists={dentists} onBookedSubmit={onBookedSubmit} />}></Route>
                <Route path={routeAddresses.booked} element={<Booked booked={booked} onGetBookedSubmit={onGetBookedSubmit} user={inputData.user} />}></Route>
                <Route path={routeAddresses.reports} element={<Reports />}></Route>
                <Route path={routeAddresses.reportDentists} element={<ReportDentists reportDoctors={reportDoctors} />}></Route>
                <Route path={routeAddresses.reportDentistSchedule} element={<ReportDoctorShedule reportDoctors={reportDoctors} onGetReportSubmit={onGetReportSubmit} />}></Route>
                <Route path={routeAddresses.reportDentistScheduleResult} element={<ReportDoctorSchaduleResult reportDoctorSchedole={reportDoctorSchedole} />}></Route>
                <Route path={routeAddresses.dentists} element={<Dentists dentists={dentists} onEditDentistClick={onEditDentistClick} onDeleteDentistClick={onDeleteDentistClick} />}></Route>
                <Route path={routeAddresses.createDentist} element={<CreateDentist onCreateDentistSubmit={onCreateDentistSubmit} />}></Route>
                <Route path={routeAddresses.editDentist} element={<EditDentist onEditDentistSubmit={onEditDentistSubmit} doctor={doctor} />}></Route>
                <Route path={routeAddresses.createSchedule} element={<CreateSchedule doctors={dentists} onCreateScheduleSubmit={onCreateScheduleSubmit}/>}></Route>
                <Route path={routeAddresses.registration} element={<Registration onRegistrationSubmit={onRegistrationSubmit} />}></Route>
                <Route path={routeAddresses.login} element={<Login onLoginSubmit={inputData.onLoginSubmit} />}></Route>
                <Route path={routeAddresses.logout} element={<Logout onLogout={onLogout} />}></Route>
            </Routes>
        </main>
    );
}