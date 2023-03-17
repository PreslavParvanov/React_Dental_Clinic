export const DentistItem = () => {
    return (
        <form method="post">
            <tr>
                <td class="td-team">
                    <div class="doctor">
                        <input type="text" id="doctor" name="doctor" value=@doctor.Id style="display:none">
                        <input type="text" id="doctorName" name="doctorName" value="@doctor.Name" style="display:none">
                            <div class="doctor-logo">
                                <img src="@doctor.ImageUrl" width="100" height="100">
                            </div>
                            <div class="doctor-name">
                                <h3 name="DocName">@doctor.Name</h3>
                            </div>
                            <div class="doctor-position">
                                <h4>@doctor.Qualification</h4>
                            </div>
                            <div class="doctor-info">
                                <details class="info-details">
                                    <summary class="summary-info">More info</summary>
                                    @doctor.MoreInfo
                                </details>

                            </div>

                            <div class="doctor-btn">
                                <button class="doctor-btn-btn" type="submit">Book now</button>
                            </div>
                    </div>
                </td>
            </tr>
        </form>
    )
}