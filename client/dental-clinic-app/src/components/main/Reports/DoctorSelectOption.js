export const DoctorSelectOprion = (
    doctors
) => {
    return (
        <option name="doctorId" value={doctors.Id}> {doctors.Name}</option>
    )
}