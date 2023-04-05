export const ReportDoctorSchaduleResultItem = (
    reportDoctors
) => {
    var status = "Free";
    if(reportDoctors.Status){
        status="Busy"; 
    }
    var date = new Date(reportDoctors.ScheduleDateTime);
    var dateString = date.getDate()+"."+ (date.getMonth()+1) +"."+ date.getFullYear() + " " + date.getHours() + ":" + date.getMinutes();
    return (
        <>
            <tr>
                <td scope="col">{reportDoctors.Name}</td>
                <td scope="col">{reportDoctors.DayOfWeek}</td>
                <td scope="col">{dateString}</td>
                <td scope="col">{status}</td>
            </tr>
        </>
    )
}