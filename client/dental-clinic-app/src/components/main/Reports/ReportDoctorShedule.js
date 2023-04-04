import { DoctorSelectOprion } from './DoctorSelectOption';
import { useForm } from '../../../hooks/useForm';


const ReportFormKeys = {
    DoctorId: 'doctorId',
    StartDate: 'startDate',
    EndDate: 'endDate'
};



export const ReportDoctorShedule = (
    inputData
) => {
    console.log(inputData);
    const { values, changeHandler, onSubmit } = useForm({
        [ReportFormKeys.DoctorId]: '',
        [ReportFormKeys.StartDate]: '',
        [ReportFormKeys.EndDate]: '',
    }, inputData.onGetReportSubmit);
    var doctors = inputData.reportDoctors;
    return (
        <>
            <h1 className="text-center">Report doctor schedule</h1>
            <form className="doctor-scedul-form" method="post" onSubmit={onSubmit}>
                <div className="doctor-scedul-field">
                    <select className="form-control" onChange={changeHandler} value={values[ReportFormKeys.DoctorId]}>
                        {doctors.map(x => <DoctorSelectOprion key={x.id} Name={x.name} Id={x.id} />)}
                    </select>
                </div>
                <div className="doctor-scedul-field">
                    <input 
                        type="datetime-local" 
                        id="startDate" 
                        name={ReportFormKeys.StartDate} 
                        value={values[ReportFormKeys.StartDate]}
                        onChange={changeHandler}
                        />
                </div>
                <div></div>
                <div className="doctor-scedul-field">
                    <input 
                        type="datetime-local" 
                        id="endDate" 
                        name={ReportFormKeys.EndDate} 
                        value={values[ReportFormKeys.EndDate]}
                        onChange={changeHandler}
                    />
                </div>
                <div></div>
                <div>
                    <button className="usr-btn" type="submit">Search</button>
                </div>
            </form>
        </>
    );
}