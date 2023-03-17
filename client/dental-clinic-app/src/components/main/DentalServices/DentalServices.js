import { DentalServicesItem } from "./DentalServicesItem";

export const DentalServices = (
    dentServices
    
) => {
    return (
        <>
            <div className="dental-services-logo">
                <img className="home-img" src="https://res.cloudinary.com/ddfrnob2x/image/upload/v1671286978/Services_jwslxc.jpg" />
            </div>

            <h1 className="dental-service-h1">Dental Service</h1>
                {Object.values(dentServices)[0].map(x => <DentalServicesItem key={x.id} serviceName={x.serviceName} serviceDescription={x.serviceDescription}/>)}
        </>
    );
}



/*@{
    foreach(var dentalService in Model)
        {
    
}
    }*/