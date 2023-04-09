import { useForm } from '../../../hooks/useForm';
import { Link } from 'react-router-dom';

const LoginFormKeys = {
    Email: 'email',
    Password: 'password',
};


export const Login = (
    inputData
) => {
    const { values, changeHandler, onSubmit } = useForm({
        [LoginFormKeys.Email]: '',
        [LoginFormKeys.Password]: '',
    }, inputData.onLoginSubmit);
    return (
        <>
            <h1 className="text-center">Login</h1>
            <form className="login-form" method="post" onSubmit={onSubmit}>
                <div className="form-field">
                    <input
                        id={LoginFormKeys.Email}
                        type="email"
                        name={LoginFormKeys.Email}
                        value={values[LoginFormKeys.Email]}
                        onChange={changeHandler}
                        placeholder="Email"
                        required
                    />
                </div>
                <div></div>
                <div className="form-field">
                    <input
                        id={LoginFormKeys.Password}
                        type="password"
                        name={LoginFormKeys.Password}
                        value={values[LoginFormKeys.Password]}
                        onChange={changeHandler}
                        placeholder="Password"
                        required
                    />
                </div>
                <div>
                    <button className="usr-btn" type="submit">Login</button>
                </div>
                <div className="container h-100 d-flex justify-content-center">
                    <Link className="reg" to="/Users/Registration">Registration</Link>
                </div>
            </form>
        </>
    );
}