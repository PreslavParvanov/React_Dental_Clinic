export const DentalServicesItem = (
    dentServices
) => {
    return (
        <div className="container h-100 d-flex justify-content-center">
            <details className="info-details">
                <summary className="summary-info">{dentServices.serviceName}</summary>
                {dentServices.serviceDescription}
            </details>
        </div>
    )
}