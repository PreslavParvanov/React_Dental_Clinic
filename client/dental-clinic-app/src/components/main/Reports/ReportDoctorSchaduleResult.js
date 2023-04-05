import { ReportDoctorSchaduleResultItem } from './ReportDoctorSchaduleResultItem';
import * as DateConvertor from '../../../utils/ConvertDate';

export const ReportDoctorSchaduleResult = (
    reportDoctors
) => {
    var d = new Date();
    return (
        <>
            <h1 className="text-center">Report doctor schedule</h1>
            <div className="report-criteria">
                <p>Criteria:</p>
                <p className="report-criteria">- Dentist: {Object.values(reportDoctors)[0][0].doctorName}</p>
            </div>
            <hr />
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">Doctor name</th>
                        <th scope="col">Day of week</th>
                        <th scope="col">Date and time</th>
                        <th scope="col">Status</th>
                    </tr>
                </thead>
                <tbody>
                    {Object.values(reportDoctors)[0].map(x => <ReportDoctorSchaduleResultItem key={Math.random()} Name={x.doctorName} DayOfWeek={x.dayOfWeek} ScheduleDateTime={x.scheduleDateTime} Status={x.isBusy}/>)}
                </tbody>
            </table>
            <hr />
            <div className="report-info">
                <p className="report-criteria">Report date: {DateConvertor.ConvertDateTime_DDMMYYYY_HHMI(d)}</p>
                <p className="report-criteria">Prepare: @ViewBag.reportUserName</p>
            </div>
        </>
    )
}