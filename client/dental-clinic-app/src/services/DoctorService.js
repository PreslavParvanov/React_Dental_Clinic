import { AuthContext } from '../contexts/AuthContext';

import { useContext } from 'react';

const baseUrl = 'https://localhost:7187/Team';

export const getAllDoctors = async () =>{

    const response = await fetch( `${baseUrl}/GetAllDoctors`);
    const result = await response.json();
    return result ;
};


export const getDoctorById = async(doctorId) =>{
    const response = await fetch(`${baseUrl}/GetDoctorById?doctorId=${doctorId}`);
    const result = await response.json();
    return result ;
}

export const createDentist = async (name, qualification, moreInfo, user) => {
    const url = `${baseUrl}/CreateDoctor`;
    var who = user.id;
    var imageUrl = "https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg";
    const result = fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
            'X-Authorization': user.accessToken
        },
        body: JSON.stringify({
            name,
            qualification,
            moreInfo,
            who,
            imageUrl
        })
    })
    return result;
}


export const deleteDentist = async(doctorId, user) =>{
    const result = await fetch(`${baseUrl}/DeleteDoctor?doctorId=${doctorId}&who=${user.id}`,{
        method: 'DELETE',
        headers: {
            'content-type': 'application/json',
            'X-Authorization': user.accessToken
        }
    });
    return result ;
}

export const updateDentist = async (id,name, qualification, moreInfo, user) => {
    const url = `${baseUrl}/UpdateDoctor`;
    var who = user.id;
    var imageUrl = '*****';
    const result = fetch(`${url}`, {
        method: 'PUT',
        headers: {
            'content-type': 'application/json',
            'X-Authorization': user.accessToken
        },
        body: JSON.stringify({
            id,
            name,
            qualification,
            moreInfo,
            who,
            imageUrl
        })
    })
    return result;
}



export const createSchedule = async (doctorId, startDate, endDate,startTime,endTime, user) => {
    const url = `${baseUrl}/CreateSchedule`;
    var who = user.id;
    var isBusy = false;
    const result = fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
            'X-Authorization': user.accessToken
        },
        body: JSON.stringify({
            doctorId, 
            startDate, 
            endDate,
            startTime,
            endTime,
            who,
            isBusy
        })
    })
    return result;
}