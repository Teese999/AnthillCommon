using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class refreshtoken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "0, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Office_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Office_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    IsFired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Country", "CreateDate", "Name", "State", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Country_1", new DateTime(2021, 11, 2, 15, 22, 33, 916, DateTimeKind.Local).AddTicks(7801), "City_1", "State_1", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(8576) },
                    { 2, "Country_2", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9142), "City_2", "State_2", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9166) },
                    { 3, "Country_3", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9189), "City_3", "State_3", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9192) },
                    { 4, "Country_4", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9199), "City_4", "State_4", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9201) },
                    { 5, "Country_5", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9207), "City_5", "State_5", new DateTime(2021, 11, 2, 15, 22, 33, 917, DateTimeKind.Local).AddTicks(9209) }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(197), "Organisation_1", new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(542) },
                    { 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(938), "Organisation_2", new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(955) },
                    { 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(983), "Organisation_3", new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(986) },
                    { 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(991), "Organisation_4", new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(992) },
                    { 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(996), "Organisation_5", new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(998) }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Address", "CityId", "CreateDate", "Name", "OrganizationId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Address_1", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(2291), "Office_1", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(2640) },
                    { 2, "Address_2", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4152), "Office_2", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4170) },
                    { 3, "Address_3", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4240), "Office_3", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4244) },
                    { 4, "Address_4", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4251), "Office_4", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4253) },
                    { 5, "Address_5", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4259), "Office_5", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4260) },
                    { 6, "Address_6", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4270), "Office_6", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4272) },
                    { 7, "Address_7", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4277), "Office_7", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4278) },
                    { 8, "Address_8", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4283), "Office_8", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4285) },
                    { 9, "Address_9", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4290), "Office_9", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4292) },
                    { 10, "Address_10", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4299), "Office_10", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(4301) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 18, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8873), "Mail_17", "FirstName_17", "RandomGender_17", false, "LastName_17", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8875) },
                    { 31, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9100), "Mail_30", "FirstName_30", "RandomGender_30", false, "LastName_30", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9102) },
                    { 19, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8886), "Mail_18", "FirstName_18", "RandomGender_18", false, "LastName_18", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8888) },
                    { 14, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8817), "Mail_13", "FirstName_13", "RandomGender_13", false, "LastName_13", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8819) },
                    { 98, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(123), "Mail_97", "FirstName_97", "RandomGender_97", false, "LastName_97", 7, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(124) },
                    { 91, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(37), "Mail_90", "FirstName_90", "RandomGender_90", false, "LastName_90", 7, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(38) },
                    { 85, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9901), "Mail_84", "FirstName_84", "RandomGender_84", false, "LastName_84", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9902) },
                    { 82, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9864), "Mail_81", "FirstName_81", "RandomGender_81", false, "LastName_81", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9865) },
                    { 81, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9852), "Mail_80", "FirstName_80", "RandomGender_80", false, "LastName_80", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9853) },
                    { 80, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9839), "Mail_79", "FirstName_79", "RandomGender_79", false, "LastName_79", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9841) },
                    { 74, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9765), "Mail_73", "FirstName_73", "RandomGender_73", false, "LastName_73", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9767) },
                    { 70, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9716), "Mail_69", "FirstName_69", "RandomGender_69", false, "LastName_69", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9718) },
                    { 66, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9606), "Mail_65", "FirstName_65", "RandomGender_65", false, "LastName_65", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9608) },
                    { 63, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9564), "Mail_62", "FirstName_62", "RandomGender_62", false, "LastName_62", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9565) },
                    { 59, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9514), "Mail_58", "FirstName_58", "RandomGender_58", false, "LastName_58", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9516) },
                    { 57, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9489), "Mail_56", "FirstName_56", "RandomGender_56", false, "LastName_56", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9491) },
                    { 47, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9302), "Mail_46", "FirstName_46", "RandomGender_46", false, "LastName_46", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9303) },
                    { 27, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8985), "Mail_26", "FirstName_26", "RandomGender_26", false, "LastName_26", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8986) },
                    { 11, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8780), "Mail_10", "FirstName_10", "RandomGender_10", false, "LastName_10", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8781) },
                    { 9, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8614), "Mail_8", "FirstName_8", "RandomGender_8", false, "LastName_8", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8616) },
                    { 4, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8546), "Mail_3", "FirstName_3", "RandomGender_3", false, "LastName_3", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8547) },
                    { 1, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(6732), "Mail_0", "FirstName_0", "RandomGender_0", false, "LastName_0", 7, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(7073) },
                    { 37, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9179), "Mail_36", "FirstName_36", "RandomGender_36", false, "LastName_36", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9180) },
                    { 100, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(147), "Mail_99", "FirstName_99", "RandomGender_99", false, "LastName_99", 6, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(149) },
                    { 56, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9477), "Mail_55", "FirstName_55", "RandomGender_55", false, "LastName_55", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9478) },
                    { 71, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9728), "Mail_70", "FirstName_70", "RandomGender_70", false, "LastName_70", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9730) },
                    { 87, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9926), "Mail_86", "FirstName_86", "RandomGender_86", false, "LastName_86", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9927) },
                    { 78, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9814), "Mail_77", "FirstName_77", "RandomGender_77", false, "LastName_77", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9816) },
                    { 75, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9777), "Mail_74", "FirstName_74", "RandomGender_74", false, "LastName_74", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9779) },
                    { 69, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9704), "Mail_68", "FirstName_68", "RandomGender_68", false, "LastName_68", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9705) },
                    { 48, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9314), "Mail_47", "FirstName_47", "RandomGender_47", false, "LastName_47", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9316) },
                    { 25, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8960), "Mail_24", "FirstName_24", "RandomGender_24", false, "LastName_24", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8962) },
                    { 15, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8830), "Mail_14", "FirstName_14", "RandomGender_14", false, "LastName_14", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8831) },
                    { 13, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8805), "Mail_12", "FirstName_12", "RandomGender_12", false, "LastName_12", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8806) },
                    { 2, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8465), "Mail_1", "FirstName_1", "RandomGender_1", false, "LastName_1", 10, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8478) },
                    { 95, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(86), "Mail_94", "FirstName_94", "RandomGender_94", false, "LastName_94", 9, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(87) },
                    { 51, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9415), "Mail_50", "FirstName_50", "RandomGender_50", false, "LastName_50", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9416) },
                    { 49, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9327), "Mail_48", "FirstName_48", "RandomGender_48", false, "LastName_48", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9328) },
                    { 43, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9253), "Mail_42", "FirstName_42", "RandomGender_42", false, "LastName_42", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9255) },
                    { 42, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9241), "Mail_41", "FirstName_41", "RandomGender_41", false, "LastName_41", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9242) },
                    { 39, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9204), "Mail_38", "FirstName_38", "RandomGender_38", false, "LastName_38", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9205) },
                    { 35, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9154), "Mail_34", "FirstName_34", "RandomGender_34", false, "LastName_34", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9156) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 33, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9125), "Mail_32", "FirstName_32", "RandomGender_32", false, "LastName_32", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9127) },
                    { 22, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8924), "Mail_21", "FirstName_21", "RandomGender_21", false, "LastName_21", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8925) },
                    { 10, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8765), "Mail_9", "FirstName_9", "RandomGender_9", false, "LastName_9", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8767) },
                    { 6, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8576), "Mail_5", "FirstName_5", "RandomGender_5", false, "LastName_5", 9, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8578) },
                    { 72, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9741), "Mail_71", "FirstName_71", "RandomGender_71", false, "LastName_71", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9742) },
                    { 68, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9690), "Mail_67", "FirstName_67", "RandomGender_67", false, "LastName_67", 8, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9692) },
                    { 94, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(74), "Mail_93", "FirstName_93", "RandomGender_93", false, "LastName_93", 6, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(75) },
                    { 88, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9938), "Mail_87", "FirstName_87", "RandomGender_87", false, "LastName_87", 6, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9939) },
                    { 41, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9228), "Mail_40", "FirstName_40", "RandomGender_40", false, "LastName_40", 6, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9230) },
                    { 26, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8973), "Mail_25", "FirstName_25", "RandomGender_25", false, "LastName_25", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8974) },
                    { 23, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8936), "Mail_22", "FirstName_22", "RandomGender_22", false, "LastName_22", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8937) },
                    { 12, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8792), "Mail_11", "FirstName_11", "RandomGender_11", false, "LastName_11", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8794) },
                    { 97, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(110), "Mail_96", "FirstName_96", "RandomGender_96", false, "LastName_96", 2, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(112) },
                    { 84, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9889), "Mail_83", "FirstName_83", "RandomGender_83", false, "LastName_83", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9890) },
                    { 76, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9790), "Mail_75", "FirstName_75", "RandomGender_75", false, "LastName_75", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9791) },
                    { 73, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9753), "Mail_72", "FirstName_72", "RandomGender_72", false, "LastName_72", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9755) },
                    { 55, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9464), "Mail_54", "FirstName_54", "RandomGender_54", false, "LastName_54", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9466) },
                    { 40, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9216), "Mail_39", "FirstName_39", "RandomGender_39", false, "LastName_39", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9218) },
                    { 34, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9142), "Mail_33", "FirstName_33", "RandomGender_33", false, "LastName_33", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9143) },
                    { 8, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8602), "Mail_7", "FirstName_7", "RandomGender_7", false, "LastName_7", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8603) },
                    { 7, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8590), "Mail_6", "FirstName_6", "RandomGender_6", false, "LastName_6", 2, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8591) },
                    { 90, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(24), "Mail_89", "FirstName_89", "RandomGender_89", false, "LastName_89", 1, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(26) },
                    { 79, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9827), "Mail_78", "FirstName_78", "RandomGender_78", false, "LastName_78", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9829) },
                    { 77, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9802), "Mail_76", "FirstName_76", "RandomGender_76", false, "LastName_76", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9803) },
                    { 65, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9589), "Mail_64", "FirstName_64", "RandomGender_64", false, "LastName_64", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9590) },
                    { 62, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9551), "Mail_61", "FirstName_61", "RandomGender_61", false, "LastName_61", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9553) },
                    { 53, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9439), "Mail_52", "FirstName_52", "RandomGender_52", false, "LastName_52", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9441) },
                    { 32, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9113), "Mail_31", "FirstName_31", "RandomGender_31", false, "LastName_31", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9114) },
                    { 28, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8997), "Mail_27", "FirstName_27", "RandomGender_27", false, "LastName_27", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8999) },
                    { 21, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8911), "Mail_20", "FirstName_20", "RandomGender_20", false, "LastName_20", 1, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8913) },
                    { 36, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9167), "Mail_35", "FirstName_35", "RandomGender_35", false, "LastName_35", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9168) },
                    { 45, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9277), "Mail_44", "FirstName_44", "RandomGender_44", false, "LastName_44", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9279) },
                    { 46, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9290), "Mail_45", "FirstName_45", "RandomGender_45", false, "LastName_45", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9291) },
                    { 58, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9502), "Mail_57", "FirstName_57", "RandomGender_57", false, "LastName_57", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9503) },
                    { 38, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9191), "Mail_37", "FirstName_37", "RandomGender_37", false, "LastName_37", 6, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9193) },
                    { 20, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8899), "Mail_19", "FirstName_19", "RandomGender_19", false, "LastName_19", 6, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8900) },
                    { 5, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8559), "Mail_4", "FirstName_4", "RandomGender_4", false, "LastName_4", 6, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8560) },
                    { 3, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8532), "Mail_2", "FirstName_2", "RandomGender_2", false, "LastName_2", 6, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8534) },
                    { 96, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(98), "Mail_95", "FirstName_95", "RandomGender_95", false, "LastName_95", 5, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(99) },
                    { 92, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(49), "Mail_91", "FirstName_91", "RandomGender_91", false, "LastName_91", 5, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(50) },
                    { 67, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9619), "Mail_66", "FirstName_66", "RandomGender_66", false, "LastName_66", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9620) },
                    { 30, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9086), "Mail_29", "FirstName_29", "RandomGender_29", false, "LastName_29", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9088) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9010), "Mail_28", "FirstName_28", "RandomGender_28", false, "LastName_28", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9011) },
                    { 16, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8843), "Mail_15", "FirstName_15", "RandomGender_15", false, "LastName_15", 5, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8845) },
                    { 89, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(11), "Mail_88", "FirstName_88", "RandomGender_88", false, "LastName_88", 10, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(13) },
                    { 86, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9913), "Mail_85", "FirstName_85", "RandomGender_85", false, "LastName_85", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9915) },
                    { 52, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9427), "Mail_51", "FirstName_51", "RandomGender_51", false, "LastName_51", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9429) },
                    { 50, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9401), "Mail_49", "FirstName_49", "RandomGender_49", false, "LastName_49", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9403) },
                    { 44, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9265), "Mail_43", "FirstName_43", "RandomGender_43", false, "LastName_43", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9267) },
                    { 24, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8948), "Mail_23", "FirstName_23", "RandomGender_23", false, "LastName_23", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8950) },
                    { 17, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8856), "Mail_16", "FirstName_16", "RandomGender_16", false, "LastName_16", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(8857) },
                    { 99, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(135), "Mail_98", "FirstName_98", "RandomGender_98", false, "LastName_98", 3, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(137) },
                    { 83, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9876), "Mail_82", "FirstName_82", "RandomGender_82", false, "LastName_82", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9878) },
                    { 64, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9576), "Mail_63", "FirstName_63", "RandomGender_63", false, "LastName_63", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9578) },
                    { 61, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9539), "Mail_60", "FirstName_60", "RandomGender_60", false, "LastName_60", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9541) },
                    { 60, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9527), "Mail_59", "FirstName_59", "RandomGender_59", false, "LastName_59", 3, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9528) },
                    { 54, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9452), "Mail_53", "FirstName_53", "RandomGender_53", false, "LastName_53", 4, new DateTime(2021, 11, 2, 15, 22, 33, 918, DateTimeKind.Local).AddTicks(9454) },
                    { 93, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(61), "Mail_92", "FirstName_92", "RandomGender_92", false, "LastName_92", 10, new DateTime(2021, 11, 2, 15, 22, 33, 919, DateTimeKind.Local).AddTicks(63) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Office_CityId",
                table: "Office",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_OrganizationId",
                table: "Office",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_AccountId",
                table: "RefreshToken",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_User_OfficeId",
                table: "User",
                column: "OfficeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Organization");
        }
    }
}
