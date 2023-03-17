using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "SecurityStamp", "When" },
                values: new object[] { "847ef9a6-beb4-4c27-b5f4-6959e61d6187", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(4797), "6454c17b-956e-4e7b-a19d-70a77662de53", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("0481ad64-99f6-435b-acc6-7f9d8b48dd84"), "", "Veneers", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5036), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("23c76b07-9fa8-4d27-8b1c-eb21952453a9"), "", "Teeth whitening", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5062), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("35022dd0-ce81-45bb-86b1-8a308a1ba544"), "", "Prosthesis", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5054), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("419934f2-dd9f-4ab4-b2d4-0c39cdda998a"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5059), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("5a8dd303-3d5b-4f57-9d4d-6c52555d0436"), "", "Tooth extraction", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5052), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("5ad4e5f0-9516-4a06-8d70-f7956b9255dc"), "", "Ceramic inlays", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5046), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6e34d844-048f-4fb8-a0b7-3fe3f6cd3912"), "", "Surgical operations", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5018), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("79a486c0-b19e-4ae3-95e2-10b5419f0aaf"), "", "Complete changeover", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5030), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7cacba8d-37d6-454d-a6e8-4186837cd10a"), "", "Aesthetic fillings", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5033), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9188b684-9f81-413a-9386-942d8bc876cf"), "", "Dental implants", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5027), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a4fbfc93-3630-4edb-b609-af72806620ef"), "", "Crowns and bridges", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5049), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c5dbe2b4-7afe-495d-91d7-563dcbd99955"), "", "Glass supports", new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(5064), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("1c9451c0-2b09-4d1b-b8d2-5cbb13f1cb84"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(4934), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a8a7c680-4ad4-4e53-a76e-2f514c1c5337"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 28, 23, 9, 11, 97, DateTimeKind.Local).AddTicks(4926), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("0481ad64-99f6-435b-acc6-7f9d8b48dd84"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("23c76b07-9fa8-4d27-8b1c-eb21952453a9"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("35022dd0-ce81-45bb-86b1-8a308a1ba544"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("419934f2-dd9f-4ab4-b2d4-0c39cdda998a"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("5a8dd303-3d5b-4f57-9d4d-6c52555d0436"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("5ad4e5f0-9516-4a06-8d70-f7956b9255dc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6e34d844-048f-4fb8-a0b7-3fe3f6cd3912"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("79a486c0-b19e-4ae3-95e2-10b5419f0aaf"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7cacba8d-37d6-454d-a6e8-4186837cd10a"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("9188b684-9f81-413a-9386-942d8bc876cf"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("a4fbfc93-3630-4edb-b609-af72806620ef"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c5dbe2b4-7afe-495d-91d7-563dcbd99955"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1c9451c0-2b09-4d1b-b8d2-5cbb13f1cb84"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a8a7c680-4ad4-4e53-a76e-2f514c1c5337"));

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
    }
}
