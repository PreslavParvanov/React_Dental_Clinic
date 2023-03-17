using DentalClinic.BL.Contracts;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using DentalClinic.DB.Data;
using Microsoft.EntityFrameworkCore;
using DentalClinic.BL.Service;

namespace DentalClinic.UnitTests
{
    internal class ReceptionServiceUnitTests
    {
        private List<DoctorCustomer> doctorCustomers;
        private IEnumerable<DentalService> services;

        private IReceptionService receptionService;
        private IRepository repo;
        private ApplicationDbContext dbContext;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var doctor = new Doctor()
            {
                Id = Guid.Parse("4d89d334-1134-487c-bd1d-8b543050d535"),
                Name = "Dr. Ivanov",
                IsActive = 1,
                Qualification = "4 Year",
                MoreInfo = "Doctor More Info",
                Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                When = DateTime.Now,
                ImageUrl = "https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968871/azcedswiusclsovhog5p.jpg"
            };
          
            doctorCustomers = new List<DoctorCustomer>()
            {
                new DoctorCustomer
                {
                    DoctorId = doctor.Id,
                    Doctors = doctor,
                    DateTime = DateTime.ParseExact("2022-12-06 10:30:00,000", "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture),
                    CustomerId = "613807f1-31c8-4523-aa93-a97243da1f1e",
                    CustomerName="Ivan Ivanov",
                    CustomerEmail="customer@dmail.com",
                    CustomerPhone="0888000000",
                    When=DateTime.Now
                },
                new DoctorCustomer
                {
                    DoctorId = doctor.Id,
                    Doctors = doctor,
                    DateTime = DateTime.ParseExact("2022-12-06 11:00:00,000", "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture),
                    CustomerId = "5972406a-1f00-4b42-982d-f6e0718da358",
                    CustomerName="Dimitar Dimitrov",
                    CustomerEmail="customer2@dmail.com",
                    CustomerPhone="0888111111",
                    When=DateTime.Now
                }
            };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;
            this.dbContext = new ApplicationDbContext(options);
            this.dbContext.AddRange(doctorCustomers);
            this.dbContext.SaveChanges();
        }
        [Test]
        public async Task Test_GetAllBookedByDate()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var startSearchDate = DateTime.ParseExact("2022-12-06 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var endSearchDate = DateTime.ParseExact("2022-12-06 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var resultService = await receptionService.GetAllBookedByDate(startSearchDate, endSearchDate);
                var orderListResultService = resultService.OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTimeSchedule).ToList();
                var resultDb = await dbContext.DoctorsCustomers.Where(dc => dc.DateTime >= startSearchDate && dc.DateTime <= endSearchDate).OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTime).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());

                if (resultService.Count() == resultDb.Count())
                {
                    for (int i = 0; i < orderListResultService.Count(); i++)
                    {
                        Assert.That(resultDb[i].DoctorId, Is.EqualTo(orderListResultService[i].DoctorId));
                        Assert.That(orderListResultService[i].DoctorName, Is.EqualTo(resultDb[i].Doctors.Name));
                        Assert.That(resultDb[i].DateTime, Is.EqualTo(orderListResultService[i].DateTimeSchedule));
                        Assert.That(resultDb[i].CustomerId, Is.EqualTo(orderListResultService[i].CustomerId));
                        Assert.That(resultDb[i].CustomerName, Is.EqualTo(orderListResultService[i].CustomerName));
                        Assert.That(resultDb[i].CustomerEmail, Is.EqualTo(orderListResultService[i].CustomerEmail));
                        Assert.That(resultDb[i].CustomerPhone, Is.EqualTo(orderListResultService[i].CustomerPhone));
                    }
                }
            }
        }

        [Test]
        public async Task Test_GetAllBookedByDate_InvalidDate()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var startSearchDate = DateTime.ParseExact("2022-12-06 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var endSearchDate = DateTime.ParseExact("2022-12-05 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                var resultService = await receptionService.GetAllBookedByDate(startSearchDate, endSearchDate);
                var orderListResultService = resultService.OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTimeSchedule).ToList();
                var resultDb = await dbContext.DoctorsCustomers.Where(dc => dc.DateTime >= startSearchDate && dc.DateTime <= endSearchDate).OrderBy(dc => dc.DoctorId).ThenBy(dc => dc.DateTime).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());
            }
        }

        /*[Test]
        public async Task Test_GetBookedDetailsById()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                
                var service = new DentalService
                {
                    Id = Guid.Parse("4d89d334-1134-487c-bd1d-8b543050d535"),
                    ServiceName = "Test",
                    ServiceDescription = "Info",
                    Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                };
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var doctorId = Guid.Parse("4d89d334-1134-487c-bd1d-8b543050d535");
                var customerId = "5972406a-1f00-4b42-982d-f6e0718da358";
                var dateTimeSchedule = DateTime.ParseExact("2022-12-06 11:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                
                var resultService = await receptionService.GetBookedDetailsById(doctorId, customerId, dateTimeSchedule, services);
                var resultDb = await dbContext.DoctorsCustomers
                    .Where(dc => dc.DoctorId==doctorId)
                    .Where(dc => dc.CustomerId == customerId)
                    .Where(dc => dc.DateTime == dateTimeSchedule)
                    .FirstOrDefaultAsync();

                if (resultDb !=null)
                {
                    Assert.That(resultService.DoctorId, Is.EqualTo(resultDb.DoctorId));
                    Assert.That(resultService.DateTimeSchedule, Is.EqualTo(resultDb.DateTime));
                    Assert.That(resultService.CustomerId, Is.EqualTo(resultDb.CustomerId));
                    Assert.That(resultService.CustomerName, Is.EqualTo(resultDb.CustomerName));
                    Assert.That(resultService.CustomerEmail, Is.EqualTo(resultDb.CustomerEmail));
                    Assert.That(resultService.CustomerPhone, Is.EqualTo(resultDb.CustomerPhone));
                }
                else
                {
                    Assert.That("OK", Is.EqualTo("Error"));
                }
            }
        }

        [Test]
        public async Task Test_GetBookedDetailsById_InvalidDoctorId()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var doctorId = Guid.Parse("b6875d05-fe64-4500-ad6d-a69fadccb597");
                var customerId = "5972406a-1f00-4b42-982d-f6e0718da358";
                var dateTimeSchedule = DateTime.ParseExact("2022-12-06 11:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);

                var resultService = await receptionService.GetBookedDetailsById(doctorId, customerId, dateTimeSchedule);
                var resultDb = await dbContext.DoctorsCustomers
                    .Where(dc => dc.DoctorId == doctorId)
                    .Where(dc => dc.CustomerId == customerId)
                    .Where(dc => dc.DateTime == dateTimeSchedule)
                    .FirstOrDefaultAsync();

                if (resultDb != null)
                {
                    Assert.That("OK", Is.EqualTo("Error"));
                }
                else
                {
                    Assert.That("OK", Is.EqualTo("OK"));
                }
            }
        }

        [Test]
        public async Task Test_GetBookedDetailsById_InvalidCustomerId()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var doctorId = Guid.Parse("4d89d334-1134-487c-bd1d-8b543050d535");
                var customerId = "41b65854-a500-4912-9077-24a95afd1875";
                var dateTimeSchedule = DateTime.ParseExact("2022-12-06 11:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);

                var resultService = await receptionService.GetBookedDetailsById(doctorId, customerId, dateTimeSchedule);
                var resultDb = await dbContext.DoctorsCustomers
                    .Where(dc => dc.DoctorId == doctorId)
                    .Where(dc => dc.CustomerId == customerId)
                    .Where(dc => dc.DateTime == dateTimeSchedule)
                    .FirstOrDefaultAsync();

                if (resultDb != null)
                {
                    Assert.That("OK", Is.EqualTo("Error"));
                }
                else
                {
                    Assert.That("OK", Is.EqualTo("OK"));
                }
            }
        }
        
        [Test]
        public async Task Test_GetBookedDetailsById_InvalidDateTimeSchedule()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                receptionService = new ReceptionService(repo);
                var doctorId = Guid.Parse("4d89d334-1134-487c-bd1d-8b543050d535");
                var customerId = "5972406a-1f00-4b42-982d-f6e0718da358";
                var dateTimeSchedule = DateTime.ParseExact("2022-12-31 11:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);

                var resultService = await receptionService.GetBookedDetailsById(doctorId, customerId, dateTimeSchedule);
                var resultDb = await dbContext.DoctorsCustomers
                    .Where(dc => dc.DoctorId == doctorId)
                    .Where(dc => dc.CustomerId == customerId)
                    .Where(dc => dc.DateTime == dateTimeSchedule)
                    .FirstOrDefaultAsync();

                if (resultDb != null)
                {
                    Assert.That("OK", Is.EqualTo("Error"));
                }
                else
                {
                    Assert.That("OK", Is.EqualTo("OK"));
                }
            }
        }
        */
    }
}
