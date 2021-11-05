using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class inittial : Migration
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
                    Role = table.Column<int>(type: "int", nullable: false),
                    SubscriptionVersion = table.Column<int>(type: "int", nullable: false),
                    SubscriptionPlanId = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionStartDate = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false)
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
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    SubscriptionSequrity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
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
                    { 1, "Country_1", new DateTime(2021, 11, 5, 13, 31, 18, 9, DateTimeKind.Local).AddTicks(6314), "City_1", "State_1", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7364) },
                    { 2, "Country_2", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7842), "City_2", "State_2", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7857) },
                    { 3, "Country_3", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7876), "City_3", "State_3", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7879) },
                    { 4, "Country_4", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7886), "City_4", "State_4", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7888) },
                    { 5, "Country_5", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7894), "City_5", "State_5", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(7896) }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(8854), "Organisation_1", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9192) },
                    { 2, new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9595), "Organisation_2", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9610) },
                    { 3, new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9638), "Organisation_3", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9641) },
                    { 4, new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9645), "Organisation_4", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9647) },
                    { 5, new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9651), "Organisation_5", new DateTime(2021, 11, 5, 13, 31, 18, 10, DateTimeKind.Local).AddTicks(9653) }
                });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "Id", "Cost", "Name", "SubscriptionSequrity" },
                values: new object[] { 1, 0.0, "Basic", 1 });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Address", "CityId", "CreateDate", "Name", "OrganizationId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Address_1", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(1053), "Office_1", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(1382) },
                    { 2, "Address_2", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(2858), "Office_2", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(2874) },
                    { 3, "Address_3", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(2946), "Office_3", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(2950) },
                    { 4, "Address_4", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(2957), "Office_4", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(2958) },
                    { 5, "Address_5", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3053), "Office_5", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3057) },
                    { 6, "Address_6", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3068), "Office_6", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3070) },
                    { 7, "Address_7", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3076), "Office_7", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3077) },
                    { 8, "Address_8", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3083), "Office_8", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3085) },
                    { 9, "Address_9", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3090), "Office_9", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3092) },
                    { 10, "Address_10", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3101), "Office_10", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(3103) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 8, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7279), "Mail_7", "FirstName_7", "RandomGender_7", false, "LastName_7", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7280) },
                    { 80, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8442), "Mail_79", "FirstName_79", "RandomGender_79", false, "LastName_79", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8443) },
                    { 66, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8220), "Mail_65", "FirstName_65", "RandomGender_65", false, "LastName_65", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8221) },
                    { 56, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8037), "Mail_55", "FirstName_55", "RandomGender_55", false, "LastName_55", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8038) },
                    { 42, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7864), "Mail_41", "FirstName_41", "RandomGender_41", false, "LastName_41", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7865) },
                    { 40, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7839), "Mail_39", "FirstName_39", "RandomGender_39", false, "LastName_39", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7841) },
                    { 32, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7686), "Mail_31", "FirstName_31", "RandomGender_31", false, "LastName_31", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7688) },
                    { 27, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7623), "Mail_26", "FirstName_26", "RandomGender_26", false, "LastName_26", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7625) },
                    { 22, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7560), "Mail_21", "FirstName_21", "RandomGender_21", false, "LastName_21", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7562) },
                    { 16, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7386), "Mail_15", "FirstName_15", "RandomGender_15", false, "LastName_15", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7387) },
                    { 9, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7291), "Mail_8", "FirstName_8", "RandomGender_8", false, "LastName_8", 8, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7293) },
                    { 90, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8565), "Mail_89", "FirstName_89", "RandomGender_89", false, "LastName_89", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8567) },
                    { 87, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8528), "Mail_86", "FirstName_86", "RandomGender_86", false, "LastName_86", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8530) },
                    { 73, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8307), "Mail_72", "FirstName_72", "RandomGender_72", false, "LastName_72", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8308) },
                    { 43, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7876), "Mail_42", "FirstName_42", "RandomGender_42", false, "LastName_42", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7878) },
                    { 23, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7573), "Mail_22", "FirstName_22", "RandomGender_22", false, "LastName_22", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7575) },
                    { 21, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7547), "Mail_20", "FirstName_20", "RandomGender_20", false, "LastName_20", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7549) },
                    { 6, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7253), "Mail_5", "FirstName_5", "RandomGender_5", false, "LastName_5", 7, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7255) },
                    { 97, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8699), "Mail_96", "FirstName_96", "RandomGender_96", false, "LastName_96", 6, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8700) },
                    { 92, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8591), "Mail_91", "FirstName_91", "RandomGender_91", false, "LastName_91", 6, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8592) },
                    { 86, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8516), "Mail_85", "FirstName_85", "RandomGender_85", false, "LastName_85", 6, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8517) },
                    { 1, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(5440), "Mail_0", "FirstName_0", "RandomGender_0", false, "LastName_0", 6, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(5769) },
                    { 2, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7127), "Mail_1", "FirstName_1", "RandomGender_1", false, "LastName_1", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7140) },
                    { 99, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8724), "Mail_98", "FirstName_98", "RandomGender_98", false, "LastName_98", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8725) },
                    { 7, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7266), "Mail_6", "FirstName_6", "RandomGender_6", false, "LastName_6", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7268) },
                    { 26, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7611), "Mail_25", "FirstName_25", "RandomGender_25", false, "LastName_25", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7612) },
                    { 79, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8429), "Mail_78", "FirstName_78", "RandomGender_78", false, "LastName_78", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8431) },
                    { 72, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8294), "Mail_71", "FirstName_71", "RandomGender_71", false, "LastName_71", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8296) },
                    { 69, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8257), "Mail_68", "FirstName_68", "RandomGender_68", false, "LastName_68", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8259) },
                    { 54, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8012), "Mail_53", "FirstName_53", "RandomGender_53", false, "LastName_53", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8014) },
                    { 41, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7851), "Mail_40", "FirstName_40", "RandomGender_40", false, "LastName_40", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7853) },
                    { 31, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7674), "Mail_30", "FirstName_30", "RandomGender_30", false, "LastName_30", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7676) },
                    { 25, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7598), "Mail_24", "FirstName_24", "RandomGender_24", false, "LastName_24", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7600) },
                    { 3, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7209), "Mail_2", "FirstName_2", "RandomGender_2", false, "LastName_2", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7210) },
                    { 96, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8685), "Mail_95", "FirstName_95", "RandomGender_95", false, "LastName_95", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8687) },
                    { 95, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8628), "Mail_94", "FirstName_94", "RandomGender_94", false, "LastName_94", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8629) },
                    { 93, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8603), "Mail_92", "FirstName_92", "RandomGender_92", false, "LastName_92", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8604) },
                    { 89, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8553), "Mail_88", "FirstName_88", "RandomGender_88", false, "LastName_88", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8555) },
                    { 76, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8392), "Mail_75", "FirstName_75", "RandomGender_75", false, "LastName_75", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8394) },
                    { 70, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8269), "Mail_69", "FirstName_69", "RandomGender_69", false, "LastName_69", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8271) },
                    { 68, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8245), "Mail_67", "FirstName_67", "RandomGender_67", false, "LastName_67", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8246) },
                    { 61, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8153), "Mail_60", "FirstName_60", "RandomGender_60", false, "LastName_60", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8154) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 58, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8115), "Mail_57", "FirstName_57", "RandomGender_57", false, "LastName_57", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8116) },
                    { 48, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7938), "Mail_47", "FirstName_47", "RandomGender_47", false, "LastName_47", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7940) },
                    { 47, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7926), "Mail_46", "FirstName_46", "RandomGender_46", false, "LastName_46", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7927) },
                    { 29, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7649), "Mail_28", "FirstName_28", "RandomGender_28", false, "LastName_28", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7650) },
                    { 28, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7636), "Mail_27", "FirstName_27", "RandomGender_27", false, "LastName_27", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7638) },
                    { 19, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7522), "Mail_18", "FirstName_18", "RandomGender_18", false, "LastName_18", 9, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7523) },
                    { 83, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8478), "Mail_82", "FirstName_82", "RandomGender_82", false, "LastName_82", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8480) },
                    { 55, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8025), "Mail_54", "FirstName_54", "RandomGender_54", false, "LastName_54", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8026) },
                    { 52, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7988), "Mail_51", "FirstName_51", "RandomGender_51", false, "LastName_51", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7989) },
                    { 88, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8541), "Mail_87", "FirstName_87", "RandomGender_87", false, "LastName_87", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8542) },
                    { 85, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8503), "Mail_84", "FirstName_84", "RandomGender_84", false, "LastName_84", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8505) },
                    { 78, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8417), "Mail_77", "FirstName_77", "RandomGender_77", false, "LastName_77", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8419) },
                    { 77, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8405), "Mail_76", "FirstName_76", "RandomGender_76", false, "LastName_76", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8406) },
                    { 57, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8101), "Mail_56", "FirstName_56", "RandomGender_56", false, "LastName_56", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8102) },
                    { 51, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7975), "Mail_50", "FirstName_50", "RandomGender_50", false, "LastName_50", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7977) },
                    { 46, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7913), "Mail_45", "FirstName_45", "RandomGender_45", false, "LastName_45", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7915) },
                    { 45, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7901), "Mail_44", "FirstName_44", "RandomGender_44", false, "LastName_44", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7902) },
                    { 24, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7586), "Mail_23", "FirstName_23", "RandomGender_23", false, "LastName_23", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7588) },
                    { 20, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7534), "Mail_19", "FirstName_19", "RandomGender_19", false, "LastName_19", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7536) },
                    { 5, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7235), "Mail_4", "FirstName_4", "RandomGender_4", false, "LastName_4", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7236) },
                    { 4, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7222), "Mail_3", "FirstName_3", "RandomGender_3", false, "LastName_3", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7224) },
                    { 74, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8319), "Mail_73", "FirstName_73", "RandomGender_73", false, "LastName_73", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8321) },
                    { 65, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8202), "Mail_64", "FirstName_64", "RandomGender_64", false, "LastName_64", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8204) },
                    { 62, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8165), "Mail_61", "FirstName_61", "RandomGender_61", false, "LastName_61", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8167) },
                    { 53, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8000), "Mail_52", "FirstName_52", "RandomGender_52", false, "LastName_52", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8002) },
                    { 38, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7814), "Mail_37", "FirstName_37", "RandomGender_37", false, "LastName_37", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7816) },
                    { 33, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7699), "Mail_32", "FirstName_32", "RandomGender_32", false, "LastName_32", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7700) },
                    { 18, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7508), "Mail_17", "FirstName_17", "RandomGender_17", false, "LastName_17", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7510) },
                    { 17, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7489), "Mail_16", "FirstName_16", "RandomGender_16", false, "LastName_16", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7491) },
                    { 10, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7307), "Mail_9", "FirstName_9", "RandomGender_9", false, "LastName_9", 1, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7308) },
                    { 94, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8615), "Mail_93", "FirstName_93", "RandomGender_93", false, "LastName_93", 2, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8617) },
                    { 13, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7348), "Mail_12", "FirstName_12", "RandomGender_12", false, "LastName_12", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7350) },
                    { 15, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7373), "Mail_14", "FirstName_14", "RandomGender_14", false, "LastName_14", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7375) },
                    { 59, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8128), "Mail_58", "FirstName_58", "RandomGender_58", false, "LastName_58", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8129) },
                    { 50, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7963), "Mail_49", "FirstName_49", "RandomGender_49", false, "LastName_49", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7965) },
                    { 44, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7888), "Mail_43", "FirstName_43", "RandomGender_43", false, "LastName_43", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7890) },
                    { 39, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7827), "Mail_38", "FirstName_38", "RandomGender_38", false, "LastName_38", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7828) },
                    { 36, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7788), "Mail_35", "FirstName_35", "RandomGender_35", false, "LastName_35", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7790) },
                    { 35, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7728), "Mail_34", "FirstName_34", "RandomGender_34", false, "LastName_34", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7730) },
                    { 11, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7323), "Mail_10", "FirstName_10", "RandomGender_10", false, "LastName_10", 5, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7324) },
                    { 100, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8736), "Mail_99", "FirstName_99", "RandomGender_99", false, "LastName_99", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8738) },
                    { 84, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8491), "Mail_83", "FirstName_83", "RandomGender_83", false, "LastName_83", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8492) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 71, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8282), "Mail_70", "FirstName_70", "RandomGender_70", false, "LastName_70", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8284) },
                    { 64, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8190), "Mail_63", "FirstName_63", "RandomGender_63", false, "LastName_63", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8192) },
                    { 81, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8454), "Mail_80", "FirstName_80", "RandomGender_80", false, "LastName_80", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8456) },
                    { 49, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7951), "Mail_48", "FirstName_48", "RandomGender_48", false, "LastName_48", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7952) },
                    { 34, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7715), "Mail_33", "FirstName_33", "RandomGender_33", false, "LastName_33", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7717) },
                    { 30, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7661), "Mail_29", "FirstName_29", "RandomGender_29", false, "LastName_29", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7663) },
                    { 14, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7361), "Mail_13", "FirstName_13", "RandomGender_13", false, "LastName_13", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7363) },
                    { 12, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7336), "Mail_11", "FirstName_11", "RandomGender_11", false, "LastName_11", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7337) },
                    { 98, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8711), "Mail_97", "FirstName_97", "RandomGender_97", false, "LastName_97", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8713) },
                    { 91, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8578), "Mail_90", "FirstName_90", "RandomGender_90", false, "LastName_90", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8580) },
                    { 75, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8379), "Mail_74", "FirstName_74", "RandomGender_74", false, "LastName_74", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8380) },
                    { 67, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8232), "Mail_66", "FirstName_66", "RandomGender_66", false, "LastName_66", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8234) },
                    { 63, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8178), "Mail_62", "FirstName_62", "RandomGender_62", false, "LastName_62", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8179) },
                    { 60, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8140), "Mail_59", "FirstName_59", "RandomGender_59", false, "LastName_59", 3, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8142) },
                    { 37, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7802), "Mail_36", "FirstName_36", "RandomGender_36", false, "LastName_36", 4, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(7803) },
                    { 82, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8466), "Mail_81", "FirstName_81", "RandomGender_81", false, "LastName_81", 10, new DateTime(2021, 11, 5, 13, 31, 18, 11, DateTimeKind.Local).AddTicks(8468) }
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
                name: "Subscription");

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
