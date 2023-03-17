
//import {useEffect, useState} from 'react';

import './lib/bootstrap/dist/css/bootstrap.min.css';
import './App.css';

//import * as dentalServicesService from './services/DentalServicesService';
//import * as doctorService from './services/DoctorService';
//import * as bookedService from './services/BookedService';

import { Footer } from './components/footer/Footer';
import { Header } from './components/header/Header';
import { Main } from './components/main/Main';

function App() {

  //const [dentalServices, setDentalServices] = useState([]);
    
  //dentalServicesService.getAllDentalServices();
  //doctorService.getAllDoctors();
  //doctorService.getDoctorById('8867f1f2-ebda-4703-b187-bd268568690e');
  //bookedService.getDentistSchedule('8867f1f2-ebda-4703-b187-bd268568690e','03.06.2023','03.12.2023');
  //bookedService.Booked('8867f1f2-ebda-4703-b187-bd268568690e','03.11.2023 17:00:00','f86bbf07-2f0b-4e1a-8049-72eaf3e16775','dim','dim@abv.bg','088');

  

  /*useEffect(()=>{
      dentalServicesService.getAllDentalServices()
      .then(dentalServices => {
        setDentalServices(dentalServices)
      })
      .catch(err =>{
        alert('System error!');
        console.log('Error - ' + err);
      });
    },[]);

    console.log(dentalServices[0].id);*/
  return (
    <>
      <Header />
      <Main />
      <Footer />
    </>
  );
}

export default App;
