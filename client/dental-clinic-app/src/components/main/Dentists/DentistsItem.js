
export const DentistsItem = (
    inputData
) => {
    return (
        <>
            <tr>
                <td scope="col">
                    <button onClick={inputData.onEditDentistClick}>edit</button>
                </td>
                <td scope="col">
                    <button onClick={inputData.onDeleteDentistClick}>delete</button>
                </td>
                <td scope="col" id='doctorId' hidden> {inputData.date.id}</td>
                <td scope="col">{inputData.date.name}</td>
                <td scope="col">{inputData.date.qualification}</td>
                <td scope="col">{inputData.date.moreInfo}</td>
            </tr >
        </>
    );
}
