const baseUrl = 'https://localhost:7187/Booked';

export const getDentistSchedule = async (doctorId, startDate, endDate) => {
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
    return result;
}

export const Booked = async (doctorId, dateBooked, user) => {
    const url = `${baseUrl}/Booked`;

    const result = fetch(`${url}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            doctorId,
            dateBooked,
            user
        })
    })
    return result;
}
