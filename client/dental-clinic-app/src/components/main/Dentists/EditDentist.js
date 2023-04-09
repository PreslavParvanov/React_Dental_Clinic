import { useForm } from '../../../hooks/useForm';

const EditDentistFormKeys = {
    Id: 'id',
    Name: 'name',
    Qualification: 'qualification',
    MoreInfo: 'moreInfo'
};

export const EditDentist = (
    inputData
) => {
    console.log(inputData.doctor[0]);
    console.log(inputData.doctor[0].name);
    const { values, changeHandler, onSubmit } = useForm({
        [EditDentistFormKeys.Id]: inputData.doctor[0].id,
        [EditDentistFormKeys.Name]:  inputData.doctor[0].name,
        [EditDentistFormKeys.Qualification]: inputData.doctor[0].qualification,
        [EditDentistFormKeys.MoreInfo]: inputData.doctor[0].moreInfo,
    }, inputData.onEditDentistSubmit);
    return (
        <>
            <h1 className="create-dentist">Create Dentist</h1>
            <form className="create-dentist-form" method="post" onSubmit={onSubmit}>
                <div className="form-field">
                    <input
                        type="text"
                        id={EditDentistFormKeys.Name}
                        name={EditDentistFormKeys.Name}
                        value={values[EditDentistFormKeys.Name]}
                        onChange={changeHandler}
                        placeholder="Name"
                        required
                    />
                </div>
                <span></span>
                <div className="form-field">
                    <input
                        type="text"
                        id={EditDentistFormKeys.Qualification}
                        name={EditDentistFormKeys.Qualification}
                        value={values[EditDentistFormKeys.Qualification]}
                        onChange={changeHandler}
                        placeholder="Qualification"
                        required
                    />
                </div>
                <span></span>
                <div className="form-field">
                    <input
                        type="text"
                        id={EditDentistFormKeys.MoreInfo}
                        name={EditDentistFormKeys.MoreInfo}
                        value={values[EditDentistFormKeys.MoreInfo]}
                        onChange={changeHandler}
                        placeholder="More Info"
                        required
                    />
                </div>
                <span></span>
                <div className="form-field">
                    <input
                        type="text"
                        id={EditDentistFormKeys.Id}
                        name={EditDentistFormKeys.Id}
                        value={values[EditDentistFormKeys.Id]}
                        onChange={changeHandler}
                        hidden
                    />
                </div>
                <div>
                    <button className="usr-btn" type="submit">Save</button>
                </div>
            </form>
        </>
    )
}