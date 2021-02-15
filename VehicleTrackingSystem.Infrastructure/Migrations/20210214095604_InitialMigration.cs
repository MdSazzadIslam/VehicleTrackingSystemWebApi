using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleTrackingSystem.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Device",
                columns: table => new
                {
                    DEVICE_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEVICE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MANUFACTURER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMEI_NO = table.Column<int>(type: "int", nullable: false),
                    CONTACT_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.DEVICE_ID);
                });

            migrationBuilder.CreateTable(
                name: "LoggerEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoggerEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RIDER",
                columns: table => new
                {
                    CUSTOMER_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUSTOMER_NAME = table.Column<int>(type: "int", nullable: false),
                    JOINING_DATE = table.Column<int>(type: "int", nullable: false),
                    DATE_OF_BIRTH = table.Column<int>(type: "int", nullable: false),
                    GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    COUNTRY_CODE = table.Column<int>(type: "int", nullable: false),
                    CONTACT_NO = table.Column<int>(type: "int", nullable: false),
                    EMAIL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIDER", x => x.CUSTOMER_ID);
                });

            migrationBuilder.CreateTable(
                name: "UrlActions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VEHICLE_INFO",
                columns: table => new
                {
                    VEHICLE_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VEHICLE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHASSIS_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODEL_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COLOR_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRODUCTION_YEAR = table.Column<int>(type: "int", nullable: false),
                    COUNTRY_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACTIVE_STATUS = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLE_INFO", x => x.VEHICLE_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "PAYMENT",
                columns: table => new
                {
                    PAYMENT_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAYMENT_MODE_ID = table.Column<int>(type: "int", nullable: false),
                    PAYMENT_AMOUNT = table.Column<double>(type: "float", nullable: false),
                    CUSTOMER_ID = table.Column<int>(type: "int", nullable: false),
                    CustomerRiderId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENT", x => x.PAYMENT_ID);
                    table.ForeignKey(
                        name: "FK_PAYMENT_RIDER_CustomerRiderId",
                        column: x => x.CustomerRiderId,
                        principalTable: "RIDER",
                        principalColumn: "CUSTOMER_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DRIVE_INFO",
                columns: table => new
                {
                    DRIVER_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DRIVER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JOINING_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_OF_BIRTH = table.Column<int>(type: "int", nullable: false),
                    GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    COUNTRY_CODE = table.Column<int>(type: "int", nullable: false),
                    CONTACT_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEHICLE_ID = table.Column<int>(type: "int", nullable: false),
                    VehicleInfosVehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRIVE_INFO", x => x.DRIVER_ID);
                    table.ForeignKey(
                        name: "FK_DRIVE_INFO_VEHICLE_INFO_VehicleInfosVehicleId",
                        column: x => x.VehicleInfosVehicleId,
                        principalTable: "VEHICLE_INFO",
                        principalColumn: "VEHICLE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FUEL_DETAIL",
                columns: table => new
                {
                    FUEL_DETAIL_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BILL_NO = table.Column<int>(type: "int", nullable: false),
                    BILLING_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LITRE = table.Column<double>(type: "float", nullable: false),
                    AMOUNT = table.Column<double>(type: "float", nullable: false),
                    VEHICLE_ID = table.Column<int>(type: "int", nullable: false),
                    VehicleInfosVehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUEL_DETAIL", x => x.FUEL_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_FUEL_DETAIL_VEHICLE_INFO_VehicleInfosVehicleId",
                        column: x => x.VehicleInfosVehicleId,
                        principalTable: "VEHICLE_INFO",
                        principalColumn: "VEHICLE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TRIP_INFO",
                columns: table => new
                {
                    TRIP_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    START_LOCATION = table.Column<int>(type: "int", nullable: false),
                    END_LOCATION = table.Column<int>(type: "int", nullable: false),
                    DISTANCE = table.Column<int>(type: "int", nullable: false),
                    CUSTOMER_ID = table.Column<long>(type: "bigint", nullable: false),
                    DRIVER_ID = table.Column<long>(type: "bigint", nullable: false),
                    VEHICLE_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRIP_INFO", x => x.TRIP_ID);
                    table.ForeignKey(
                        name: "FK_TRIP_INFO_DRIVE_INFO_DRIVER_ID",
                        column: x => x.DRIVER_ID,
                        principalTable: "DRIVE_INFO",
                        principalColumn: "DRIVER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRIP_INFO_RIDER_CUSTOMER_ID",
                        column: x => x.CUSTOMER_ID,
                        principalTable: "RIDER",
                        principalColumn: "CUSTOMER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRIP_INFO_VEHICLE_INFO_VEHICLE_ID",
                        column: x => x.VEHICLE_ID,
                        principalTable: "VEHICLE_INFO",
                        principalColumn: "VEHICLE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VEHICLE_HISTORY",
                columns: table => new
                {
                    TRIP_HISTORY_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LATITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LONGITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TRIP_DATE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SPEED = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HEADING = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ALTITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SATELLITES = table.Column<short>(type: "smallint", nullable: true),
                    HDOP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    POSITION_STATUS = table.Column<bool>(type: "bit", nullable: true),
                    GSM_SIGNAL = table.Column<short>(type: "smallint", nullable: true),
                    ODO_METER = table.Column<double>(type: "float", nullable: true),
                    MOBILE_COUNTRY_CODE = table.Column<int>(type: "int", nullable: true),
                    NETWORK_COUNTRY_CODE = table.Column<int>(type: "int", nullable: true),
                    LOCATION_AREA_CODE = table.Column<int>(type: "int", nullable: true),
                    CELL_ID = table.Column<int>(type: "int", nullable: true),
                    DeviceConnectionMessageId = table.Column<int>(type: "int", nullable: true),
                    TRIP_ID = table.Column<long>(type: "bigint", nullable: false),
                    DEVEICE_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeviceId1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLE_HISTORY", x => x.TRIP_HISTORY_ID);
                    table.ForeignKey(
                        name: "FK_VEHICLE_HISTORY_Device_DeviceId1",
                        column: x => x.DeviceId1,
                        principalTable: "Device",
                        principalColumn: "DEVICE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VEHICLE_HISTORY_TRIP_INFO_TRIP_ID",
                        column: x => x.TRIP_ID,
                        principalTable: "TRIP_INFO",
                        principalColumn: "TRIP_ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_DRIVE_INFO_VehicleInfosVehicleId",
                table: "DRIVE_INFO",
                column: "VehicleInfosVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_FUEL_DETAIL_VehicleInfosVehicleId",
                table: "FUEL_DETAIL",
                column: "VehicleInfosVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_PAYMENT_CustomerRiderId",
                table: "PAYMENT",
                column: "CustomerRiderId");

            migrationBuilder.CreateIndex(
                name: "IX_TRIP_INFO_CUSTOMER_ID",
                table: "TRIP_INFO",
                column: "CUSTOMER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRIP_INFO_DRIVER_ID",
                table: "TRIP_INFO",
                column: "DRIVER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRIP_INFO_VEHICLE_ID",
                table: "TRIP_INFO",
                column: "VEHICLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VEHICLE_HISTORY_DeviceId1",
                table: "VEHICLE_HISTORY",
                column: "DeviceId1");

            migrationBuilder.CreateIndex(
                name: "IX_VEHICLE_HISTORY_TRIP_ID",
                table: "VEHICLE_HISTORY",
                column: "TRIP_ID");
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
                name: "FUEL_DETAIL");

            migrationBuilder.DropTable(
                name: "LoggerEntities");

            migrationBuilder.DropTable(
                name: "LogHistory");

            migrationBuilder.DropTable(
                name: "PAYMENT");

            migrationBuilder.DropTable(
                name: "UrlActions");

            migrationBuilder.DropTable(
                name: "VEHICLE_HISTORY");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "TRIP_INFO");

            migrationBuilder.DropTable(
                name: "DRIVE_INFO");

            migrationBuilder.DropTable(
                name: "RIDER");

            migrationBuilder.DropTable(
                name: "VEHICLE_INFO");
        }
    }
}
