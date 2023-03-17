using DentalClinic.BL.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IReportService
    {
        Task<IEnumerable<ReportDoctorViewModel>> GetAllDentists();
        Task<IEnumerable<ReportDoctorScheduleViewModel>> GetDentistScheduleByDate(Guid DoctorId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<ReportDoctorCustomerViewModel>> GetDoctorCustomerByDate(Guid doctorId, DateTime dateStart, DateTime dateEnd);
    }
}
