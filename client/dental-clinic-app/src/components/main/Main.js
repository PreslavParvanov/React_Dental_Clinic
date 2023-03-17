import {Routes, Route} from 'react-router-dom';

import {useEffect, useState} from 'react';

import { routeAddresses } from '../../Router';
import { DentalServices } from './DentalServices/DentalServices';

import * as dentalServicesService from '../../services/DentalServicesService';
import * as DoctorService from '../../services/DoctorService';

import { Home } from "./Home";
import { Team } from './Teams/Team';


export const Main = () => {

    const [dentServices, setDentServices] = useState([]);
    const [dentists, setDentists] = useState([]);

    useEffect(()=>{
        dentalServicesService.getAllDentalServices()
        .then(result =>{
            setDentServices(result);
        })
    },[]);

    useEffect(()=>{
        DoctorService.getAllDoctors()
        .then(result =>{
            setDentists(result);
        })
    },[]);
    return (
        <main b-j3bformqou="" role="main" className="pb-3">
            <Routes>
                <Route path={routeAddresses.home} element={<Home />}></Route>
                <Route path={routeAddresses.dentalServices} element={<DentalServices dentServices={dentServices}/>}></Route>
                <Route path={routeAddresses.team} element={<Team dentists={dentists}/>}></Route>
            </Routes>
            
        </main>
    );
}