import * as DateConvertor from '../../../utils/ConvertDate';

export const ReportDoctorSchaduleResultItem = (
    reportDoctors
) => {
    var status = "Free";
    if(reportDoctors.Status){
        status="Busy"; 
    }
    var date = new Date(reportDoctors.ScheduleDateTime);
    //var dateString = date.getDate()+"."+ (date.getMonth()+1) +"."+ date.getFullYear() + " " + date.getHours() + ":" + date.getMinutes();
    return (
        <>
            <tr>
                <td scope="col">{reportDoctors.Name}</td>
                <td scope="col">{reportDoctors.DayOfWeek}</td>
                <td scope="col">{DateConvertor.ConvertDateTime_DDMMYYYY_HHMI(date)}</td>
                <td scope="col">{status}</td>
            </tr>
        </>
    )
}