import { ReportDentistItem } from './ReportDentistItem';
import * as DateConvertor from '../../../utils/ConvertDate';


export const ReportDentists = (
    reportDoctors
) => {
    var d = new Date();
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
                <tbody>
                {Object.values(reportDoctors)[0].map(x => <ReportDentistItem key={x.id} Name={x.name} Qualification={x.qualification} MoreInfo={x.moreInfo} />)}
                </tbody>
            </table>
            <hr />
            <div className="report-info">
                <p className="report-criteria">Report date: {DateConvertor.ConvertDateTime_DDMMYYYY_HHMISS(d)}</p>
                <p className="report-criteria">Prepare: @ViewBag.reportUserName</p>
            </div>
        </>
    )
}