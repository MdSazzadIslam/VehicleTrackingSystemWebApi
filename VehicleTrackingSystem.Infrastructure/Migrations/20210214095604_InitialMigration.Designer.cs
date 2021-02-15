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
    [Migration("20210214095604_InitialMigration")]
    partial class InitialMigration
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

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Customer", b =>
                {
                    b.Property<long>("RiderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CUSTOMER_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COUNTRY_CODE")
                        .HasColumnType("int")
                        .HasColumnName("COUNTRY_CODE");

                    b.Property<int>("ContactNo")
                        .HasColumnType("int")
                        .HasColumnName("CONTACT_NO");

                    b.Property<int>("DateOfBirth")
                        .HasColumnType("int")
                        .HasColumnName("DATE_OF_BIRTH");

                    b.Property<int>("Email")
                        .HasColumnType("int")
                        .HasColumnName("EMAIL");

                    b.Property<int>("GENDER_ID")
                        .HasColumnType("int")
                        .HasColumnName("GENDER_ID");

                    b.Property<int>("JoiningDate")
                        .HasColumnType("int")
                        .HasColumnName("JOINING_DATE");

                    b.Property<int>("RiderName")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMER_NAME");

                    b.HasKey("RiderId");

                    b.ToTable("RIDER");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Device", b =>
                {
                    b.Property<long>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("DEVICE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTACT_No");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATE_BY");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DEVICE_NAME");

                    b.Property<int>("IMEINo")
                        .HasColumnType("int")
                        .HasColumnName("IMEI_NO");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MANUFACTURER");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("DeviceId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Driver", b =>
                {
                    b.Property<long>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("DRIVER_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COUNTRY_CODE")
                        .HasColumnType("int")
                        .HasColumnName("COUNTRY_CODE");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTACT_NO");

                    b.Property<int>("DateOfBirth")
                        .HasColumnType("int")
                        .HasColumnName("DATE_OF_BIRTH");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DRIVER_NAME");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<int>("GENDER_ID")
                        .HasColumnType("int")
                        .HasColumnName("GENDER_ID");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("JOINING_DATE");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasColumnName("VEHICLE_ID");

                    b.Property<long?>("VehicleInfosVehicleId")
                        .HasColumnType("bigint");

                    b.HasKey("DriverId");

                    b.HasIndex("VehicleInfosVehicleId");

                    b.ToTable("DRIVE_INFO");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Fuel", b =>
                {
                    b.Property<long>("FuelDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("FUEL_DETAIL_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float")
                        .HasColumnName("AMOUNT");

                    b.Property<int>("BillNo")
                        .HasColumnType("int")
                        .HasColumnName("BILL_NO");

                    b.Property<DateTime>("BillingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BILLING_DATE");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasColumnName("VEHICLE_ID");

                    b.Property<long?>("VehicleInfosVehicleId")
                        .HasColumnType("bigint");

                    b.Property<double>("litre")
                        .HasColumnType("float")
                        .HasColumnName("LITRE");

                    b.HasKey("FuelDetailId");

                    b.HasIndex("VehicleInfosVehicleId");

                    b.ToTable("FUEL_DETAIL");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.LogHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATE_BY");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("Id");

                    b.ToTable("LogHistory");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Payment", b =>
                {
                    b.Property<long>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("PAYMENT_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMER_ID");

                    b.Property<long?>("CustomerRiderId")
                        .HasColumnType("bigint");

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("float")
                        .HasColumnName("PAYMENT_AMOUNT");

                    b.Property<int>("PaymentModeId")
                        .HasColumnType("int")
                        .HasColumnName("PAYMENT_MODE_ID");

                    b.HasKey("PaymentId");

                    b.HasIndex("CustomerRiderId");

                    b.ToTable("PAYMENT");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Trip", b =>
                {
                    b.Property<long>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("TRIP_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATE_BY");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint")
                        .HasColumnName("CUSTOMER_ID");

                    b.Property<long>("DriverId")
                        .HasColumnType("bigint")
                        .HasColumnName("DRIVER_ID");

                    b.Property<int>("EndLocationId")
                        .HasColumnType("int")
                        .HasColumnName("END_LOCATION");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartLocationId")
                        .HasColumnType("int")
                        .HasColumnName("START_LOCATION");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.Property<long>("VehicleId")
                        .HasColumnType("bigint")
                        .HasColumnName("VEHICLE_ID");

                    b.Property<int>("distance")
                        .HasColumnType("int")
                        .HasColumnName("DISTANCE");

                    b.HasKey("TripId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("TRIP_INFO");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.TripHistory", b =>
                {
                    b.Property<long>("TripHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("TRIP_HISTORY_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Altitude")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("ALTITUDE");

                    b.Property<int?>("CellId")
                        .HasColumnType("int")
                        .HasColumnName("CELL_ID");

                    b.Property<int?>("DeviceConnectionMessageId")
                        .HasColumnType("int");

                    b.Property<decimal>("DeviceId")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("DEVEICE_ID");

                    b.Property<long?>("DeviceId1")
                        .HasColumnType("bigint");

                    b.Property<short?>("GsmSignal")
                        .HasColumnType("smallint")
                        .HasColumnName("GSM_SIGNAL");

                    b.Property<decimal?>("HDOP")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("HDOP");

                    b.Property<decimal?>("Heading")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("HEADING");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("LATITUDE");

                    b.Property<int?>("LocationAreaCode")
                        .HasColumnType("int")
                        .HasColumnName("LOCATION_AREA_CODE");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("LONGITUDE");

                    b.Property<int?>("MobileCountryCode")
                        .HasColumnType("int")
                        .HasColumnName("MOBILE_COUNTRY_CODE");

                    b.Property<int?>("MobileNetworkCode")
                        .HasColumnType("int")
                        .HasColumnName("NETWORK_COUNTRY_CODE");

                    b.Property<double?>("Odometer")
                        .HasColumnType("float")
                        .HasColumnName("ODO_METER");

                    b.Property<bool?>("PositionStatus")
                        .HasColumnType("bit")
                        .HasColumnName("POSITION_STATUS");

                    b.Property<short?>("Satellites")
                        .HasColumnType("smallint")
                        .HasColumnName("SATELLITES");

                    b.Property<decimal?>("Speed")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("SPEED");

                    b.Property<decimal>("TripDate")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TRIP_DATE");

                    b.Property<long>("TripId")
                        .HasColumnType("bigint")
                        .HasColumnName("TRIP_ID");

                    b.HasKey("TripHistoryId");

                    b.HasIndex("DeviceId1");

                    b.HasIndex("TripId");

                    b.ToTable("VEHICLE_HISTORY");
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
                    b.Property<long>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
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

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATE_BY");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODEL_NO");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int")
                        .HasColumnName("PRODUCTION_YEAR");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REMARKS");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UPDATE_BY");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.Property<string>("VehicleName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VEHICLE_NAME");

                    b.HasKey("VehicleId");

                    b.ToTable("VEHICLE_INFO");
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

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Driver", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Vehicle", "VehicleInfos")
                        .WithMany()
                        .HasForeignKey("VehicleInfosVehicleId");

                    b.Navigation("VehicleInfos");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Fuel", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Vehicle", "VehicleInfos")
                        .WithMany()
                        .HasForeignKey("VehicleInfosVehicleId");

                    b.Navigation("VehicleInfos");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Payment", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerRiderId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.Trip", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Driver");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Domain.Entities.TripHistory", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId1");

                    b.HasOne("VehicleTrackingSystem.Domain.Entities.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Trip");
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