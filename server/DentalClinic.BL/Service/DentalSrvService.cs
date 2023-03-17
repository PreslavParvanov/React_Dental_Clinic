using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class DentalSrvService : IDentalService
    {
        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// </param>
        public DentalSrvService(IRepository _repo)
        {
            repo = _repo;
        }

        /// <summary>
        /// Create dental service
        /// </summary>
        /// <param name="dentalServiceViewModel"></param>
        /// <returns></returns>
        public async Task Create(DentalServiceViewModel dentalServiceViewModel)
        {

            var service = new DentalService()
            {
                ServiceName = dentalServiceViewModel.ServiceName,
                ServiceDescription= dentalServiceViewModel.ServiceDescription,
                Who = dentalServiceViewModel.Who,
                When = DateTime.Now
            };


            await repo.AddAsync(service);
            await repo.SaveChangesAsync();
        }
        /// <summary>
        /// Get all dental services
        /// </summary>
        /// <returns>ToList whit DentalServiceViewModel</returns>
        public async Task<IEnumerable<DentalServiceViewModel>> GetAll()
        {      
                var result = await repo.AllReadonly<DentalService>()
                .Select(ds => new DentalServiceViewModel()
                {
                    Id = ds.Id,
                    ServiceName = ds.ServiceName,
                    ServiceDescription = ds.ServiceDescription,
                }).ToListAsync();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns>ToList whit GetDoctorViewModel</returns>
        public async Task<IEnumerable<DentalServiceViewModel>> GetServiceById(Guid dentalServiceId)
        {
            var result = await repo.AllReadonly<DentalService>()
                .Where(ds => ds.Id== dentalServiceId)
                .Select(ds => new DentalServiceViewModel()
                {
                    ServiceName = ds.ServiceName,
                    ServiceDescription = ds.ServiceDescription,
                }).ToListAsync();

            return result;
        }
    }
}
