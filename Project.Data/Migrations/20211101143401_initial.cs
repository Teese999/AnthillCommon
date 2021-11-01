using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class initial : Migration
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
                    { 1, "Country_1", new DateTime(2021, 11, 1, 17, 34, 0, 691, DateTimeKind.Local).AddTicks(9107), "City_1", "State_1", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(8455) },
                    { 2, "Country_2", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(8994), "City_2", "State_2", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9011) },
                    { 3, "Country_3", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9040), "City_3", "State_3", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9043) },
                    { 4, "Country_4", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9049), "City_4", "State_4", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9051) },
                    { 5, "Country_5", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9058), "City_5", "State_5", new DateTime(2021, 11, 1, 17, 34, 0, 693, DateTimeKind.Local).AddTicks(9059) }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(67), "Organisation_1", new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(480) },
                    { 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(894), "Organisation_2", new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(911) },
                    { 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(931), "Organisation_3", new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(934) },
                    { 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(938), "Organisation_4", new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(940) },
                    { 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(944), "Organisation_5", new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(945) }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Address", "CityId", "CreateDate", "Name", "OrganizationId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Address_1", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(2179), "Office_1", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(2515) },
                    { 2, "Address_2", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4344), "Office_2", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4361) },
                    { 3, "Address_3", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4436), "Office_3", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4440) },
                    { 4, "Address_4", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4445), "Office_4", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4447) },
                    { 5, "Address_5", 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4453), "Office_5", 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4455) },
                    { 6, "Address_6", 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4465), "Office_6", 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4468) },
                    { 7, "Address_7", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4473), "Office_7", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4475) },
                    { 8, "Address_8", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4480), "Office_8", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4481) },
                    { 9, "Address_9", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4487), "Office_9", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4488) },
                    { 10, "Address_10", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4497), "Office_10", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(4499) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8659), "Mail_2", "FirstName_2", "RandomGender_2", false, "LastName_2", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8661) },
                    { 98, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(260), "Mail_97", "FirstName_97", "RandomGender_97", false, "LastName_97", 7, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(262) },
                    { 97, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(239), "Mail_96", "FirstName_96", "RandomGender_96", false, "LastName_96", 7, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(241) },
                    { 83, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9981), "Mail_82", "FirstName_82", "RandomGender_82", false, "LastName_82", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9983) },
                    { 79, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9841), "Mail_78", "FirstName_78", "RandomGender_78", false, "LastName_78", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9843) },
                    { 52, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9460), "Mail_51", "FirstName_51", "RandomGender_51", false, "LastName_51", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9462) },
                    { 47, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9400), "Mail_46", "FirstName_46", "RandomGender_46", false, "LastName_46", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9401) },
                    { 35, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9204), "Mail_34", "FirstName_34", "RandomGender_34", false, "LastName_34", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9206) },
                    { 34, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9192), "Mail_33", "FirstName_33", "RandomGender_33", false, "LastName_33", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9193) },
                    { 30, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9138), "Mail_29", "FirstName_29", "RandomGender_29", false, "LastName_29", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9140) },
                    { 24, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9063), "Mail_23", "FirstName_23", "RandomGender_23", false, "LastName_23", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9065) },
                    { 23, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8998), "Mail_22", "FirstName_22", "RandomGender_22", false, "LastName_22", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8999) },
                    { 19, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8948), "Mail_18", "FirstName_18", "RandomGender_18", false, "LastName_18", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8950) },
                    { 13, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8870), "Mail_12", "FirstName_12", "RandomGender_12", false, "LastName_12", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8872) },
                    { 4, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8744), "Mail_3", "FirstName_3", "RandomGender_3", false, "LastName_3", 7, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8747) },
                    { 92, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(154), "Mail_91", "FirstName_91", "RandomGender_91", false, "LastName_91", 6, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(156) },
                    { 84, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9996), "Mail_83", "FirstName_83", "RandomGender_83", false, "LastName_83", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9997) },
                    { 74, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9781), "Mail_73", "FirstName_73", "RandomGender_73", false, "LastName_73", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9782) },
                    { 73, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9768), "Mail_72", "FirstName_72", "RandomGender_72", false, "LastName_72", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9770) },
                    { 60, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9557), "Mail_59", "FirstName_59", "RandomGender_59", false, "LastName_59", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9559) },
                    { 51, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9448), "Mail_50", "FirstName_50", "RandomGender_50", false, "LastName_50", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9450) },
                    { 48, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9412), "Mail_47", "FirstName_47", "RandomGender_47", false, "LastName_47", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9413) },
                    { 99, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(276), "Mail_98", "FirstName_98", "RandomGender_98", false, "LastName_98", 7, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(278) },
                    { 43, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9347), "Mail_42", "FirstName_42", "RandomGender_42", false, "LastName_42", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9349) },
                    { 7, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8793), "Mail_6", "FirstName_6", "RandomGender_6", false, "LastName_6", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8794) },
                    { 16, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8907), "Mail_15", "FirstName_15", "RandomGender_15", false, "LastName_15", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8909) },
                    { 54, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9484), "Mail_53", "FirstName_53", "RandomGender_53", false, "LastName_53", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9486) },
                    { 46, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9388), "Mail_45", "FirstName_45", "RandomGender_45", false, "LastName_45", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9389) },
                    { 37, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9229), "Mail_36", "FirstName_36", "RandomGender_36", false, "LastName_36", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9230) },
                    { 33, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9175), "Mail_32", "FirstName_32", "RandomGender_32", false, "LastName_32", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9176) },
                    { 26, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9090), "Mail_25", "FirstName_25", "RandomGender_25", false, "LastName_25", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9092) },
                    { 15, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8895), "Mail_14", "FirstName_14", "RandomGender_14", false, "LastName_14", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8897) },
                    { 1, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(6832), "Mail_0", "FirstName_0", "RandomGender_0", false, "LastName_0", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(7172) },
                    { 71, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9744), "Mail_70", "FirstName_70", "RandomGender_70", false, "LastName_70", 9, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9746) },
                    { 39, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9253), "Mail_38", "FirstName_38", "RandomGender_38", false, "LastName_38", 9, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9255) },
                    { 17, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8920), "Mail_16", "FirstName_16", "RandomGender_16", false, "LastName_16", 9, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8921) },
                    { 77, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9817), "Mail_76", "FirstName_76", "RandomGender_76", false, "LastName_76", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9818) },
                    { 67, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9695), "Mail_66", "FirstName_66", "RandomGender_66", false, "LastName_66", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9697) },
                    { 66, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9683), "Mail_65", "FirstName_65", "RandomGender_65", false, "LastName_65", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9684) },
                    { 63, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9593), "Mail_62", "FirstName_62", "RandomGender_62", false, "LastName_62", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9595) },
                    { 62, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9581), "Mail_61", "FirstName_61", "RandomGender_61", false, "LastName_61", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9583) },
                    { 56, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9509), "Mail_55", "FirstName_55", "RandomGender_55", false, "LastName_55", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9510) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 53, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9472), "Mail_52", "FirstName_52", "RandomGender_52", false, "LastName_52", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9474) },
                    { 50, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9436), "Mail_49", "FirstName_49", "RandomGender_49", false, "LastName_49", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9437) },
                    { 41, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9277), "Mail_40", "FirstName_40", "RandomGender_40", false, "LastName_40", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9279) },
                    { 32, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9163), "Mail_31", "FirstName_31", "RandomGender_31", false, "LastName_31", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9164) },
                    { 21, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8974), "Mail_20", "FirstName_20", "RandomGender_20", false, "LastName_20", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8975) },
                    { 12, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8858), "Mail_11", "FirstName_11", "RandomGender_11", false, "LastName_11", 8, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8860) },
                    { 36, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9217), "Mail_35", "FirstName_35", "RandomGender_35", false, "LastName_35", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9218) },
                    { 11, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8846), "Mail_10", "FirstName_10", "RandomGender_10", false, "LastName_10", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8847) },
                    { 10, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8833), "Mail_9", "FirstName_9", "RandomGender_9", false, "LastName_9", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8834) },
                    { 22, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8986), "Mail_21", "FirstName_21", "RandomGender_21", false, "LastName_21", 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8987) },
                    { 95, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(203), "Mail_94", "FirstName_94", "RandomGender_94", false, "LastName_94", 2, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(205) },
                    { 93, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(171), "Mail_92", "FirstName_92", "RandomGender_92", false, "LastName_92", 2, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(172) },
                    { 91, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(138), "Mail_90", "FirstName_90", "RandomGender_90", false, "LastName_90", 2, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(139) },
                    { 85, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(10), "Mail_84", "FirstName_84", "RandomGender_84", false, "LastName_84", 2, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(13) },
                    { 44, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9363), "Mail_43", "FirstName_43", "RandomGender_43", false, "LastName_43", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9365) },
                    { 40, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9265), "Mail_39", "FirstName_39", "RandomGender_39", false, "LastName_39", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9267) },
                    { 20, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8961), "Mail_19", "FirstName_19", "RandomGender_19", false, "LastName_19", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8963) },
                    { 2, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8561), "Mail_1", "FirstName_1", "RandomGender_1", false, "LastName_1", 2, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8576) },
                    { 96, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(222), "Mail_95", "FirstName_95", "RandomGender_95", false, "LastName_95", 1, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(224) },
                    { 88, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(64), "Mail_87", "FirstName_87", "RandomGender_87", false, "LastName_87", 1, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(65) },
                    { 87, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(47), "Mail_86", "FirstName_86", "RandomGender_86", false, "LastName_86", 1, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(48) },
                    { 68, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9708), "Mail_67", "FirstName_67", "RandomGender_67", false, "LastName_67", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9709) },
                    { 61, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9569), "Mail_60", "FirstName_60", "RandomGender_60", false, "LastName_60", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9571) },
                    { 45, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9375), "Mail_44", "FirstName_44", "RandomGender_44", false, "LastName_44", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9377) },
                    { 31, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9151), "Mail_30", "FirstName_30", "RandomGender_30", false, "LastName_30", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9152) },
                    { 28, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9114), "Mail_27", "FirstName_27", "RandomGender_27", false, "LastName_27", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9116) },
                    { 27, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9102), "Mail_26", "FirstName_26", "RandomGender_26", false, "LastName_26", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9104) },
                    { 14, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8883), "Mail_13", "FirstName_13", "RandomGender_13", false, "LastName_13", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8884) },
                    { 8, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8805), "Mail_7", "FirstName_7", "RandomGender_7", false, "LastName_7", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8807) },
                    { 6, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8780), "Mail_5", "FirstName_5", "RandomGender_5", false, "LastName_5", 1, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8781) },
                    { 25, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9078), "Mail_24", "FirstName_24", "RandomGender_24", false, "LastName_24", 3, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9079) },
                    { 100, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(293), "Mail_99", "FirstName_99", "RandomGender_99", false, "LastName_99", 3, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(296) },
                    { 29, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9126), "Mail_28", "FirstName_28", "RandomGender_28", false, "LastName_28", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9128) },
                    { 42, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9289), "Mail_41", "FirstName_41", "RandomGender_41", false, "LastName_41", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9291) },
                    { 9, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8817), "Mail_8", "FirstName_8", "RandomGender_8", false, "LastName_8", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8819) },
                    { 5, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8761), "Mail_4", "FirstName_4", "RandomGender_4", false, "LastName_4", 6, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8763) },
                    { 86, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(30), "Mail_85", "FirstName_85", "RandomGender_85", false, "LastName_85", 5, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(32) },
                    { 82, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9955), "Mail_81", "FirstName_81", "RandomGender_81", false, "LastName_81", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9959) },
                    { 78, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9829), "Mail_77", "FirstName_77", "RandomGender_77", false, "LastName_77", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9831) },
                    { 75, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9793), "Mail_74", "FirstName_74", "RandomGender_74", false, "LastName_74", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9794) },
                    { 65, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9666), "Mail_64", "FirstName_64", "RandomGender_64", false, "LastName_64", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9667) },
                    { 57, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9521), "Mail_56", "FirstName_56", "RandomGender_56", false, "LastName_56", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9522) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 38, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9241), "Mail_37", "FirstName_37", "RandomGender_37", false, "LastName_37", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9242) },
                    { 18, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8935), "Mail_17", "FirstName_17", "RandomGender_17", false, "LastName_17", 5, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(8937) },
                    { 64, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9652), "Mail_63", "FirstName_63", "RandomGender_63", false, "LastName_63", 10, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9653) },
                    { 94, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(186), "Mail_93", "FirstName_93", "RandomGender_93", false, "LastName_93", 4, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(188) },
                    { 81, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9865), "Mail_80", "FirstName_80", "RandomGender_80", false, "LastName_80", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9867) },
                    { 80, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9853), "Mail_79", "FirstName_79", "RandomGender_79", false, "LastName_79", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9855) },
                    { 76, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9805), "Mail_75", "FirstName_75", "RandomGender_75", false, "LastName_75", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9806) },
                    { 72, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9756), "Mail_71", "FirstName_71", "RandomGender_71", false, "LastName_71", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9758) },
                    { 70, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9732), "Mail_69", "FirstName_69", "RandomGender_69", false, "LastName_69", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9734) },
                    { 69, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9720), "Mail_68", "FirstName_68", "RandomGender_68", false, "LastName_68", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9722) },
                    { 59, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9545), "Mail_58", "FirstName_58", "RandomGender_58", false, "LastName_58", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9546) },
                    { 58, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9533), "Mail_57", "FirstName_57", "RandomGender_57", false, "LastName_57", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9534) },
                    { 55, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9496), "Mail_54", "FirstName_54", "RandomGender_54", false, "LastName_54", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9498) },
                    { 49, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9424), "Mail_48", "FirstName_48", "RandomGender_48", false, "LastName_48", 4, new DateTime(2021, 11, 1, 17, 34, 0, 694, DateTimeKind.Local).AddTicks(9425) },
                    { 89, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(80), "Mail_88", "FirstName_88", "RandomGender_88", false, "LastName_88", 4, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(81) },
                    { 90, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(118), "Mail_89", "FirstName_89", "RandomGender_89", false, "LastName_89", 10, new DateTime(2021, 11, 1, 17, 34, 0, 695, DateTimeKind.Local).AddTicks(120) }
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
                name: "IX_User_OfficeId",
                table: "User",
                column: "OfficeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Organization");
        }
    }
}
