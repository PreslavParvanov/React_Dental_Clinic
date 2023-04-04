const baseUrl = 'https://localhost:7187/Report';

export const getReportDoctors = async () =>{

    const response = await fetch( `${baseUrl}/GetReportDoctors`);
    const result = await response.json();
    return result ;
};