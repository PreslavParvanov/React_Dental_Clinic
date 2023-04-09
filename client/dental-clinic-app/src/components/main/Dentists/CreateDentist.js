import { useForm } from '../../../hooks/useForm';

const CreateDentistFormKeys = {
    Name: 'name',
    Qualification: 'qualification',
    MoreInfo: 'moreInfo'
};

export const CreateDentist = (
    inputData
) => {
    console.log(inputData);
    const { values, changeHandler, onSubmit } = useForm({
        [CreateDentistFormKeys.Name]: '',
        [CreateDentistFormKeys.Qualification]: '',
        [CreateDentistFormKeys.MoreInfo]: '',
    }, inputData.onCreateDentistSubmit);
    return (
        <>
            <h1 className="create-dentist">Create Dentist</h1>
            <form className="create-dentist-form" method="post" onSubmit={onSubmit}>
                <div className="form-field">
                    <input 
                        type="text" 
                        id={CreateDentistFormKeys.Name} 
                        name={CreateDentistFormKeys.Name} 
                        value={values[CreateDentistFormKeys.Name]}
                        onChange={changeHandler}
                        placeholder="Name" 
                        required 
                    />
                </div>
                <span></span>
                <div className="form-field">
                    <input 
                        type="text" 
                        id={CreateDentistFormKeys.Qualification} 
                        name={CreateDentistFormKeys.Qualification} 
                        value={values[CreateDentistFormKeys.Qualification]}
                        onChange={changeHandler}
                        placeholder="Qualification" 
                        required 
                    />
                </div>
                <span></span>
                <div className="form-field">
                    <input 
                        type="text" 
                        id={CreateDentistFormKeys.MoreInfo} 
                        name={CreateDentistFormKeys.MoreInfo} 
                        value={values[CreateDentistFormKeys.MoreInfo]}
                        onChange={changeHandler}
                        placeholder="More Info" 
                        required 
                    />
                </div>
                <span></span>
                <div>
                    <button className="usr-btn" type="submit">Save</button>
                </div>
            </form>
        </>
    )
}