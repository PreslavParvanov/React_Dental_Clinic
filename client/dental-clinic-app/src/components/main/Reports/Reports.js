import { Link } from 'react-router-dom';
import { routeAddresses } from '../../../Router';

export const Reports = () => {

    return (
        <div className="Reports">
            <div className="alert alert-secondary" role="alert">
                <Link to={routeAddresses.reportDentists}>Dentists</Link>
            </div>
            <div className="alert alert-secondary" role="alert">
                <Link to={routeAddresses.reportDentistSchedule}>Dentist Schedule</Link>
            </div>
        </div>
    )
}