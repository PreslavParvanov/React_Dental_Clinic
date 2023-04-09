import { Link } from 'react-router-dom';
import { useContext } from 'react';

import { routeAddresses } from '../../Router';

import { AuthContext } from '../../contexts/AuthContext';

export const Navigation = () => {
    const { id, isAuthenticated } = useContext(AuthContext);
    return (
        <nav b-j3bformqou="" className="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
            <div b-j3bformqou="" className="container">
                <Link to={routeAddresses.home}><img b-j3bformqou="" className="navbar-brand" alt="logo" src="http://res.cloudinary.com/ddfrnob2x/image/upload/v1670966541/diuzqrk4scauwwup2m5b.png" /></Link>
                <button b-j3bformqou="" className="navbar-toggler" type="button" data-toggle="collapse" data-target=".navbar-collapse" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span b-j3bformqou="" className="navbar-toggler-icon"></span>
                </button>
                <div b-j3bformqou="" className="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse">
                    <ul b-j3bformqou="" className="navbar-nav flex-grow-1">
                        <li b-j3bformqou="" className="nav-item">
                            <Link className="nav-link text-dark" to="/">Home</Link>
                        </li>
                        <li b-j3bformqou="" className="nav-item">
                            <Link className="nav-link text-dark" to={routeAddresses.dentalServices}>Services</Link>
                        </li>
                        <li b-j3bformqou="" className="nav-item">
                            <Link className="nav-link text-dark" to="/Team">Team</Link>
                        </li>

                        {isAuthenticated && id == '385061ac-47d3-4265-94df-362492db4d4a' && (
                            <>
                                <li className="nav-item">
                                    <Link className="nav-link text-dark" to={routeAddresses.reports}>Reports</Link>
                                </li>
                                <li className="nav-item">
                                    <Link className="nav-link text-dark" to={routeAddresses.dentists}>Dentist</Link>
                                </li>
                                <li className="nav-item">
                                    <Link className="nav-link text-dark" to={routeAddresses.createSchedule}>Schedule</Link>
                                </li>
                                
                            </>
                        )}

                        {!isAuthenticated && (
                            <>
                                <li b-j3bformqou="" className="nav-item">
                                    <Link className="nav-link text-dark" to="/Users/Login">Login</Link>
                                </li>
                                <li b-j3bformqou="" className="nav-item">
                                    <Link className="nav-link text-dark" to="/Users/Registration">Registration</Link>
                                </li>
                            </>
                        )}
                        {isAuthenticated && (
                            <li b-j3bformqou="" className="nav-item">
                                <Link className="nav-link text-dark" to="/Users/Logout">Logout</Link>
                            </li>
                        )}

                        <ul className="navbar-nav">
                        </ul>
                    </ul>
                </div>
            </div>
        </nav>
    );
}

