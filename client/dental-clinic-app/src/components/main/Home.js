import imgUrl from '../../images/Home.png';


export const Home = (
    inputData
) => {
    return (
        <>
            <div className="text-center">
            {inputData.user.id == undefined && (<h1 className="display-4">Welcome </h1>)}
            {inputData.user.id != undefined && (<h1 className="display-4">Welcome - {inputData.user.firstName +' '+ inputData.user.lastName } </h1>)}
            </div>

            <div className="home">
                <img className="home-img" src={imgUrl} alt="home page" />
            </div>
        </>
    );
}

