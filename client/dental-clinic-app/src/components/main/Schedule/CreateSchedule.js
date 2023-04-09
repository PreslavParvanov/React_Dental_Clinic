import { DoctorSelectOprion } from './DoctorSelectOption';
import * as DateConvertor from '../../../utils/ConvertDate'; 

import { useForm } from '../../../hooks/useForm';

const CreateScheduleFormKeys = {
    DoctorId: 'doctorId',
    StartDate: 'startDate',
    EndDate: 'endDate'
};


export const CreateSchedule = (
    inputData
) => {
    var d = new Date();
    const { values, changeHandler, onSubmit } = useForm({
        [CreateScheduleFormKeys.StartDate]: DateConvertor.ConvertDateTime_YYYYMMDD(d),
        [CreateScheduleFormKeys.EndDate]: DateConvertor.ConvertDateTime_AddDays_YYYYMMDD(d,5),
    }, inputData.onCreateScheduleSubmit);
    
    console.log(inputData.doctors);
    return (
        <>
            <h1 className="text-center">Create doctor schedule</h1>
            <form className="create-dentist-schedule-form" method="post" onSubmit={onSubmit}>
                <div className="form-field">
                    <select id='selectedDoctor' className="form-control" >
                        {inputData.doctors.map(x => <DoctorSelectOprion key={x.id} Name={x.name} Id={x.id} />)}
                    </select>
                </div>
                <div className="create-dentist-schedule-field">
                    <input
                        type="date"
                        id={CreateScheduleFormKeys.StartDate}
                        name={CreateScheduleFormKeys.StartDate}
                        value={values[CreateScheduleFormKeys.StartDate]}
                        onChange={changeHandler}
                    />
                </div>
                <span></span>
                <div className="create-dentist-schedule-field">
                    <input
                        type="date"
                        id={CreateScheduleFormKeys.EndDate}
                        name={CreateScheduleFormKeys.EndDate}
                        value={values[CreateScheduleFormKeys.EndDate]}
                        onChange={changeHandler}
                    />
                </div>
                <span></span>
                <div className="create-dentist-schedule-fieled">
                    <label>Work time</label>
                    <select id='selectedStartTime' className="start-time">
                        <option value="10:00:00">10:00</option>
                        <option value="10:30:00">10:30</option>
                        <option value="11:00:00">11:00</option>
                        <option value="11:30:00">11:30</option>
                        <option value="12:00:00">12:00</option>
                        <option value="12:30:00">12:30</option>
                        <option value="13:00:00">13:00</option>
                        <option value="13:30:00">13:30</option>
                        <option value="14:00:00">14:00</option>
                        <option value="14:30:00">14:30</option>
                        <option value="15:00:00">15:00</option>
                        <option value="15:30:00">15:30</option>
                        <option value="16:00:00">16:00</option>
                        <option value="16:30:00">16:30</option>
                        <option value="17:00:00">17:00</option>
                        <option value="17:30:00">17:30</option>
                        <option value="18:00:00">18:00</option>
                        <option value="18:30:00">18:30</option>
                        <option value="19:00:00">19:00</option>
                    </select>
                    <select id='selectedEndTime' className="end-time">
                        <option value="10:00:00">10:00</option>
                        <option value="10:30:00">10:30</option>
                        <option value="11:00:00">11:00</option>
                        <option value="11:30:00">11:30</option>
                        <option value="12:00:00">12:00</option>
                        <option value="12:30:00">12:30</option>
                        <option value="13:00:00">13:00</option>
                        <option value="13:30:00">13:30</option>
                        <option value="14:00:00">14:00</option>
                        <option value="14:30:00">14:30</option>
                        <option value="15:00:00">15:00</option>
                        <option value="15:30:00">15:30</option>
                        <option value="16:00:00">16:00</option>
                        <option value="16:30:00">16:30</option>
                        <option value="17:00:00">17:00</option>
                        <option value="17:30:00">17:30</option>
                        <option value="18:00:00">18:00</option>
                        <option value="18:30:00">18:30</option>
                        <option value="19:00:00">19:00</option>
                    </select>
                </div>
                <div className="create-dentist-schedule">
                    <button className="usr-btn" type="submit">Save</button>
                </div>
            </form>
        </>
    )
}