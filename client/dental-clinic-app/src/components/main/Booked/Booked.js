import { BookedItems } from './BookedItems';
import * as DateConvertor from '../../../utils/ConvertDate';
var uniqueDate = [];
export const Booked = (
    inputData
) => {
    for (const element of Object.values(inputData)[0]) {
        var date = new Date(element.startDate);
        if (!uniqueDate.includes(DateConvertor.ConvertDateTime_DDMMYYYY(date))) {
            uniqueDate.push(DateConvertor.ConvertDateTime_DDMMYYYY(date));
        }
    }
    return (
        <>
            <h1 className="text-center" name="Title">Make an appointment with a doctor {Object.values(inputData)[0].doctor}</h1>
            <table className="tbl-team">
                <tbody>
                    {uniqueDate.map(x => <BookedItems key={Math.random()} date={x} Info={inputData} />)}
                </tbody>
            </table>

            <h3 className='legend-title'>legend</h3>
            <section className='legend'>
                <div>
                    <label className="legend-label">Free</label>
                    <button className="ds-booked">00:00</button>
                </div>
                <div>
                    <label className="legend-label">My reservation</label>
                    <button className="ds-booked-my">00:00</button>
                </div>
                <div>
                    <label className="legend-label">Busy</label>
                    <button className="ds-booked" disabled >00:00</button>
                </div>
            </section>
        </>
    );
}

