import {Routes, Route} from 'react-router-dom';

import {useEffect, useState} from 'react';

import { routeAddresses } from '../../Router';
import { DentalServices } from './DentalServices/DentalServices';

import * as dentalServicesService from '../../services/DentalServicesService';
import * as getReportDoctors from '../../services/ReportService';
import * as DoctorService from '../../services/DoctorService';

import { Home } from "./Home";
import { Team } from './Teams/Team';
import { Reports } from './Reports/Reports';
import { ReportDentists } from './Reports/ReportDentists';
import { ReportDoctorShedule } from './Reports/ReportDoctorShedule';


export const Main = () => {

    const [dentServices, setDentServices] = useState([]);
    const [reportDoctors, setreportDoctors] = useState([]);
    const [dentists, setDentists] = useState([]);

    useEffect(()=>{
        dentalServicesService.getAllDentalServices()
        .then(result =>{
            setDentServices(result);
        })
    },[]);

    useEffect(() => {
        getReportDoctors.getReportDoctors()
            .then(result => {
                setreportDoctors(result);
            })
    }, []);

    useEffect(()=>{
        DoctorService.getAllDoctors()
        .then(result =>{
            setDentists(result);
        })
    },[]);

    const onGetReportSubmit = async (data) => {
        console.log(data);
        //const newGame = await gameService.create(data);

        //setGames(state => [...state, newGame]);

        //navigate('/catalog');
    };

    return (
        <main b-j3bformqou="" role="main" className="pb-3">
            <Routes>
                <Route path={routeAddresses.home} element={<Home />}></Route>
                <Route path={routeAddresses.dentalServices} element={<DentalServices dentServices={dentServices}/>}></Route>
                <Route path={routeAddresses.team} element={<Team dentists={dentists}/>}></Route>
                <Route path={routeAddresses.reports} element={<Reports />}></Route>
                <Route path={routeAddresses.reportDentists} element={<ReportDentists reportDoctors={reportDoctors}/>}></Route>
                <Route path={routeAddresses.reportDentistSchedule} element={<ReportDoctorShedule reportDoctors={reportDoctors} onGetReportSubmit={onGetReportSubmit}/>}></Route>
            </Routes>
            
        </main>
    );
}