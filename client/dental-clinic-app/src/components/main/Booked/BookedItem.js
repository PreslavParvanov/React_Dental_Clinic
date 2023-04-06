import * as DateConvertor from '../../../utils/ConvertDate';

import { useForm } from '../../../hooks/useForm';

const BookedFormKeys = {
    DoctorId: 'doctorId',
    StartDate: 'startDate'
};

export const BookedItem = (
    inputData
) => {
    var date = new Date(inputData.data.startDate);
    var isBusy = inputData.data.isBusy;
    var bookedUser = inputData.data.who;
    const { values, changeHandler, onSubmit } = useForm({
        [BookedFormKeys.DoctorId]: inputData.data.doctorId,
        [BookedFormKeys.StartDate]: inputData.data.startDate,
    }, inputData.onGetBookedSubmit);
    return (
        <>
            <td className="col">
                <form method="post" onSubmit={onSubmit}>
                    <input 
                        type="text" 
                        id={[BookedFormKeys.DoctorId]}
                        name={[BookedFormKeys.DoctorId]}
                        value={values[BookedFormKeys.DoctorId]}
                        onChange={changeHandler}
                        required 
                        hidden 
                    />
                    <input 
                        type="text" 
                        id={[BookedFormKeys.StartDate]}
                        name={[BookedFormKeys.StartDate]}
                        value={values[BookedFormKeys.StartDate]}
                        onChange={changeHandler}
                        required 
                        hidden 
                    />
                    {isBusy ===true && bookedUser!=inputData.user && (<button className="ds-booked"  disabled >{DateConvertor.ConvertDateTime_HHMI(date)}</button>)}
                    {isBusy ===false && (<button className="ds-booked" >{DateConvertor.ConvertDateTime_HHMI(date)}</button>)}
                    {isBusy ===true && bookedUser===inputData.user &&(<button className="ds-booked-my">{DateConvertor.ConvertDateTime_HHMI(date)}</button>)}
                </form>
            </td>

            {//                 if (@date.IsBusy == true)
                //             {
                //                 
                //             }
                //             else
                //             {
                //                 <button className="ds-free">@date.startDate.ToString("HH:mm")</button>
                //             }
                //             }
                //        
            }

        </>
    );
}
