using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: true),
                    When = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DentalServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Who = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DentalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DentalServices_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoreInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_Who",
                        column: x => x.Who,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorsCustomers",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsCustomers", x => new { x.DoctorId, x.CustomerId, x.DateTime });
                    table.ForeignKey(
                        name: "FK_DoctorCustomers_Doctors",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorsCustomers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorsCustomers_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DoctorsSchedules",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBusy = table.Column<bool>(type: "bit", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsSchedules", x => new { x.DoctorId, x.ScheduleDateTime });
                    table.ForeignKey(
                        name: "FK_DoctorSchedules_Doctors",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorsSchedules_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorsSchedules_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "When" },
                values: new object[] { "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa", 0, "bfad34bb-9f0d-44fb-9af2-c1b98fb62489", "User", "admin@gmail.com", true, "admin", (byte)1, new DateTime(2022, 11, 21, 22, 19, 15, 855, DateTimeKind.Local).AddTicks(9885), "admin", false, null, null, null, "Admin@123", null, false, "2d558aac-0a61-448e-a786-bf660fb4324f", false, "admin@gmail.com", new DateTime(2022, 11, 21, 22, 19, 15, 855, DateTimeKind.Local).AddTicks(9846) });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DentalServices_Who",
                table: "DentalServices",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Who",
                table: "Doctors",
                column: "Who");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsCustomers_UserId",
                table: "DoctorsCustomers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsCustomers_UsersId",
                table: "DoctorsCustomers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsSchedules_UserId",
                table: "DoctorsSchedules",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsSchedules_UsersId",
                table: "DoctorsSchedules",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DentalServices");

            migrationBuilder.DropTable(
                name: "DoctorsCustomers");

            migrationBuilder.DropTable(
                name: "DoctorsSchedules");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
