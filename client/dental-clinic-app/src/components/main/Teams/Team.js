export const Team = (
    dentists
) => {
    console.log(Object.values(dentists)[0]);
    return (
        <>
            <h1 className="text-center">Teams</h1>
            <table className="tbl-team">
                <tbody>

                </tbody>
            </table>
        </>
    );
}

/*@{
    foreach (var doctor in Model)
    {
        
    }
}*/