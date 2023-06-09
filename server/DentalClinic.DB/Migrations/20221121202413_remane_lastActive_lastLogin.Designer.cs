﻿// <auto-generated />
using System;
using DentalClinic.DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221121202413_remane_lastActive_lastLogin")]
    partial class remane_lastActive_lastLogin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DentalService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ServiceDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Who");

                    b.ToTable("DentalServices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce6449ef-54bd-4e89-932c-b656c6225fd6"),
                            ServiceDescription = "",
                            ServiceName = "Surgical operations",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4625),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("996a1870-eceb-4079-a716-9f24148b651d"),
                            ServiceDescription = "",
                            ServiceName = "Dental implants",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4631),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("e0e3b07d-c523-470c-84da-9a4e22031d5b"),
                            ServiceDescription = "",
                            ServiceName = "Complete changeover",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4634),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("e2830bde-ae3c-4dde-8a02-346a9c49de81"),
                            ServiceDescription = "",
                            ServiceName = "Aesthetic fillings",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4636),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("4c93f96b-01d9-4221-bc7b-d4d4ce4c54be"),
                            ServiceDescription = "",
                            ServiceName = "Veneers",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4639),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("75866539-7814-44be-bdc6-76856c57f48d"),
                            ServiceDescription = "",
                            ServiceName = "Ceramic inlays",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4643),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("0788cbe6-7537-49c7-b9c5-cb2129175471"),
                            ServiceDescription = "",
                            ServiceName = "Crowns and bridges",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4646),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("f5b39fbb-277c-422c-ad7c-980db9330358"),
                            ServiceDescription = "",
                            ServiceName = "Tooth extraction",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4652),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("6f43bee9-4fc2-489e-888d-e339dccfb065"),
                            ServiceDescription = "",
                            ServiceName = "Prosthesis",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4655),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("f17bce86-b1f9-45c6-93ec-a7d62efe6245"),
                            ServiceDescription = "",
                            ServiceName = "Orthodontic treatment/braces and splints",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4659),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("aa7cd35d-6198-4cd2-a941-e1b3cb12d927"),
                            ServiceDescription = "",
                            ServiceName = "Teeth whitening",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4661),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("8e6c8372-1b02-4721-b609-391f9f7c02f7"),
                            ServiceDescription = "",
                            ServiceName = "Glass supports",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4664),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        });
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<string>("MoreInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("Who");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9ced3c2-aa10-4dff-bcb3-6686fbdc2b57"),
                            IsActive = (byte)1,
                            MoreInfo = "Doctor Radeva has 5 years of experience as a dentist.",
                            Name = "Dr. Radeva",
                            Qualification = "Dentist",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4520),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("730f9bc2-0e66-4831-baa4-a7719450cd37"),
                            IsActive = (byte)1,
                            MoreInfo = "Doctor Valeva has 3 years of experience as a оrthodontist.",
                            Name = "Dr. Valeva",
                            Qualification = "Оrthodontist",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4537),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        });
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorCustomer", b =>
                {
                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId", "CustomerId", "DateTime");

                    b.HasIndex("UserId");

                    b.HasIndex("UsersId");

                    b.ToTable("DoctorsCustomers");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorSchedule", b =>
                {
                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ScheduleDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBusy")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId", "ScheduleDateTime");

                    b.HasIndex("UserId");

                    b.HasIndex("UsersId");

                    b.ToTable("DoctorsSchedules");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "37be44b3-9c99-4d77-a6f9-a16b5aeca8b9",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "Admin@123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "757ad97c-1d11-4baa-ac21-41af2c28badf",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com",
                            FirstName = "admin",
                            IsActive = (byte)1,
                            LastLogin = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4357),
                            LastName = "admin",
                            When = new DateTime(2022, 11, 21, 22, 24, 12, 509, DateTimeKind.Local).AddTicks(4325)
                        });
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DentalService", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.Doctor", b =>
                {
                    b.HasOne("DentalClinic.DB.Data.Models.User", null)
                        .WithMany("Doctors")
                        .HasForeignKey("UserId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorCustomer", b =>
                {
                    b.HasOne("DentalClinic.DB.Data.Models.Doctor", "Doctors")
                        .WithMany("DoctorCustomers")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DoctorCustomers_Doctors");

                    b.HasOne("DentalClinic.DB.Data.Models.User", null)
                        .WithMany("DoctorCustomers")
                        .HasForeignKey("UserId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");

                    b.Navigation("Doctors");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorSchedule", b =>
                {
                    b.HasOne("DentalClinic.DB.Data.Models.Doctor", "Doctors")
                        .WithMany("DoctorSchedules")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DoctorSchedules_Doctors");

                    b.HasOne("DentalClinic.DB.Data.Models.User", null)
                        .WithMany("DoctorSchedules")
                        .HasForeignKey("UserId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");

                    b.Navigation("Doctors");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.Doctor", b =>
                {
                    b.Navigation("DoctorCustomers");

                    b.Navigation("DoctorSchedules");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.User", b =>
                {
                    b.Navigation("DoctorCustomers");

                    b.Navigation("DoctorSchedules");

                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
