const baseUrl = 'https://localhost:7187/Report';

export const getReportDoctors = async () =>{

    const response = await fetch( `${baseUrl}/GetReportDoctors`);
    const result = await response.json();
    return result ;
};


export const getReportDoctorSchedule = async(doctorId,startDate, endDate) =>{
    const url = `${baseUrl}/GetDoctorSchedule?doctorId=${doctorId}&startDate=${startDate}&endDate=${endDate}`;
    const response = await fetch(url);
    const result = await response.json();
    return result ;
}