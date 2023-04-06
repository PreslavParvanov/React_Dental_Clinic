import * as DateConvertor  from '../../../utils/ConvertDate';
import { BookedItem } from './BookedItem';

export const BookedItems = (
    inputData
) => {
    var dataInfo = [];
    for (const element of inputData.Info.booked) {
        var date = new Date(element.startDate);
        if(DateConvertor.ConvertDateTime_DDMMYYYY(date) === inputData.date){
            dataInfo.push(element);
        }
    }

    return (
        <>
            <tr className="booked-tr">
            <td scope="col">{inputData.date}</td>
            {dataInfo.map(x => <BookedItem key={Math.random()} data={x} />)} 
            </tr>

        </>
    );
}
