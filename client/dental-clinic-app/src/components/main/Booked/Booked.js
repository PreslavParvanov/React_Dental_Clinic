import { BookedItems } from './BookedItems';
import * as DateConvertor  from '../../../utils/ConvertDate';
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
                {uniqueDate.map(x => <BookedItems key={Math.random()} date={x} Info={inputData} />)} 
            </table>
        </>
    );
}

