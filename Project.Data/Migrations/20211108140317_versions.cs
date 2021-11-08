using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class versions : Migration
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
                    SubscriptionVersionId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionType = table.Column<int>(type: "int", nullable: false),
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
                    Name = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionVersion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionVersion", x => x.Id);
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
                    { 1, "Country_1", new DateTime(2021, 11, 8, 17, 3, 17, 46, DateTimeKind.Local).AddTicks(2031), "City_1", "State_1", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3119) },
                    { 2, "Country_2", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3583), "City_2", "State_2", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3598) },
                    { 3, "Country_3", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3618), "City_3", "State_3", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3621) },
                    { 4, "Country_4", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3628), "City_4", "State_4", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3630) },
                    { 5, "Country_5", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3637), "City_5", "State_5", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3639) }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(4679), "Organisation_1", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5015) },
                    { 2, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5477), "Organisation_2", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5492) },
                    { 3, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5521), "Organisation_3", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5524) },
                    { 4, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5529), "Organisation_4", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5530) },
                    { 5, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5534), "Organisation_5", new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5536) }
                });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "Id", "Cost", "Name" },
                values: new object[] { 1, 0.0, 1 });

            migrationBuilder.InsertData(
                table: "SubscriptionVersion",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[] { 1, 14, "Trial" });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Address", "CityId", "CreateDate", "Name", "OrganizationId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Address_1", 1, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(6758), "Office_1", 1, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(7085) },
                    { 2, "Address_2", 1, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8577), "Office_2", 1, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8594) },
                    { 3, "Address_3", 2, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8745), "Office_3", 2, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8749) },
                    { 4, "Address_4", 2, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8756), "Office_4", 2, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8758) },
                    { 5, "Address_5", 3, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8764), "Office_5", 3, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8766) },
                    { 6, "Address_6", 3, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8776), "Office_6", 3, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8778) },
                    { 7, "Address_7", 4, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8784), "Office_7", 4, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8785) },
                    { 8, "Address_8", 4, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8790), "Office_8", 4, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8792) },
                    { 9, "Address_9", 5, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8798), "Office_9", 5, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8799) },
                    { 10, "Address_10", 5, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8807), "Office_10", 5, new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8809) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 21, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3261), "Mail_20", "FirstName_20", "RandomGender_20", false, "LastName_20", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3262) },
                    { 97, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4710), "Mail_96", "FirstName_96", "RandomGender_96", false, "LastName_96", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4712) },
                    { 93, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4558), "Mail_92", "FirstName_92", "RandomGender_92", false, "LastName_92", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4562) },
                    { 76, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4318), "Mail_75", "FirstName_75", "RandomGender_75", false, "LastName_75", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4319) },
                    { 56, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3959), "Mail_55", "FirstName_55", "RandomGender_55", false, "LastName_55", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3961) },
                    { 50, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3795), "Mail_49", "FirstName_49", "RandomGender_49", false, "LastName_49", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3797) },
                    { 38, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3641), "Mail_37", "FirstName_37", "RandomGender_37", false, "LastName_37", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3642) },
                    { 31, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3389), "Mail_30", "FirstName_30", "RandomGender_30", false, "LastName_30", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3390) },
                    { 29, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3363), "Mail_28", "FirstName_28", "RandomGender_28", false, "LastName_28", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3365) },
                    { 16, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3189), "Mail_15", "FirstName_15", "RandomGender_15", false, "LastName_15", 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3190) },
                    { 94, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4576), "Mail_93", "FirstName_93", "RandomGender_93", false, "LastName_93", 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4577) },
                    { 63, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4051), "Mail_62", "FirstName_62", "RandomGender_62", false, "LastName_62", 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4052) },
                    { 51, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3808), "Mail_50", "FirstName_50", "RandomGender_50", false, "LastName_50", 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3809) },
                    { 36, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3614), "Mail_35", "FirstName_35", "RandomGender_35", false, "LastName_35", 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3616) },
                    { 30, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3376), "Mail_29", "FirstName_29", "RandomGender_29", false, "LastName_29", 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3377) },
                    { 19, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3235), "Mail_18", "FirstName_18", "RandomGender_18", false, "LastName_18", 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3236) },
                    { 95, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4671), "Mail_94", "FirstName_94", "RandomGender_94", false, "LastName_94", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4674) },
                    { 89, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4484), "Mail_88", "FirstName_88", "RandomGender_88", false, "LastName_88", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4486) },
                    { 83, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4407), "Mail_82", "FirstName_82", "RandomGender_82", false, "LastName_82", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4409) },
                    { 77, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4331), "Mail_76", "FirstName_76", "RandomGender_76", false, "LastName_76", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4332) },
                    { 34, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3430), "Mail_33", "FirstName_33", "RandomGender_33", false, "LastName_33", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3431) },
                    { 33, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3414), "Mail_32", "FirstName_32", "RandomGender_32", false, "LastName_32", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3415) },
                    { 7, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2989), "Mail_6", "FirstName_6", "RandomGender_6", false, "LastName_6", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2991) },
                    { 20, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3248), "Mail_19", "FirstName_19", "RandomGender_19", false, "LastName_19", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3249) },
                    { 10, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3033), "Mail_9", "FirstName_9", "RandomGender_9", false, "LastName_9", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3034) },
                    { 13, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3073), "Mail_12", "FirstName_12", "RandomGender_12", false, "LastName_12", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3074) },
                    { 61, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4025), "Mail_60", "FirstName_60", "RandomGender_60", false, "LastName_60", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4026) },
                    { 59, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3999), "Mail_58", "FirstName_58", "RandomGender_58", false, "LastName_58", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4000) },
                    { 55, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3859), "Mail_54", "FirstName_54", "RandomGender_54", false, "LastName_54", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3861) },
                    { 52, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3821), "Mail_51", "FirstName_51", "RandomGender_51", false, "LastName_51", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3822) },
                    { 48, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3770), "Mail_47", "FirstName_47", "RandomGender_47", false, "LastName_47", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3771) },
                    { 35, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3600), "Mail_34", "FirstName_34", "RandomGender_34", false, "LastName_34", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3602) },
                    { 32, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3401), "Mail_31", "FirstName_31", "RandomGender_31", false, "LastName_31", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3403) },
                    { 28, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3351), "Mail_27", "FirstName_27", "RandomGender_27", false, "LastName_27", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3352) },
                    { 27, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3338), "Mail_26", "FirstName_26", "RandomGender_26", false, "LastName_26", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3339) },
                    { 17, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3204), "Mail_16", "FirstName_16", "RandomGender_16", false, "LastName_16", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3205) },
                    { 12, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3059), "Mail_11", "FirstName_11", "RandomGender_11", false, "LastName_11", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3061) },
                    { 6, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2975), "Mail_5", "FirstName_5", "RandomGender_5", false, "LastName_5", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2977) },
                    { 99, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4743), "Mail_98", "FirstName_98", "RandomGender_98", false, "LastName_98", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4745) },
                    { 98, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4728), "Mail_97", "FirstName_97", "RandomGender_97", false, "LastName_97", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4729) },
                    { 86, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4446), "Mail_85", "FirstName_85", "RandomGender_85", false, "LastName_85", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4448) },
                    { 80, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4369), "Mail_79", "FirstName_79", "RandomGender_79", false, "LastName_79", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4371) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 53, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3834), "Mail_52", "FirstName_52", "RandomGender_52", false, "LastName_52", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3835) },
                    { 44, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3718), "Mail_43", "FirstName_43", "RandomGender_43", false, "LastName_43", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3719) },
                    { 39, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3654), "Mail_38", "FirstName_38", "RandomGender_38", false, "LastName_38", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3655) },
                    { 22, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3273), "Mail_21", "FirstName_21", "RandomGender_21", false, "LastName_21", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3275) },
                    { 15, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3099), "Mail_14", "FirstName_14", "RandomGender_14", false, "LastName_14", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3100) },
                    { 11, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3046), "Mail_10", "FirstName_10", "RandomGender_10", false, "LastName_10", 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3048) },
                    { 2, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2859), "Mail_1", "FirstName_1", "RandomGender_1", false, "LastName_1", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2872) },
                    { 1, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(1175), "Mail_0", "FirstName_0", "RandomGender_0", false, "LastName_0", 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(1506) },
                    { 96, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4693), "Mail_95", "FirstName_95", "RandomGender_95", false, "LastName_95", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4694) },
                    { 68, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4120), "Mail_67", "FirstName_67", "RandomGender_67", false, "LastName_67", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4122) },
                    { 54, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3846), "Mail_53", "FirstName_53", "RandomGender_53", false, "LastName_53", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3848) },
                    { 25, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3312), "Mail_24", "FirstName_24", "RandomGender_24", false, "LastName_24", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3313) },
                    { 4, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2943), "Mail_3", "FirstName_3", "RandomGender_3", false, "LastName_3", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2945) },
                    { 100, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4762), "Mail_99", "FirstName_99", "RandomGender_99", false, "LastName_99", 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4763) },
                    { 75, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4305), "Mail_74", "FirstName_74", "RandomGender_74", false, "LastName_74", 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4306) },
                    { 60, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4012), "Mail_59", "FirstName_59", "RandomGender_59", false, "LastName_59", 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4013) },
                    { 57, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3973), "Mail_56", "FirstName_56", "RandomGender_56", false, "LastName_56", 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3975) },
                    { 26, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3325), "Mail_25", "FirstName_25", "RandomGender_25", false, "LastName_25", 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3326) },
                    { 9, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3017), "Mail_8", "FirstName_8", "RandomGender_8", false, "LastName_8", 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3018) },
                    { 92, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4534), "Mail_91", "FirstName_91", "RandomGender_91", false, "LastName_91", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4537) },
                    { 87, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4459), "Mail_86", "FirstName_86", "RandomGender_86", false, "LastName_86", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4460) },
                    { 85, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4433), "Mail_84", "FirstName_84", "RandomGender_84", false, "LastName_84", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4435) },
                    { 84, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4420), "Mail_83", "FirstName_83", "RandomGender_83", false, "LastName_83", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4422) },
                    { 82, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4394), "Mail_81", "FirstName_81", "RandomGender_81", false, "LastName_81", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4396) },
                    { 81, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4382), "Mail_80", "FirstName_80", "RandomGender_80", false, "LastName_80", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4383) },
                    { 79, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4356), "Mail_78", "FirstName_78", "RandomGender_78", false, "LastName_78", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4358) },
                    { 65, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4077), "Mail_64", "FirstName_64", "RandomGender_64", false, "LastName_64", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4078) },
                    { 47, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3757), "Mail_46", "FirstName_46", "RandomGender_46", false, "LastName_46", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3759) },
                    { 45, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3731), "Mail_44", "FirstName_44", "RandomGender_44", false, "LastName_44", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3732) },
                    { 24, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3299), "Mail_23", "FirstName_23", "RandomGender_23", false, "LastName_23", 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3300) },
                    { 70, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4146), "Mail_69", "FirstName_69", "RandomGender_69", false, "LastName_69", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4147) },
                    { 72, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4171), "Mail_71", "FirstName_71", "RandomGender_71", false, "LastName_71", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4173) },
                    { 74, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4290), "Mail_73", "FirstName_73", "RandomGender_73", false, "LastName_73", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4292) },
                    { 88, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4472), "Mail_87", "FirstName_87", "RandomGender_87", false, "LastName_87", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4473) },
                    { 91, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4510), "Mail_90", "FirstName_90", "RandomGender_90", false, "LastName_90", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4511) },
                    { 78, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4343), "Mail_77", "FirstName_77", "RandomGender_77", false, "LastName_77", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4345) },
                    { 73, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4184), "Mail_72", "FirstName_72", "RandomGender_72", false, "LastName_72", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4185) },
                    { 67, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4107), "Mail_66", "FirstName_66", "RandomGender_66", false, "LastName_66", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4109) },
                    { 64, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4064), "Mail_63", "FirstName_63", "RandomGender_63", false, "LastName_63", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4065) },
                    { 49, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3783), "Mail_48", "FirstName_48", "RandomGender_48", false, "LastName_48", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3784) },
                    { 46, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3744), "Mail_45", "FirstName_45", "RandomGender_45", false, "LastName_45", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3746) },
                    { 41, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3679), "Mail_40", "FirstName_40", "RandomGender_40", false, "LastName_40", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3681) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 40, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3667), "Mail_39", "FirstName_39", "RandomGender_39", false, "LastName_39", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3668) },
                    { 37, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3627), "Mail_36", "FirstName_36", "RandomGender_36", false, "LastName_36", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3629) },
                    { 62, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4038), "Mail_61", "FirstName_61", "RandomGender_61", false, "LastName_61", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4039) },
                    { 3, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2928), "Mail_2", "FirstName_2", "RandomGender_2", false, "LastName_2", 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2930) },
                    { 69, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4133), "Mail_68", "FirstName_68", "RandomGender_68", false, "LastName_68", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4134) },
                    { 58, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3986), "Mail_57", "FirstName_57", "RandomGender_57", false, "LastName_57", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3988) },
                    { 43, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3705), "Mail_42", "FirstName_42", "RandomGender_42", false, "LastName_42", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3706) },
                    { 42, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3692), "Mail_41", "FirstName_41", "RandomGender_41", false, "LastName_41", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3694) },
                    { 23, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3286), "Mail_22", "FirstName_22", "RandomGender_22", false, "LastName_22", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3288) },
                    { 18, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3222), "Mail_17", "FirstName_17", "RandomGender_17", false, "LastName_17", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3223) },
                    { 14, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3085), "Mail_13", "FirstName_13", "RandomGender_13", false, "LastName_13", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3087) },
                    { 8, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3003), "Mail_7", "FirstName_7", "RandomGender_7", false, "LastName_7", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3004) },
                    { 5, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2957), "Mail_4", "FirstName_4", "RandomGender_4", false, "LastName_4", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2959) },
                    { 90, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4497), "Mail_89", "FirstName_89", "RandomGender_89", false, "LastName_89", 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4498) },
                    { 71, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4158), "Mail_70", "FirstName_70", "RandomGender_70", false, "LastName_70", 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4160) },
                    { 66, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4095), "Mail_65", "FirstName_65", "RandomGender_65", false, "LastName_65", 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4096) }
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
                name: "SubscriptionVersion");

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
