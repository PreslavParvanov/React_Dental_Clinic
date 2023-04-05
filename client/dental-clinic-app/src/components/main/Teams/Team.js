import { DentistItem } from './DentistItem';

export const Team = (
    inputData
) => {
    return (
        <>
            <h1 className="text-center">Teams</h1>
            <table className="tbl-team">
                <tbody>
                    {inputData.dentists.map(x => <DentistItem key={x.id} id={x.id} Name={x.name} Qualification={x.qualification} ImageUrl={x.imageUrl} MoreInfo={x.moreInfo} onBookedSubmit={inputData.onBookedSubmit} />)}
                </tbody>
            </table>
        </>
    );
}

