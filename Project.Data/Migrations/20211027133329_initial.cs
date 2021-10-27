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
                    UpdateTime = table.Column<DateTime>(type: "datetime2", maxLength: 19, nullable: false)
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
                    { 1, "Country_1", new DateTime(2021, 10, 27, 16, 33, 28, 817, DateTimeKind.Local).AddTicks(201), "City_1", "State_1", new DateTime(2021, 10, 27, 16, 33, 28, 817, DateTimeKind.Local).AddTicks(9835) },
                    { 9, "Country_9", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(404), "City_9", "State_9", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(405) },
                    { 8, "Country_8", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(396), "City_8", "State_8", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(398) },
                    { 7, "Country_7", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(388), "City_7", "State_7", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(389) },
                    { 6, "Country_6", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(378), "City_6", "State_6", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(381) },
                    { 10, "Country_10", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(415), "City_10", "State_10", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(417) },
                    { 4, "Country_4", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(357), "City_4", "State_4", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(358) },
                    { 3, "Country_3", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(346), "City_3", "State_3", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(349) },
                    { 2, "Country_2", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(307), "City_2", "State_2", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(324) },
                    { 5, "Country_5", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(365), "City_5", "State_5", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(366) }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateTime" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2193), "Organisation_9", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2194) },
                    { 1, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(1384), "Organisation_1", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(1725) },
                    { 2, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2118), "Organisation_2", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2134) },
                    { 3, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2153), "Organisation_3", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2157) },
                    { 4, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2161), "Organisation_4", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2162) },
                    { 5, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2167), "Organisation_5", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2168) },
                    { 6, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2176), "Organisation_6", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2178) },
                    { 7, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2182), "Organisation_7", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2183) },
                    { 8, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2187), "Organisation_8", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2189) },
                    { 10, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2200), "Organisation_10", new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(2202) }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Address", "CityId", "CreateDate", "Name", "OrganizationId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Address_1", 1, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(3432), "Office_1", 1, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(3767) },
                    { 2, "Address_2", 2, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5317), "Office_2", 2, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5334) },
                    { 3, "Address_3", 3, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5409), "Office_3", 3, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5412) },
                    { 4, "Address_4", 4, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5418), "Office_4", 4, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5420) },
                    { 5, "Address_5", 5, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5426), "Office_5", 5, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5427) },
                    { 6, "Address_6", 6, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5437), "Office_6", 6, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5440) },
                    { 7, "Address_7", 7, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5445), "Office_7", 7, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5446) },
                    { 8, "Address_8", 8, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5452), "Office_8", 8, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5453) },
                    { 9, "Address_9", 9, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5458), "Office_9", 9, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5460) },
                    { 10, "Address_10", 10, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5468), "Office_10", 10, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(5470) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Email", "FirstName", "Gender", "IsFired", "LastName", "OfficeId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(7767), "Mail_0", "FirstName_0", "RandomGender_0", false, "LastName_0", 1, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(8103) },
                    { 2, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9453), "Mail_1", "FirstName_1", "RandomGender_1", false, "LastName_1", 2, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9468) },
                    { 3, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9523), "Mail_2", "FirstName_2", "RandomGender_2", false, "LastName_2", 3, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9525) },
                    { 4, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9537), "Mail_3", "FirstName_3", "RandomGender_3", false, "LastName_3", 4, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9538) },
                    { 5, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9549), "Mail_4", "FirstName_4", "RandomGender_4", false, "LastName_4", 5, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9550) },
                    { 6, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9565), "Mail_5", "FirstName_5", "RandomGender_5", false, "LastName_5", 6, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9567) },
                    { 7, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9578), "Mail_6", "FirstName_6", "RandomGender_6", false, "LastName_6", 7, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9579) },
                    { 8, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9590), "Mail_7", "FirstName_7", "RandomGender_7", false, "LastName_7", 8, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9591) },
                    { 9, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9601), "Mail_8", "FirstName_8", "RandomGender_8", false, "LastName_8", 9, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9603) },
                    { 10, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9616), "Mail_9", "FirstName_9", "RandomGender_9", false, "LastName_9", 10, new DateTime(2021, 10, 27, 16, 33, 28, 818, DateTimeKind.Local).AddTicks(9617) }
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
