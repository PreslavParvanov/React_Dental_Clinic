using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_col_ImageUrl_in_Doctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "Email", "LastLogin", "PasswordHash", "SecurityStamp", "UserName", "When" },
                values: new object[] { "8200ed11-cf79-4a4a-bae1-e25e406001ca", "admin@admin.com", new DateTime(2022, 12, 13, 23, 53, 8, 227, DateTimeKind.Local).AddTicks(5006), "AQAAAAEAACcQAAAAEMutPPC5lORCMXGNlqFVnx8yVKX3KwWR8uuzK4RWwj3ERgcl3Q8WDztldQ15g/kzPA==", "f52489f8-6499-4553-99b1-05fb4d761d95", "admin@admin.com", new DateTime(2022, 12, 13, 23, 53, 8, 227, DateTimeKind.Local).AddTicks(4969) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Doctors");

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
                columns: new[] { "ConcurrencyStamp", "Email", "LastLogin", "PasswordHash", "SecurityStamp", "UserName", "When" },
                values: new object[] { "4d598e95-5534-4a51-bc08-556dffd6308a", "admin@gmail.com", new DateTime(2022, 12, 11, 22, 1, 21, 241, DateTimeKind.Local).AddTicks(9937), "AQAAAAEAACcQAAAAELH/+dj6ShwvY5FZMpNEjG1AoNShIjLzPjMdyg4RIR9wxht5ZMqUfsQpyHsNx3dkhA==", "eeaacde9-5d06-487c-a6ed-bcbf7cf08656", "admin@gmail.com", new DateTime(2022, 12, 11, 22, 1, 21, 241, DateTimeKind.Local).AddTicks(9904) });

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
    }
}
