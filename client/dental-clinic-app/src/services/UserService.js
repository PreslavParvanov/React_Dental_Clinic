const baseUrl = 'https://localhost:7187/User';

export const Registration = async (firstName, lastName, email, phonenumber, password, rePassword) => {
    const url = `${baseUrl}/Registration`;
    var isActive = 1;
    const result = fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            firstName,
            lastName,
            email,
            phonenumber,
            password,
            rePassword,
            isActive
        })
    })
    return result;
}

export const Login = async (email, password) => {
    const url = `${baseUrl}/Login`;
    const result = fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            email,
            password
        })
    })
    return result;
}
