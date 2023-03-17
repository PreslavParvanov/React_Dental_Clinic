const baseUrl = 'https://localhost:7187/DentalService/GetDentalService';

export const getAllDentalServices = async () =>{

    const response = await fetch(baseUrl);
    const result = await response.json();
    return result ;
};
