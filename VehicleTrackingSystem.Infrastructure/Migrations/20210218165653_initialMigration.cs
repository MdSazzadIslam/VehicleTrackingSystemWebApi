using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleTrackingSystem.Infrastructure.Migrations
{
    public partial class initialMigration : Migration
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
                name: "BILL_PAYMENT",
                columns: table => new
                {
                    BILL_PAYMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BILL_NO = table.Column<int>(type: "int", nullable: false),
                    BILLING_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BILLING_AMOUNT = table.Column<double>(type: "float", nullable: false),
                    DISCOUNT_AMOUNT = table.Column<double>(type: "float", nullable: false),
                    DUE_AMOUNT = table.Column<double>(type: "float", nullable: false),
                    PAYMENT_AMOUNT = table.Column<double>(type: "float", nullable: false),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_BY = table.Column<int>(type: "int", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BILL_PAYMENT", x => x.BILL_PAYMENT_ID);
                });

            migrationBuilder.CreateTable(
                name: "EXPENSE",
                columns: table => new
                {
                    EXPENSE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EXPENSE_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    EXPENSE_SUB_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    BILL_NO = table.Column<int>(type: "int", nullable: false),
                    QUANTITY = table.Column<int>(type: "int", nullable: false),
                    BILLING_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BILLING_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    VEHICLE_ID = table.Column<int>(type: "int", nullable: false),
                    CREATE_BY = table.Column<int>(type: "int", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXPENSE", x => x.EXPENSE_ID);
                });

            migrationBuilder.CreateTable(
                name: "L_EXPENSE_SUB_TYPE",
                columns: table => new
                {
                    EXPENSE_SUB_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EXPENSE_SUB_TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXPENSE_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_BY = table.Column<int>(type: "int", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_EXPENSE_SUB_TYPE", x => x.EXPENSE_SUB_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "L_EXPENSE_TYPE",
                columns: table => new
                {
                    EXPENSE_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EXPENSE_TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_BY = table.Column<int>(type: "int", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_EXPENSE_TYPE", x => x.EXPENSE_TYPE_ID);
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
                name: "VEHICLE",
                columns: table => new
                {
                    VEHICLE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VEHICLE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MANUFACTURER_ID = table.Column<long>(type: "bigint", nullable: false),
                    CHASSIS_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODEL_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COLOR_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRODUCTION_YEAR = table.Column<int>(type: "int", nullable: false),
                    REGISTRATION_YEAR = table.Column<int>(type: "int", nullable: false),
                    ENGINE_CC = table.Column<int>(type: "int", nullable: false),
                    COUNTRY_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACTIVE_STATUS = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_BY = table.Column<int>(type: "int", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLE", x => x.VEHICLE_ID);
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
                name: "OWNER",
                columns: table => new
                {
                    OWNER_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OWNER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JOINING_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NID_NO = table.Column<int>(type: "int", nullable: false),
                    GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    PRESENT_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PERMANENT_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COUNTRY_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTACT_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    VEHICLE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OWNER", x => x.OWNER_ID);
                    table.ForeignKey(
                        name: "FK_OWNER_VEHICLE_VEHICLE_ID",
                        column: x => x.VEHICLE_ID,
                        principalTable: "VEHICLE",
                        principalColumn: "VEHICLE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VEHICLE_LOCATION",
                columns: table => new
                {
                    VEHICLE_LOCATION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LATITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LONGITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TRIP_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TRIP_TIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPEED = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ALTITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DELETED = table.Column<bool>(type: "bit", nullable: false),
                    VEHICLE_ID = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId1 = table.Column<int>(type: "int", nullable: true),
                    CREATE_BY = table.Column<int>(type: "int", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLE_LOCATION", x => x.VEHICLE_LOCATION_ID);
                    table.ForeignKey(
                        name: "FK_VEHICLE_LOCATION_VEHICLE_VehicleId1",
                        column: x => x.VehicleId1,
                        principalTable: "VEHICLE",
                        principalColumn: "VEHICLE_ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_OWNER_VEHICLE_ID",
                table: "OWNER",
                column: "VEHICLE_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VEHICLE_LOCATION_VehicleId1",
                table: "VEHICLE_LOCATION",
                column: "VehicleId1");
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
                name: "BILL_PAYMENT");

            migrationBuilder.DropTable(
                name: "EXPENSE");

            migrationBuilder.DropTable(
                name: "L_EXPENSE_SUB_TYPE");

            migrationBuilder.DropTable(
                name: "L_EXPENSE_TYPE");

            migrationBuilder.DropTable(
                name: "LoggerEntities");

            migrationBuilder.DropTable(
                name: "OWNER");

            migrationBuilder.DropTable(
                name: "UrlActions");

            migrationBuilder.DropTable(
                name: "VEHICLE_LOCATION");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "VEHICLE");
        }
    }
}
