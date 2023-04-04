export const ReportDentistItem = (
    reportDoctors
) => {
    return (
        <>
            <tr>
                <td scope="col">{reportDoctors.Name}</td>
                <td scope="col">{reportDoctors.Qualification}</td>
                <td scope="col">{reportDoctors.MoreInfo}</td>
                <td scope="col">Active</td>
            </tr>
        </>
    )
}