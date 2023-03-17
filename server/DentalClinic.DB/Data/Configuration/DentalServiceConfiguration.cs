using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class DentalServiceConfiguration : IEntityTypeConfiguration<DentalService>
    {

        public void Configure(EntityTypeBuilder<DentalService> builder)
        {
            builder.HasData(CreateServices());
        }

        private List<DentalService> CreateServices()
        {
            List<DentalService> services = new List<DentalService>()
             {
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Surgical operations",
                    ServiceDescription="Oral surgery is a broad term for any operation performed on your teeth, gums, jaw or surrounding oral and facial structures. It includes a wide range of procedures, including teeth extractions, dental bone grafts, periodontal (gum) grafts and corrective jaw surgery.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
               new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Dental implants",
                    ServiceDescription="Dental implant systems consist of a dental implant body and dental implant abutment and may also include an abutment fixation screw. The dental implant body is surgically inserted in the jawbone in place of the tooth's root. The dental implant abutment is usually attached to the implant body by the abutment fixation screw and extends through gums into the mouth to support the attached artificial teeth.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Complete changeover",
                    ServiceDescription="In spite of a knowledge explosion in cariology science, dental caries still remains a misunderstood phenomenon by the clinicians. In order to effectively use the wide range of preventive and management strategies, it is imperative to look beyond those black and white spots that manifest on the tooth surfaces. This paper focuses on the revised versions of the etiopathogenesis and definition of dental caries disease in the present century.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Aesthetic fillings",
                    ServiceDescription="Aesthetic fillings are the most frequently used method for the treatment of decayed teeth. The filling material is available in different colours. Your attending physician will select the most suitable colour with the help of a tooth colour code. ",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Veneers",
                    ServiceDescription="Dental veneers are thin, tooth-colored shells that are attached to the front surface of teeth to improve their appearance. They’re often made from porcelain or resin-composite materials and are permanently bonded to your teeth.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Ceramic inlays",
                    ServiceDescription="Inlays and onlays are often referred to as partial crowns. They use the existing tooth as a foundation and fit into or onto the tooth. This is done to strengthen the tooth, restore its shape, and prevent further damage. An inlay is done when there is no damage to the cusps of the tooth and the inlay can be placed right on the tooth. An onlay is used when the damage is a little more extensive. ",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Crowns and bridges",
                    ServiceDescription="If permanent dental implants are not in your future (they are often more expensive, and some insurance companies will cover them while some will not – or many people do not have insurance), then a viable (cheaper) alternative would be a dental bridge. Dental Bridges use your healthy teeth as anchors for porcelain that will support your prosthetic teeth. By using good teeth as an anchor, they ensure that your bridge has a longer lifespan and can sometimes replace more than one missing tooth at a time.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Tooth extraction",
                    ServiceDescription="A tooth extraction is a dental procedure during which your tooth is completely removed from its socket. Sometimes, people refer to this as “pulling\" a tooth.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Prosthesis",
                    ServiceDescription="",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Orthodontic treatment/braces and splints",
                    ServiceDescription="The bite splint is inserted when you go to bed at night and removed in the morning. The contact of your lower front teeth against the orthodontic splint stops the grinding process in most patients. The few patients that continue to grind will not experience wear or breakage of teeth.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Teeth whitening",
                    ServiceDescription="Professional teeth whitening is often an efficient, safe and effective choice for brightening your smile. But there’s plenty to consider, including cost, your lifestyle habits and whether a comprehensive in-office treatment or a custom take-home-tray is the better choice.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                },
                new DentalService
                {
                    Id = Guid.NewGuid(),
                    ServiceName = "Glass supports",
                    ServiceDescription="The construction of dental bridges uses the same physical principles as the ones used in bridge construction. Two supports at both ends of the structure are needed to absorb the load in the middle.",
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now
                }
            };

            return services;
        }
    }
}


