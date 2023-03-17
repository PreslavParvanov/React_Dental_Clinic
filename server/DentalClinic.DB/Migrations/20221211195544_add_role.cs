using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("09d0d35c-2d80-4807-8e60-5f4fa6f75c20"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("320d3daf-7935-48a9-853f-f21c01560b73"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("50c072c1-e9b4-4b8c-9600-b78db1536e35"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("592727d2-0554-487a-b37a-0837da2f1574"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("74f18161-523a-4f65-87d6-b830ae24194d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("84e7c62c-dd28-4ac9-9182-616c6acd7254"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("9bbec40a-d078-4bad-ae0d-e076d43a953d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("a3297b30-a5b0-4dac-b281-00dfc6504a1c"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b48402f9-402d-4c10-b893-bf469e872215"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d24ebd2b-05bd-48c9-b95f-e9f413ee0958"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("e6d502b8-484e-4ca2-930d-066795ee106f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f8e5974b-6b57-461a-b8fd-7b2dfa8de792"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e007453e-9c4b-4082-90ed-da915736f1f4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("fbccb4de-8fcb-4daf-9b73-8c739d52e5f0"));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "3a3caf80-c223-498d-901b-c8fc4504bb3f", "72cb2f57-6699-43d9-82c6-fe1c682dec3e", "Role", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "SecurityStamp", "When" },
                values: new object[] { "b6a74258-6d17-4474-abb8-407e7807f5c7", new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(4846), "ab3ac95d-d599-4e3a-8ab4-0b466ab7ce76", new DateTime(2022, 12, 11, 21, 55, 44, 323, DateTimeKind.Local).AddTicks(4802) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3caf80-c223-498d-901b-c8fc4504bb3f");

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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "SecurityStamp", "When" },
                values: new object[] { "3aa4157e-7d7f-4d00-85d7-53f73e2c89cb", new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(4903), "f8d1425c-ee00-4dfb-a72f-6c018446b4bb", new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("09d0d35c-2d80-4807-8e60-5f4fa6f75c20"), "", "Crowns and bridges", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5182), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("320d3daf-7935-48a9-853f-f21c01560b73"), "", "Complete changeover", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5170), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("50c072c1-e9b4-4b8c-9600-b78db1536e35"), "", "Teeth whitening", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5196), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("592727d2-0554-487a-b37a-0837da2f1574"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5191), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("74f18161-523a-4f65-87d6-b830ae24194d"), "", "Aesthetic fillings", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5172), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("84e7c62c-dd28-4ac9-9182-616c6acd7254"), "", "Prosthesis", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5187), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9bbec40a-d078-4bad-ae0d-e076d43a953d"), "", "Glass supports", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5199), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a3297b30-a5b0-4dac-b281-00dfc6504a1c"), "", "Veneers", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5175), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b48402f9-402d-4c10-b893-bf469e872215"), "", "Surgical operations", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5153), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d24ebd2b-05bd-48c9-b95f-e9f413ee0958"), "", "Dental implants", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5158), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("e6d502b8-484e-4ca2-930d-066795ee106f"), "", "Tooth extraction", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5185), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f8e5974b-6b57-461a-b8fd-7b2dfa8de792"), "", "Ceramic inlays", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5179), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("e007453e-9c4b-4082-90ed-da915736f1f4"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5064), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("fbccb4de-8fcb-4daf-9b73-8c739d52e5f0"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 12, 6, 22, 26, 26, 531, DateTimeKind.Local).AddTicks(5071), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }
    }
}
