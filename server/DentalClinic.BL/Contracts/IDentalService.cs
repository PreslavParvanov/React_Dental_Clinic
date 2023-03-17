using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IDentalService
    {
        Task Create(DentalServiceViewModel serviceViewModel);
        Task<IEnumerable<DentalServiceViewModel>> GetAll();
        Task<IEnumerable<DentalServiceViewModel>> GetServiceById(Guid serviceId);
        
       
    }
}
