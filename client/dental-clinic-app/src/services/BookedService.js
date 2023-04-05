const baseUrl = 'https://localhost:7187/Booked';

export const getDentistSchedule = async(doctorId, startDate, endDate) =>{
    const url = `${baseUrl}/GetDentistSchedule`;

    const result = fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            doctorId,
            startDate,
            endDate
            }) 
        })
        .then(res => res.json());
    return result ;
}

//who - f86bbf07-2f0b-4e1a-8049-72eaf3e16775
export const Booked = async(doctorId,dateBooked,user, customerName, customerEmail, customerPhone) =>{
    const url = `${baseUrl}/Booked?doctorId=${doctorId}&dateBooked=${dateBooked}&user=${user}&customerName=${customerName}&customerEmail=${customerEmail}&customerPhone=${customerPhone}`;
    fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            doctorId,
            dateBooked,
            user,
            customerName,
            customerEmail,
            customerPhone
            }) 
        })
        .then(res => res.json());
}
/*function registerAdapter(email,password){
    let url = 'http://localhost:3030/users/register';
    fetch(url, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            email,
            password,
            }) 
        })
            .then(res => res.json())
            .then(user =>{
                if(user.email){ 
                localStorage.clear();
                localStorage.setItem('accessToken', user.accessToken);
                localStorage.setItem('email', user.email);
                localStorage.setItem('userId', user._id);
                page.redirect(`/Home`);
            }else{
                alert(`${user.message}!`);
                }   
            })
            .catch(err =>{
                console.log(err);
                alert('System error!');
            })

        }*/
