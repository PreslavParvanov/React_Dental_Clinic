using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class ReportService : IReportService
    {
        private readonly IConfiguration config;

        public ReportService(IConfiguration _config)
        {
            config = _config;
        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public ReportService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }
        /// <summary>
        /// Get all doctors
        /// </summary>
        /// <returns>ToList whit ReportDoctorViewModel</returns>

        public async Task<IEnumerable<ReportDoctorViewModel>> GetAllDentists()
        {
            var result = await repo.AllReadonly<Doctor>()
                .Select(d => new ReportDoctorViewModel()
                {
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo,
                    IsActive = d.IsActive
                })
                .OrderBy(d => d.Name)
                .ToListAsync();
            return result;
        }

        public async Task<IEnumerable<ReportDoctorScheduleViewModel>> GetDentistScheduleByDate(Guid DoctorId, DateTime startDate, DateTime endDate)
        {
            var result = await repo.AllReadonly<DoctorSchedule>()
                .Where(ds => ds.DoctorId==DoctorId && ds.ScheduleDateTime>= startDate && ds.ScheduleDateTime <= endDate)
                .Select(ds => new ReportDoctorScheduleViewModel()
                {
                    Id = ds.DoctorId,
                    DoctorName = ds.Doctors.Name,
                    DayOfWeek = ds.ScheduleDateTime.DayOfWeek.ToString(),
                    ScheduleDateTime = ds.ScheduleDateTime,
                    IsBusy = ds.IsBusy
                })
                .OrderBy(ds => ds.ScheduleDateTime)
                .ToListAsync();
            return result;
        }

        /// <summary>
        /// Мethod that lists the doctor's schedule to date 
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="dateStart"></param>
        /// /// <param name="dateEnd"></param>
        /// <returns>ToList whit ReportDoctorCustomerViewModel</returns>
        public async Task<IEnumerable<ReportDoctorCustomerViewModel>> GetDoctorCustomerByDate(Guid doctorId, DateTime dateStart, DateTime dateEnd)
        {
            var result = await repo.AllReadonly<DoctorCustomer>()
                .Where(ds => ds.DoctorId == doctorId
                    && ds.DateTime >= dateStart
                    && ds.DateTime <= dateEnd)
                .Select(ds => new ReportDoctorCustomerViewModel()
                {
                    DoctorName = ds.Doctors.Name,
                    DateTimeSchedule = ds.DateTime,
                    CustomerName = ds.CustomerName,
                    CustomerEmail = ds.CustomerEmail,
                    CustomerPhone = ds.CustomerPhone
                })
                .OrderBy(ds => ds.DateTimeSchedule)
                .ToListAsync();
            return result;
        }
    }
}
