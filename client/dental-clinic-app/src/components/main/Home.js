import imgUrl from '../../images/Home.png';


export const Home = () => {
    return (
        <>
            <div className="home">
                <img className="home-img" src={imgUrl} alt="home page" />
            </div>

            <div className="text-center">
                <h1 className="display-4">Welcome </h1>
            </div>
        </>
    );
}

