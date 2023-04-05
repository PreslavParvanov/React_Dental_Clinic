import { useForm } from '../../../hooks/useForm';

const TeamFormKeys = {
    DoctorId: 'doctor',
    Name: 'doctorName',
};

export const DentistItem = (
    inputData
) => {

    const { values, changeHandler, onSubmit } = useForm({
        [TeamFormKeys.DoctorId]: inputData.id,
        [TeamFormKeys.Name]: inputData.Name,
    }, inputData.onBookedSubmit);

    return (

        <tr>
            <td className="td-team">
                <form method="post" onSubmit={onSubmit}>
                    <div className="doctor">
                        <input
                            type="text"
                            id={TeamFormKeys.DoctorId} 
                            name={TeamFormKeys.DoctorId}
                            value={values[TeamFormKeys.DoctorId]}
                            onChange={changeHandler}
                            style={{display:"none"}}
                        />
                        <input
                            type="text"
                            id={TeamFormKeys.Name}
                            name={TeamFormKeys.Name}
                            value={values[TeamFormKeys.Name]}
                            onChange={changeHandler}
                            style={{display:"none"}}
                        />
                        <div className="doctor-logo">
                            <img src={inputData.ImageUrl} width="100" height="100" />
                        </div>
                        <div className="doctor-name">
                            <h3 name="DocName">{inputData.Name}</h3>
                        </div>
                        <div className="doctor-position">
                            <h4>{inputData.Qualification}</h4>
                        </div>
                        <div className="doctor-info">
                            <details className="info-details">
                                <summary className="summary-info">More info</summary>
                                {inputData.MoreInfo}
                            </details>

                        </div>

                        <div className="doctor-btn">
                            <button className="doctor-btn-btn" type="submit">Book now</button>
                        </div>
                    </div>
                </form>
            </td>
        </tr>

    )
}