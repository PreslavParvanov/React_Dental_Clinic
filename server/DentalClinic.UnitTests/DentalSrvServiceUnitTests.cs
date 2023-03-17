using DentalClinic.BL.Contracts;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using DentalClinic.DB.Data;
using Microsoft.EntityFrameworkCore;
using DentalClinic.BL.Service;
using DentalClinic.BL.Models;


namespace DentalClinic.UnitTests
{
    internal class DentalSrvServiceUnitTests
    {
        private List<DentalService> dentalServices;

        private IDentalService dentalService;
        private IRepository repo;
        private ApplicationDbContext dbContext;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dentalServices = new List<DentalService>()
            {
                new DentalService
                {
                    Id = Guid.Parse("36a158f9-a2bd-4bc6-8a94-416e7844578a"),
                    ServiceName = "Surgical operations",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
               new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Dental implants",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Complete changeover",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Aesthetic fillings",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Veneers",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Ceramic inlays",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Crowns and bridges",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                }
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: "DentalClinicTest")
                    .Options;
            this.dbContext = new ApplicationDbContext(options);
            this.dbContext.AddRange(dentalServices);
            this.dbContext.SaveChanges();
        }

        [Test]
        public async Task Test_AllDentalServices()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                dentalService = new DentalSrvService(repo);

                var resultService = await dentalService.GetAll();
                var orderListResultService = resultService.OrderBy(ds => ds.ServiceName).ToList();
                var resultDb = await dbContext.DentalServices.OrderBy(ds => ds.ServiceName).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());

                if (resultService.Count() == resultDb.Count())
                {
                    for (int i = 0; i < orderListResultService.Count(); i++)
                    {
                        Assert.That(resultDb[i].ServiceName, Is.EqualTo(orderListResultService[i].ServiceName));
                        Assert.That(resultDb[i].ServiceDescription, Is.EqualTo(orderListResultService[i].ServiceDescription));
                    }
                }
            }
        }

        [Test]
        public async Task Test_GetServiceById()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                dentalService = new DentalSrvService(repo);

                Guid dentalServiceId = Guid.Parse("36a158f9-a2bd-4bc6-8a94-416e7844578a");

                var resultService = await dentalService.GetServiceById(dentalServiceId);
                var orderListResultService = resultService.OrderBy(ds => ds.ServiceName).ToList();
                var resultDb = await dbContext.DentalServices.Where(ds => ds.Id == dentalServiceId).OrderBy(ds => ds.ServiceName).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());

                if (resultService.Count() == resultDb.Count())
                {
                    for (int i = 0; i < orderListResultService.Count(); i++)
                    {
                        Assert.That(resultDb[i].ServiceName, Is.EqualTo(orderListResultService[i].ServiceName));
                        Assert.That(resultDb[i].ServiceDescription, Is.EqualTo(orderListResultService[i].ServiceDescription));
                    }
                }
            }
        }

        [Test]
        public async Task Test_GetServiceById_InvalidId()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                dentalService = new DentalSrvService(repo);
                Guid dentalServiceId = Guid.Parse("613807f1-31c8-4523-aa93-a97243da1f1e");

                var resultService = await dentalService.GetServiceById(dentalServiceId);
                var orderListResultService = resultService.OrderBy(ds => ds.ServiceName).ToList();
                var resultDb = await dbContext.DentalServices.Where(ds => ds.Id == dentalServiceId).OrderBy(ds => ds.ServiceName).ToListAsync();

                Assert.True(resultService.Count() == resultDb.Count());
            }
        }

        [Test]
        public async Task Test_CreateDentalService()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "DentalClinicTest").Options;

            using (var dbContext = new ApplicationDbContext(options))
            {
                repo = new Repository(dbContext);
                dentalService = new DentalSrvService(repo);

                var dentalServiceViewModel = new DentalServiceViewModel
                {
                    ServiceName = "Test_ServiceName",
                    ServiceDescription = "Test_ServiceDescription",
                    Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                };

                await dentalService.Create(dentalServiceViewModel);
                var resultDb = await dbContext.DentalServices.Where(ds => ds.ServiceName == "Test_ServiceName").FirstOrDefaultAsync();
                if (resultDb != null)
                {
                    Assert.That(dentalServiceViewModel.ServiceName, Is.EqualTo(resultDb.ServiceName));
                    Assert.That(dentalServiceViewModel.ServiceDescription, Is.EqualTo(resultDb.ServiceDescription));
                    Assert.That(dentalServiceViewModel.Who, Is.EqualTo(resultDb.Who));
                }
                else
                {
                    Assert.That("OK", Is.EqualTo("Error"));
                }
            }
        }
    }
}
