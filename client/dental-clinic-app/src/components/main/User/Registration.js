import { useForm } from '../../../hooks/useForm';

const RegistrationFormKeys = {
    FirstName: 'firstname',
    LastName: 'lastname',
    Email: 'email',
    Phonenumber: 'phonenumber',
    Password: 'password',
    RePassword: 'repassword'
};


export const Registration = (
    inputData
) => {
    const { values, changeHandler, onSubmit } = useForm({
        [RegistrationFormKeys.FirstName]: '',
        [RegistrationFormKeys.LastName]: '',
        [RegistrationFormKeys.Email]: '',
        [RegistrationFormKeys.Phonenumber]: '',
        [RegistrationFormKeys.Password]: '',
        [RegistrationFormKeys.RePassword]: '',
    }, inputData.onRegistrationSubmit);
    return (
        <>
            <h1 className="text-center">Registration</h1>
            <form className="registration-form" method="post" onSubmit={onSubmit}>
                
                
                <div className="form-field">
                    <input
                        type="text"
                        id={RegistrationFormKeys.FirstName}
                        name={RegistrationFormKeys.FirstName}
                        value={values[RegistrationFormKeys.FirstName]}
                        onChange={changeHandler}
                        placeholder="First name" 
                    />
                </div>
                <div></div>
                <div className="form-field">
                    <input
                        id={RegistrationFormKeys.LastName}
                        type="text"
                        name={RegistrationFormKeys.LastName}
                        value={values[RegistrationFormKeys.LastName]}
                        onChange={changeHandler}
                        placeholder="Last name"
                        required />
                </div>
                <div></div>
                <div className="form-field">
                    <input
                        id={RegistrationFormKeys.Email}
                        type="email"
                        name={RegistrationFormKeys.Email}
                        value={values[RegistrationFormKeys.Email]}
                        onChange={changeHandler}
                        placeholder="Email"
                        required
                    />
                </div>
                <div></div>
                <div className="form-field">
                    <input
                        id={RegistrationFormKeys.Phonenumber}
                        type="text"
                        name={RegistrationFormKeys.Phonenumber}
                        value={values[RegistrationFormKeys.Phonenumber]}
                        onChange={changeHandler}
                        placeholder="Phone number"
                        required
                    />
                </div>
                <div></div>
                <div className="form-field">
                    <input
                        id={RegistrationFormKeys.Password}
                        type="password"
                        name={RegistrationFormKeys.Password}
                        value={values[RegistrationFormKeys.Password]}
                        onChange={changeHandler}
                        placeholder="Password"
                        required
                    />
                </div>
                <div></div>
                <div className="form-field">
                    <input
                        id={RegistrationFormKeys.RePassword}
                        type="password"
                        name={RegistrationFormKeys.RePassword}
                        value={values[RegistrationFormKeys.RePassword]}
                        onChange={changeHandler}
                        placeholder="Repassword"
                        required
                    />
                </div>
                <div>
                    <button className="usr-btn" type="submit">Registration</button>
                </div>
            </form>
        </>
    );
}