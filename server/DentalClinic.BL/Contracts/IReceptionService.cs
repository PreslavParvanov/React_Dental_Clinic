using DentalClinic.BL.Models;
using DentalClinic.BL.Service;

namespace DentalClinic.BL.Contracts
{
    public interface IReceptionService
    {
        Task<IEnumerable<ReceptionViewModel>> GetAllBookedByDate(DateTime dateStart, DateTime dateEnd);
        Task<ReceptionCustomerViewModel> GetBookedDetailsById(Guid DoctorId, string CustomerId, DateTime DateTimeSchedule, IEnumerable<DentalServiceViewModel> dentalService);
    }
}
