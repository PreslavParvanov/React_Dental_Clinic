using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class DoctorService : IDoctorService
    {

        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public DoctorService(IRepository _repo)
        {
            repo = _repo;
        }
        /// <summary>
        /// Get all active doctors
        /// </summary>
        /// <returns>ToList whit GetDoctorViewModel</returns>
        public async Task<IEnumerable<GetDoctorViewModel>> GetAll()
        {      
                var result = await repo.AllReadonly<Doctor>()
                .Where(d => d.IsActive==1)
                .Select(d => new GetDoctorViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo,
                    ImageUrl = d.ImageUrl
                }).ToListAsync();

            return result;
        }

        /// <summary>
        /// Create doctor
        /// </summary>
        /// <param name="doctorViewModel"></param>
        /// <returns></returns>
        public async Task Create(DoctorViewModel doctorViewModel)
        {
            var doctor = new Doctor()
            {
                Name = doctorViewModel.Name,
                Qualification = doctorViewModel.Qualification,
                MoreInfo = doctorViewModel.MoreInfo,
                IsActive = 1,
                Who = doctorViewModel.Who,
                When = DateTime.Now,
                ImageUrl = doctorViewModel.ImageUrl
            };

            await repo.AddAsync(doctor);
            await repo.SaveChangesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns>ToList whit GetDoctorViewModel</returns>
        public async Task<IEnumerable<GetDoctorViewModel>> GetDoctorById(Guid doctorId)
        {
            var result = await repo.AllReadonly<Doctor>()
                .Where(d => d.IsActive == 1)
                .Where(d => d.Id== doctorId)
                .Select(d => new GetDoctorViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo,
                    ImageUrl = d.ImageUrl
                }).ToListAsync();

            return result;
        }
        /// <summary>
        /// Мethod that lists the doctor's schedule to date 
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="dateStart"></param>
        /// /// <param name="dateEnd"></param>
        /// <returns>ToList whit DoctorScheduleViewModel</returns>
        public async Task<IEnumerable<DoctorScheduleViewModel>> GetDoctorSchedule(Guid doctor, DateTime dateStart, DateTime dateEnd)
        {
            var result = await repo.AllReadonly<DoctorSchedule>()
                .Where(ds => ds.DoctorId == doctor 
                    && ds.ScheduleDateTime >= dateStart
                    && ds.ScheduleDateTime <= dateEnd)
                .Select(ds => new DoctorScheduleViewModel()
                {
                    DoctorId = ds.DoctorId,
                    startDate = ds.ScheduleDateTime,
                    IsBusy = ds.IsBusy,
                })
                .OrderBy(ds => ds.startDate)
                .ToListAsync();
            return result;
        }
        /// <summary>
        /// Booked examination by a doctor
        /// </summary>
        /// <param name="doctorScheduleViewModel"></param>
        /// <returns></returns>
        public async Task Booked(DoctorScheduleViewModel doctorScheduleViewModel, string customerName, string customerEmail, string customerPhone)
        {
            var result = await repo.AllReadonly<DoctorSchedule>()
            .Where(ds => ds.DoctorId == doctorScheduleViewModel.DoctorId 
                && ds.ScheduleDateTime== doctorScheduleViewModel.startDate)
            .FirstOrDefaultAsync();


            if (result!=null)
            {
                result.Who = doctorScheduleViewModel.Who;
                result.IsBusy = true;
                result.When = DateTime.Now;
                repo.Update(result);

                var doctorCustomer = new DoctorCustomer();
                doctorCustomer.DoctorId=doctorScheduleViewModel.DoctorId;
                doctorCustomer.CustomerId = doctorScheduleViewModel.Who;
                doctorCustomer.CustomerName = customerName;
                doctorCustomer.CustomerEmail= customerEmail;
                doctorCustomer.CustomerPhone = customerPhone;
                doctorCustomer.DateTime = doctorScheduleViewModel.startDate;
                doctorCustomer.When = DateTime.Now;
                await repo.AddAsync(doctorCustomer);
                await repo.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            var result = await repo.AllReadonly<Doctor>()
                .Select(d => new Doctor()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo,
                    Who = d.Who,
                    ImageUrl = d.ImageUrl
                })
                .ToListAsync();
            return result;
        }

        /// <summary>
        /// Create chedules by date
        /// </summary>
        /// <param name="doctorScheduleViewModel"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>

        public async Task CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel, TimeSpan startTime, TimeSpan endTime)
        {
            DateTime currentDateTime = doctorScheduleViewModel.startDate+startTime;
            DateTime endDate = doctorScheduleViewModel.endDate + endTime;

            while (endDate >= currentDateTime)
            { 
                var doctorSchedule = new DoctorSchedule()
                {
                    DoctorId = doctorScheduleViewModel.DoctorId,
                    ScheduleDateTime = currentDateTime,
                    Who = doctorScheduleViewModel.Who,
                    When = DateTime.Now,
                    IsBusy = false,
                };
                await repo.AddAsync(doctorSchedule);
                await repo.SaveChangesAsync();

                currentDateTime = currentDateTime.AddMinutes(30);
                //If the hour is greater than endTime, it sets the date of the next day at startTime.
                if (currentDateTime > (currentDateTime.Date+endTime))
                {
                    currentDateTime = currentDateTime.AddDays(1).Date + startTime;
                }
            }
        }

        
    }
}
