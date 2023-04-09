import { DentistsItem } from './DentistsItem';
import { Link } from 'react-router-dom';

export const Dentists = (
    inputData
) => {
    return (
        <>
            <h1 className="text-center" name="Title">All dentist</h1>
            <Link className="reg" to="/Dentist/Create">New dentist</Link>
            <table className="table table-striped">
            <thead>
                    <tr>
                        <th scope="col"></th>
                        <th scope="col"></th>
                        <th scope="col">Name</th>
                        <th scope="col">Qualification</th>
                        <th scope="col">Information</th>
                    </tr>
                </thead>
                <tbody>
                    {inputData.dentists.map(x => <DentistsItem key={x.id} date={x} onEditDentistClick={inputData.onEditDentistClick} onDeleteDentistClick={inputData.onDeleteDentistClick} />)}
                </tbody>
            </table>
        </>
    )
}