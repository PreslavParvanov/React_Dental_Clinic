const baseUrl = 'https://localhost:7187/Team';

export const getAllDoctors = async () =>{

    const response = await fetch( `${baseUrl}/GetAllDoctors`);
    const result = await response.json();
    return result ;
};

//8867f1f2-ebda-4703-b187-bd268568690e

export const getDoctorById = async(doctorId) =>{
    const response = await fetch(`${baseUrl}/GetDoctorById?doctorId=${doctorId}`);
    const result = await response.json();
    return result ;
}
