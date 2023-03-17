using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class new_col_in_tbl_DoctorCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorsCustomers_AspNetUsers_UsersId",
                table: "DoctorsCustomers");

            migrationBuilder.DropIndex(
                name: "IX_DoctorsCustomers_UsersId",
                table: "DoctorsCustomers");

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

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "DoctorsCustomers");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "DoctorsCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "DoctorsCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerPhone",
                table: "DoctorsCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "SecurityStamp", "When" },
                values: new object[] { "ab2aaac2-01b8-4149-8f41-f675dc8e292b", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6638), "9542c77b-213e-4820-8559-330172676a9a", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("0593462c-d2ec-410a-b63f-d60f72f48e90"), "", "Glass supports", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6890), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("25f2426e-d201-4d44-b89e-aeaa4fd771d8"), "", "Surgical operations", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6850), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("36e6f8c0-84f2-4dae-9e02-041c429083aa"), "", "Veneers", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6866), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("37091c11-91e9-4be5-8faa-f28d22077a25"), "", "Ceramic inlays", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6874), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3fe4818d-802a-4e26-b8bf-89904e9c5f6e"), "", "Complete changeover", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6861), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("45b0f5a2-09f2-40b4-9b02-d11b6db70cf3"), "", "Tooth extraction", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6879), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("553c375f-39b8-44ac-89ab-c6b0b7479547"), "", "Dental implants", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6858), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("8e01e031-c061-4d62-b1c4-4f3ccc47a28f"), "", "Prosthesis", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6882), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ac2badce-9a24-4dc6-b110-304637837bb4"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6885), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c70d18bc-7b3e-41e1-97b8-867fe9dc638b"), "", "Aesthetic fillings", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6864), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d9cbb35e-dbdf-46dd-a687-9824719e0be9"), "", "Crowns and bridges", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6877), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("df1d94c0-f23e-4fd8-9c04-252edbef852d"), "", "Teeth whitening", new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6888), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("84d1e453-ebc6-412c-b787-f5dfe1512664"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6765), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d95fa75c-4ad7-43da-8a59-f16a08fea162"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 22, 13, 8, 6, 399, DateTimeKind.Local).AddTicks(6773), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("0593462c-d2ec-410a-b63f-d60f72f48e90"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("25f2426e-d201-4d44-b89e-aeaa4fd771d8"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("36e6f8c0-84f2-4dae-9e02-041c429083aa"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("37091c11-91e9-4be5-8faa-f28d22077a25"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("3fe4818d-802a-4e26-b8bf-89904e9c5f6e"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("45b0f5a2-09f2-40b4-9b02-d11b6db70cf3"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("553c375f-39b8-44ac-89ab-c6b0b7479547"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("8e01e031-c061-4d62-b1c4-4f3ccc47a28f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ac2badce-9a24-4dc6-b110-304637837bb4"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c70d18bc-7b3e-41e1-97b8-867fe9dc638b"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d9cbb35e-dbdf-46dd-a687-9824719e0be9"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("df1d94c0-f23e-4fd8-9c04-252edbef852d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("84d1e453-ebc6-412c-b787-f5dfe1512664"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d95fa75c-4ad7-43da-8a59-f16a08fea162"));

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "DoctorsCustomers");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "DoctorsCustomers");

            migrationBuilder.DropColumn(
                name: "CustomerPhone",
                table: "DoctorsCustomers");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "DoctorsCustomers",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsCustomers_UsersId",
                table: "DoctorsCustomers",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorsCustomers_AspNetUsers_UsersId",
                table: "DoctorsCustomers",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
