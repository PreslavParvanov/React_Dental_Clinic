export const ReportDentistItem = (
    Name,
    Qualification,
    MoreInfo
) => {
    return (
        <>
            <tr>
                <td scope="col">{Name}</td>
                <td scope="col">{Qualification}</td>
                <td scope="col">{MoreInfo}</td>
                <td scope="col">Active</td>
            </tr>

        </>
    )
}