export const ReportDentists = () => {
    return (
        <>
            <h1 className="text-center">Report Dentists</h1>
            <div className="report-criteria">
                <p>Criteria:</p>
                <p className="report-criteria">- Dentist: All</p>
            </div>
            <hr />
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">Name</th>
                        <th scope="col">Qualification</th>
                        <th scope="col">More Information</th>
                        <th scope="col">Status</th>
                    </tr>
                </thead>
                
            </table>
            <hr />
            <div className="report-info">
                <p className="report-criteria">Report date: {Date.now()}</p>
                <p className="report-criteria">Prepare: @ViewBag.reportUserName</p>
            </div>
        </>
    )
}