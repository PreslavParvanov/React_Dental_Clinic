import { isDisabled } from '@testing-library/user-event/dist/utils';
import * as DateConvertor from '../../../utils/ConvertDate';

export const BookedItem = (
    inputData
) => {
    var date = new Date(inputData.data.startDate);
    var isBusy = inputData.data.isBusy;
    return (
        <>
            <td className="col">
                <form method="post">
                    <input asp-for="@date.DoctorId" type="text" name="DoctorId" placeholder="DoctorId" required hidden />
                    <input asp-for="@date.Doctors" type="text" name="Doctors" placeholder="Doctors" required hidden />
                    <input asp-for="@date.startDate" type="text" name="startDate" placeholder="startDate" required hidden />
                    {isBusy ===true && (<button className="ds-booked" disabled >{DateConvertor.ConvertDateTime_HHMI(date)}</button>)}
                    {isBusy ===false && (<button className="ds-booked" >{DateConvertor.ConvertDateTime_HHMI(date)}</button>)}
                    
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
