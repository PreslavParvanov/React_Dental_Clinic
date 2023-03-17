using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class remane_lastActive_lastLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("01829e40-baf9-4076-8f6b-551ad05bd2cc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("0df2016d-95ed-429f-b1b6-82e2de234720"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("2003775c-ceb7-440c-9684-a6b1c0d19171"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("3945d422-f6ab-4682-b83d-7b52bcbc7453"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("43933ae6-d428-4df0-8bbb-d6c209859e8e"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7f209e76-92c8-4c8c-a691-c903d2522add"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("91e63d6e-be53-4289-83eb-9fdb31f7d635"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ade089eb-fd0f-4c8e-a654-d756b6d2e5bc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ae8c2678-7556-4717-b684-8297fbd23cb8"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b5fd22f9-a2f6-4523-83a6-becab5a09a18"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c2c4cfb8-64ad-4e26-83ed-e73c074e9419"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f60c2eb0-47f4-4024-8a59-09156a9edb0a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("29334222-53ff-41ca-b3a0-44a52c389a0a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9c704735-f2d5-486c-9d79-944945d43caa"));

            migrationBuilder.RenameColumn(
                name: "LastActive",
                table: "AspNetUsers",
                newName: "LastLogin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "SecurityStamp", "When" },
                values: new object[] { "37be44b3-9c99-4d77-a6f9-a16b5aeca8b9", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4357), "757ad97c-1d11-4baa-ac21-41af2c28badf", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("0788cbe6-7537-49c7-b9c5-cb2129175471"), "", "Crowns and bridges", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4646), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("4c93f96b-01d9-4221-bc7b-d4d4ce4c54be"), "", "Veneers", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4639), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6f43bee9-4fc2-489e-888d-e339dccfb065"), "", "Prosthesis", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4655), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("75866539-7814-44be-bdc6-76856c57f48d"), "", "Ceramic inlays", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4643), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("8e6c8372-1b02-4721-b609-391f9f7c02f7"), "", "Glass supports", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4664), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("996a1870-eceb-4079-a716-9f24148b651d"), "", "Dental implants", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4631), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("aa7cd35d-6198-4cd2-a941-e1b3cb12d927"), "", "Teeth whitening", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4661), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ce6449ef-54bd-4e89-932c-b656c6225fd6"), "", "Surgical operations", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4625), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("e0e3b07d-c523-470c-84da-9a4e22031d5b"), "", "Complete changeover", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4634), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("e2830bde-ae3c-4dde-8a02-346a9c49de81"), "", "Aesthetic fillings", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4636), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f17bce86-b1f9-45c6-93ec-a7d62efe6245"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4659), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f5b39fbb-277c-422c-ad7c-980db9330358"), "", "Tooth extraction", new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4652), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("730f9bc2-0e66-4831-baa4-a7719450cd37"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4537), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c9ced3c2-aa10-4dff-bcb3-6686fbdc2b57"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4520), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("0788cbe6-7537-49c7-b9c5-cb2129175471"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("4c93f96b-01d9-4221-bc7b-d4d4ce4c54be"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6f43bee9-4fc2-489e-888d-e339dccfb065"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("75866539-7814-44be-bdc6-76856c57f48d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("8e6c8372-1b02-4721-b609-391f9f7c02f7"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("996a1870-eceb-4079-a716-9f24148b651d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("aa7cd35d-6198-4cd2-a941-e1b3cb12d927"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ce6449ef-54bd-4e89-932c-b656c6225fd6"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("e0e3b07d-c523-470c-84da-9a4e22031d5b"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("e2830bde-ae3c-4dde-8a02-346a9c49de81"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f17bce86-b1f9-45c6-93ec-a7d62efe6245"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f5b39fbb-277c-422c-ad7c-980db9330358"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("730f9bc2-0e66-4831-baa4-a7719450cd37"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c9ced3c2-aa10-4dff-bcb3-6686fbdc2b57"));

            migrationBuilder.RenameColumn(
                name: "LastLogin",
                table: "AspNetUsers",
                newName: "LastActive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastActive", "SecurityStamp", "When" },
                values: new object[] { "bfad34bb-9f0d-44fb-9af2-c1b98fb62489", new DateTime(2022, 11, 21, 22, 19, 15, 855, DateTimeKind.Local).AddTicks(9885), "2d558aac-0a61-448e-a786-bf660fb4324f", new DateTime(2022, 11, 21, 22, 19, 15, 855, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("01829e40-baf9-4076-8f6b-551ad05bd2cc"), "", "Crowns and bridges", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(238), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("0df2016d-95ed-429f-b1b6-82e2de234720"), "", "Dental implants", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(218), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("2003775c-ceb7-440c-9684-a6b1c0d19171"), "", "Teeth whitening", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(260), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3945d422-f6ab-4682-b83d-7b52bcbc7453"), "", "Tooth extraction", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(244), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("43933ae6-d428-4df0-8bbb-d6c209859e8e"), "", "Prosthesis", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(248), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7f209e76-92c8-4c8c-a691-c903d2522add"), "", "Glass supports", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(262), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("91e63d6e-be53-4289-83eb-9fdb31f7d635"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(257), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ade089eb-fd0f-4c8e-a654-d756b6d2e5bc"), "", "Ceramic inlays", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(236), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ae8c2678-7556-4717-b684-8297fbd23cb8"), "", "Surgical operations", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(214), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b5fd22f9-a2f6-4523-83a6-becab5a09a18"), "", "Aesthetic fillings", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(228), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c2c4cfb8-64ad-4e26-83ed-e73c074e9419"), "", "Veneers", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(231), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f60c2eb0-47f4-4024-8a59-09156a9edb0a"), "", "Complete changeover", new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(225), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("29334222-53ff-41ca-b3a0-44a52c389a0a"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(101), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9c704735-f2d5-486c-9d79-944945d43caa"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 21, 22, 19, 15, 856, DateTimeKind.Local).AddTicks(123), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }
    }
}
