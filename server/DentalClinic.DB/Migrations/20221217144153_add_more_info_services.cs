using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_more_info_services : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("2618069b-341b-41ed-a24c-1861aa4e9c3f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6a3222ef-a7e2-40db-92bd-87617099a729"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("73abc585-8b58-4c8b-98f2-123b78dae912"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b0ba85e3-d767-4f41-a6de-ad968009fc5d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("babbccdd-4aeb-493f-91d0-ea4f846a6e2d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c028efe2-513c-4813-8713-f6ca1e28ecc1"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c17974df-7dc1-4560-b233-bf6af84a5391"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d12e8420-c7e4-48eb-a192-7a5de28dda95"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("dcff4e7c-0c73-4ad1-9aa7-eac0856762ac"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f90d0383-0f03-4631-9115-5dcc36232982"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f9e7a0a8-565c-47a0-a86c-0f47df4ee497"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("fd36732f-ce30-40be-9d83-5766d97be826"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c57db77a-5b7a-4520-a619-d8c374f12b8b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cc5911a1-bbbb-4e0c-815d-bcfc81f636bd"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3caf80-c223-498d-901b-c8fc4504bb3f",
                column: "ConcurrencyStamp",
                value: "af913d30-7edc-4471-ac3e-f8b4f4a5f899");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp", "When" },
                values: new object[] { "ec804bf0-2775-4430-a7f4-12ae39bb74c8", new DateTime(2022, 12, 17, 16, 41, 52, 620, DateTimeKind.Local).AddTicks(6867), "AQAAAAEAACcQAAAAEImL6D8r1EryPIMlTB3bxsVbGBDzq013hTAMrMDDKWg6gzEVFHAXdkMV7Ftyi0iNDw==", "8f74a3da-b91c-4aad-ba92-7087af00f5ff", new DateTime(2022, 12, 17, 16, 41, 52, 620, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("1c50c24b-d334-4989-88b5-c276da15cfd0"), "", "Prosthesis", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6435), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("36711a6b-5547-4988-b779-e72e8dcd1b04"), "The bite splint is inserted when you go to bed at night and removed in the morning. The contact of your lower front teeth against the orthodontic splint stops the grinding process in most patients. The few patients that continue to grind will not experience wear or breakage of teeth.", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6438), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("412861d2-2133-494e-be26-f454c76315cc"), "The construction of dental bridges uses the same physical principles as the ones used in bridge construction. Two supports at both ends of the structure are needed to absorb the load in the middle.", "Glass supports", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6443), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("571d47b9-ea8c-470a-a1b2-e70e8151b242"), "Dental implant systems consist of a dental implant body and dental implant abutment and may also include an abutment fixation screw. The dental implant body is surgically inserted in the jawbone in place of the tooth's root. The dental implant abutment is usually attached to the implant body by the abutment fixation screw and extends through gums into the mouth to support the attached artificial teeth.", "Dental implants", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6411), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("574b19c2-a4e2-412f-ad53-3fd2153340b8"), "Inlays and onlays are often referred to as partial crowns. They use the existing tooth as a foundation and fit into or onto the tooth. This is done to strengthen the tooth, restore its shape, and prevent further damage. An inlay is done when there is no damage to the cusps of the tooth and the inlay can be placed right on the tooth. An onlay is used when the damage is a little more extensive. ", "Ceramic inlays", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6424), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("63f1314d-de84-40d0-b38b-361b0063afdc"), "In spite of a knowledge explosion in cariology science, dental caries still remains a misunderstood phenomenon by the clinicians. In order to effectively use the wide range of preventive and management strategies, it is imperative to look beyond those black and white spots that manifest on the tooth surfaces. This paper focuses on the revised versions of the etiopathogenesis and definition of dental caries disease in the present century.", "Complete changeover", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6414), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("73528e1b-fd92-4ac1-8ae2-df46b9924691"), "Aesthetic fillings are the most frequently used method for the treatment of decayed teeth. The filling material is available in different colours. Your attending physician will select the most suitable colour with the help of a tooth colour code. ", "Aesthetic fillings", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6417), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7d227ad0-37e3-4471-b93d-09290881a441"), "Dental veneers are thin, tooth-colored shells that are attached to the front surface of teeth to improve their appearance. They’re often made from porcelain or resin-composite materials and are permanently bonded to your teeth.", "Veneers", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6419), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9721e958-7649-4c61-897f-1ef47974eac1"), "If permanent dental implants are not in your future (they are often more expensive, and some insurance companies will cover them while some will not – or many people do not have insurance), then a viable (cheaper) alternative would be a dental bridge. Dental Bridges use your healthy teeth as anchors for porcelain that will support your prosthetic teeth. By using good teeth as an anchor, they ensure that your bridge has a longer lifespan and can sometimes replace more than one missing tooth at a time.", "Crowns and bridges", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6427), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("bfe98d65-91a4-416a-8c88-afab83e9a198"), "A tooth extraction is a dental procedure during which your tooth is completely removed from its socket. Sometimes, people refer to this as “pulling\" a tooth.", "Tooth extraction", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6429), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d3ea4fa8-c2cb-49a5-b0bf-1170fbd1e9f8"), "Professional teeth whitening is often an efficient, safe and effective choice for brightening your smile. But there’s plenty to consider, including cost, your lifestyle habits and whether a comprehensive in-office treatment or a custom take-home-tray is the better choice.", "Teeth whitening", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6441), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d6fdef9a-e73d-4682-ad08-13e856b710cd"), "Oral surgery is a broad term for any operation performed on your teeth, gums, jaw or surrounding oral and facial structures. It includes a wide range of procedures, including teeth extractions, dental bone grafts, periodontal (gum) grafts and corrective jaw surgery.", "Surgical operations", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6405), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ImageUrl", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("7d82b15d-781d-48ef-9694-2858b5f8dd38"), "https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg", (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6311), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("8867f1f2-ebda-4703-b187-bd268568690e"), "https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg", (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 12, 17, 16, 41, 52, 627, DateTimeKind.Local).AddTicks(6295), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("1c50c24b-d334-4989-88b5-c276da15cfd0"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("36711a6b-5547-4988-b779-e72e8dcd1b04"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("412861d2-2133-494e-be26-f454c76315cc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("571d47b9-ea8c-470a-a1b2-e70e8151b242"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("574b19c2-a4e2-412f-ad53-3fd2153340b8"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("63f1314d-de84-40d0-b38b-361b0063afdc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("73528e1b-fd92-4ac1-8ae2-df46b9924691"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7d227ad0-37e3-4471-b93d-09290881a441"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("9721e958-7649-4c61-897f-1ef47974eac1"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("bfe98d65-91a4-416a-8c88-afab83e9a198"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d3ea4fa8-c2cb-49a5-b0bf-1170fbd1e9f8"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d6fdef9a-e73d-4682-ad08-13e856b710cd"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7d82b15d-781d-48ef-9694-2858b5f8dd38"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8867f1f2-ebda-4703-b187-bd268568690e"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3caf80-c223-498d-901b-c8fc4504bb3f",
                column: "ConcurrencyStamp",
                value: "01ee2f13-1b6e-4da3-9b53-0b93202c73cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp", "When" },
                values: new object[] { "8200ed11-cf79-4a4a-bae1-e25e406001ca", new DateTime(2022, 12, 13, 23, 53, 8, 227, DateTimeKind.Local).AddTicks(5006), "AQAAAAEAACcQAAAAEMutPPC5lORCMXGNlqFVnx8yVKX3KwWR8uuzK4RWwj3ERgcl3Q8WDztldQ15g/kzPA==", "f52489f8-6499-4553-99b1-05fb4d761d95", new DateTime(2022, 12, 13, 23, 53, 8, 227, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("2618069b-341b-41ed-a24c-1861aa4e9c3f"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6320), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6a3222ef-a7e2-40db-92bd-87617099a729"), "", "Crowns and bridges", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6307), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("73abc585-8b58-4c8b-98f2-123b78dae912"), "", "Glass supports", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6326), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b0ba85e3-d767-4f41-a6de-ad968009fc5d"), "", "Tooth extraction", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6309), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("babbccdd-4aeb-493f-91d0-ea4f846a6e2d"), "", "Veneers", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6297), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c028efe2-513c-4813-8713-f6ca1e28ecc1"), "", "Surgical operations", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6283), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c17974df-7dc1-4560-b233-bf6af84a5391"), "", "Dental implants", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6289), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d12e8420-c7e4-48eb-a192-7a5de28dda95"), "", "Ceramic inlays", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6304), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("dcff4e7c-0c73-4ad1-9aa7-eac0856762ac"), "", "Complete changeover", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6292), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f90d0383-0f03-4631-9115-5dcc36232982"), "", "Aesthetic fillings", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6295), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f9e7a0a8-565c-47a0-a86c-0f47df4ee497"), "", "Teeth whitening", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6323), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("fd36732f-ce30-40be-9d83-5766d97be826"), "", "Prosthesis", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6316), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ImageUrl", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("c57db77a-5b7a-4520-a619-d8c374f12b8b"), "https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg", (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6056), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("cc5911a1-bbbb-4e0c-815d-bcfc81f636bd"), "https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg", (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 12, 13, 23, 53, 8, 235, DateTimeKind.Local).AddTicks(6092), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }
    }
}
