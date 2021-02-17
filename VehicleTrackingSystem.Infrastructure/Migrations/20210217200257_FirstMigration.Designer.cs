﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleTrackingSystem.Infrastructure.Data;

namespace VehicleTrackingSystem.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210217200257_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Application.Common.Models.RequestLoggerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoggerEntities");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EXPENSE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillNo")
                        .HasColumnType("int")
                        .HasColumnName("BILL_NO");

                    b.Property<decimal>("BillingAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("BILLING_AMOUNT");

                    b.Property<DateTime>("BillingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BILLING_DATE");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATE_BY");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit")
                        .HasColumnName("DELETED");

                    b.Property<int>("ExpenseSubTypeId")
                        .HasColumnType("int")
                        .HasColumnName("EXPENSE_SUB_TYPE_ID");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int")
                        .HasColumnName("EXPENSE_TYPE_ID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasColumnName("VEHICLE_ID");

                    b.HasKey("ExpenseId");

                    b.ToTable("EXPENSE");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.ExpenseSubType", b =>
                {
                    b.Property<int>("ExpenseSubTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EXPENSE_SUB_TYPE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATE_BY");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit")
                        .HasColumnName("DELETED");

                    b.Property<string>("ExpenseSubTypeName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EXPENSE_SUB_TYPE_NAME");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int")
                        .HasColumnName("EXPENSE_TYPE_ID");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("ExpenseSubTypeId");

                    b.ToTable("L_EXPENSE_SUB_TYPE");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.ExpenseType", b =>
                {
                    b.Property<int>("ExpenseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EXPENSE_TYPE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATE_BY");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit")
                        .HasColumnName("DELETED");

                    b.Property<string>("ExpenseTypeName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EXPENSE_TYPE_NAME");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("ExpenseTypeId");

                    b.ToTable("L_EXPENSE_TYPE");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Owner", b =>
                {
                    b.Property<long>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("OWNER_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTACT_NO");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COUNTRY_CODE");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATE_OF_BIRTH");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit")
                        .HasColumnName("DELETED");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<int>("GenderId")
                        .HasColumnType("int")
                        .HasColumnName("GENDER_ID");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("JOINING_DATE");

                    b.Property<int>("NidNo")
                        .HasColumnType("int")
                        .HasColumnName("NID_NO");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OWNER_NAME");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PERMANENT_ADDRESS");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PRESENT_ADDRESS");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasColumnName("VEHICLE_ID");

                    b.HasKey("OwnerId");

                    b.HasIndex("VehicleId")
                        .IsUnique();

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.UrlAction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UrlActions");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VEHICLE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("ACTIVE_STATUS");

                    b.Property<string>("ChassisNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CHASSIS_NO");

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COLOR_CODE");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COUNTRY_CODE");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATE_BY");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit")
                        .HasColumnName("DELETED");

                    b.Property<int>("EngineCC")
                        .HasColumnType("int")
                        .HasColumnName("ENGINE_CC");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGE_NAME");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("bigint")
                        .HasColumnName("MANUFACTURER_ID");

                    b.Property<string>("ModelNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODEL_NO");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int")
                        .HasColumnName("PRODUCTION_YEAR");

                    b.Property<int>("RegistrationYear")
                        .HasColumnType("int")
                        .HasColumnName("REGISTRATION_YEAR");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REMARKS");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.Property<string>("VehicleName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VEHICLE_NAME");

                    b.HasKey("VehicleId");

                    b.ToTable("VEHICLE");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Infrastructure.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Infrastructure.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ActiveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

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

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Infrastructure.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Infrastructure.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Owner", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Vehicle", null)
                        .WithOne("Owner")
                        .HasForeignKey("VehicleTrackingSystem.Domain.Entities.Owner", "VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleTrackingSystem.Infrastructure.Identity.UserRole", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Infrastructure.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleTrackingSystem.Infrastructure.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Vehicle", b =>
                {
                    b.Navigation("Owner");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Infrastructure.Identity.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Infrastructure.Identity.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}