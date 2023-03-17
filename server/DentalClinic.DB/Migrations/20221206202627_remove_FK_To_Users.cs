using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class remove_FK_To_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalServices_AspNetUsers_Who",
                table: "DentalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_Who",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorsSchedules_AspNetUsers_UsersId",
                table: "DoctorsSchedules");

            migrationBuilder.DropIndex(
                name: "IX_DoctorsSchedules_UsersId",
                table: "DoctorsSchedules");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_Who",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_DentalServices_Who",
                table: "DentalServices");

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

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "DoctorsSchedules");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "DentalServices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "DentalServices",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_DentalServices_UserId",
                table: "DentalServices",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DentalServices_AspNetUsers_UserId",
                table: "DentalServices",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalServices_AspNetUsers_UserId",
                table: "DentalServices");

            migrationBuilder.DropIndex(
                name: "IX_DentalServices_UserId",
                table: "DentalServices");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DentalServices");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "DoctorsSchedules",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "DentalServices",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsSchedules_UsersId",
                table: "DoctorsSchedules",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Who",
                table: "Doctors",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_DentalServices_Who",
                table: "DentalServices",
                column: "Who");

            migrationBuilder.AddForeignKey(
                name: "FK_DentalServices_AspNetUsers_Who",
                table: "DentalServices",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_Who",
                table: "Doctors",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorsSchedules_AspNetUsers_UsersId",
                table: "DoctorsSchedules",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
