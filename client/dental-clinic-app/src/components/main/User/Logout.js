import { useEffect } from 'react';
import { Navigate } from 'react-router-dom';


export const Logout = (
    inputData
) => {
    useEffect(() => {
        inputData.onLogout();
    }, [inputData.onLogout]);

    return <Navigate to="/" /> 
};