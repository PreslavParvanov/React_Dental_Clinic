using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_admin_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("2207ea99-c652-489f-983c-b82efe932656"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("2eddbb73-df17-4c50-986b-b4de45f78b96"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("3203e4de-5a4d-4004-a944-51d41dd6ca08"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("629b5a7e-1622-462b-a98a-3084a0e94cc9"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("717e2e46-322d-4878-875a-a2118721f557"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7713c5b8-7e8b-488f-ac4d-caa941397166"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("877fe45d-1dfd-4ab5-9b92-39287a62a009"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("94fde0d3-c15a-409a-9aff-78f0b9882844"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("9b40d9a0-8966-49ea-83ae-b9df809e085f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b01e56b1-de57-4782-8fe4-e75aa7fd9cc8"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("fba6cec7-be5c-4286-b972-00f84884e171"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("fdc99e42-133a-4267-acc7-5bc05f1881e8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7ec1e619-3cb3-46c9-b239-01b03f8e19a3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a1bdf282-1def-48f0-9063-454ad4055ef3"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3caf80-c223-498d-901b-c8fc4504bb3f",
                column: "ConcurrencyStamp",
                value: "d10408ef-02e8-4e63-af78-ea463a03f885");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp", "When" },
                values: new object[] { "4d598e95-5534-4a51-bc08-556dffd6308a", new DateTime(2022, 12, 11, 22, 1, 21, 241, DateTimeKind.Local).AddTicks(9937), "AQAAAAEAACcQAAAAELH/+dj6ShwvY5FZMpNEjG1AoNShIjLzPjMdyg4RIR9wxht5ZMqUfsQpyHsNx3dkhA==", "eeaacde9-5d06-487c-a6ed-bcbf7cf08656", new DateTime(2022, 12, 11, 22, 1, 21, 241, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("14369a20-2b26-44a6-a64c-5463aa3cfe11"), "", "Aesthetic fillings", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9782), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3229b701-e47b-4fae-ab5a-a04fed753d3f"), "", "Dental implants", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9776), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6bcaa4e4-c6e7-4563-a5bf-f99fe981ad52"), "", "Veneers", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9785), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("75f64060-02c3-496a-ad94-63018a2a2d19"), "", "Teeth whitening", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9808), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("86980970-36d0-4b65-b055-279470b6fefc"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9805), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9d56f702-ab60-407c-a0b2-b4f3164ab5c4"), "", "Tooth extraction", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9797), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b72af5da-2304-468e-80b0-f07bb8f73ec9"), "", "Crowns and bridges", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9794), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b7e6c0c9-984a-410e-a07a-e3c7b94acbd7"), "", "Prosthesis", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9799), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ca485009-bbaa-42b0-867a-32d780f0a9c0"), "", "Ceramic inlays", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9791), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ce0079b2-e90e-4ea4-bf00-c56c6b6f7a6f"), "", "Glass supports", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9810), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d0d25162-aefc-4435-9ca5-1576711c5464"), "", "Surgical operations", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9763), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d0e6f71a-7a78-4675-bc9b-52370b0e0d5d"), "", "Complete changeover", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9779), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("178720dc-9867-4775-a0d5-c38afe066cfd"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9591), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("30ffc9fc-6018-4d99-9acb-09f135c3d5c6"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 12, 11, 22, 1, 21, 248, DateTimeKind.Local).AddTicks(9567), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("14369a20-2b26-44a6-a64c-5463aa3cfe11"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("3229b701-e47b-4fae-ab5a-a04fed753d3f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6bcaa4e4-c6e7-4563-a5bf-f99fe981ad52"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("75f64060-02c3-496a-ad94-63018a2a2d19"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("86980970-36d0-4b65-b055-279470b6fefc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("9d56f702-ab60-407c-a0b2-b4f3164ab5c4"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b72af5da-2304-468e-80b0-f07bb8f73ec9"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b7e6c0c9-984a-410e-a07a-e3c7b94acbd7"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ca485009-bbaa-42b0-867a-32d780f0a9c0"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ce0079b2-e90e-4ea4-bf00-c56c6b6f7a6f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d0d25162-aefc-4435-9ca5-1576711c5464"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d0e6f71a-7a78-4675-bc9b-52370b0e0d5d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("178720dc-9867-4775-a0d5-c38afe066cfd"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("30ffc9fc-6018-4d99-9acb-09f135c3d5c6"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3caf80-c223-498d-901b-c8fc4504bb3f",
                column: "ConcurrencyStamp",
                value: "72cb2f57-6699-43d9-82c6-fe1c682dec3e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp", "When" },
                values: new object[] { "b6a74258-6d17-4474-abb8-407e7807f5c7", new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(4846), "Admin@123", "ab3ac95d-d599-4e3a-8ab4-0b466ab7ce76", new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("2207ea99-c652-489f-983c-b82efe932656"), "", "Crowns and bridges", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5114), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("2eddbb73-df17-4c50-986b-b4de45f78b96"), "", "Prosthesis", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5123), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3203e4de-5a4d-4004-a944-51d41dd6ca08"), "", "Dental implants", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5098), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("629b5a7e-1622-462b-a98a-3084a0e94cc9"), "", "Aesthetic fillings", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5104), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("717e2e46-322d-4878-875a-a2118721f557"), "", "Tooth extraction", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5120), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7713c5b8-7e8b-488f-ac4d-caa941397166"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5126), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("877fe45d-1dfd-4ab5-9b92-39287a62a009"), "", "Glass supports", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5132), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("94fde0d3-c15a-409a-9aff-78f0b9882844"), "", "Complete changeover", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5101), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9b40d9a0-8966-49ea-83ae-b9df809e085f"), "", "Veneers", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5107), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b01e56b1-de57-4782-8fe4-e75aa7fd9cc8"), "", "Teeth whitening", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5130), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("fba6cec7-be5c-4286-b972-00f84884e171"), "", "Ceramic inlays", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5111), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("fdc99e42-133a-4267-acc7-5bc05f1881e8"), "", "Surgical operations", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5092), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("7ec1e619-3cb3-46c9-b239-01b03f8e19a3"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(5018), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a1bdf282-1def-48f0-9063-454ad4055ef3"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(4995), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }
    }
}
