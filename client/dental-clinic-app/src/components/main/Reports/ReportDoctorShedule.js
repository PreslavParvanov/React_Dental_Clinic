import { DoctorSelectOprion } from './DoctorSelectOption';
import * as DateConvertor from '../../../utils/ConvertDate'; 
import { useForm } from '../../../hooks/useForm';


const ReportFormKeys = {
    DoctorId: 'doctorId',
    StartDate: 'startDate',
    EndDate: 'endDate'
};



export const ReportDoctorShedule = (
    inputData
) => {
    var d = new Date();
    const { values, changeHandler, onSubmit } = useForm({
        [ReportFormKeys.StartDate]: DateConvertor.ConvertDateTime_YYYYMMDD_HHMI(d),
        [ReportFormKeys.EndDate]: DateConvertor.ConvertDateTime_AddDays_YYYYMMDD_HHMI(d,5),
    }, inputData.onGetReportSubmit);
    var doctors = inputData.reportDoctors;
    return (
        <>
            <h1 className="text-center">Report doctor schedule</h1>
            <form className="doctor-scedul-form" method="get" onSubmit={onSubmit}>
                <div className="doctor-scedul-field">
                    <select id='selectedDoctor' className="form-control" >
                        {doctors.map(x => <DoctorSelectOprion key={x.id} Name={x.name} Id={x.id} />)}
                    </select>
                </div>
                <div className="doctor-scedul-field">
                    <input 
                        type="datetime-local" 
                        id={ReportFormKeys.StartDate} 
                        name={ReportFormKeys.StartDate} 
                        value={values[ReportFormKeys.StartDate]}
                        onChange={changeHandler}
                    />
                </div>
                <div></div>
                <div className="doctor-scedul-field">
                    <input 
                        type="datetime-local" 
                        id={ReportFormKeys.EndDate} 
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