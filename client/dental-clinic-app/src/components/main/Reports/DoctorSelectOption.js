export const DoctorSelectOprion = (
    doctors
) => {
    return (
        
        <option name="doctorId" value={doctors.id}> {doctors.Name}</option>
    )
}