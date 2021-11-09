using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class accountChages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubscriptionType",
                table: "Account",
                newName: "SubscriptionId");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 253, DateTimeKind.Local).AddTicks(9969), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(595), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(630), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(640), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(648), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(3697), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5597), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5681), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5691), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5699), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5710), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5718), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5725), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5732), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5742), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(1619), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2405), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2445), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2452), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2457), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(8035), 3, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9707), 1, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9791), 8, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9805), 2, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9818), 8, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9836), 1, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9849), 3, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9939), 4, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9953), 7, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9970), 2, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9983), 7, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9996), 8, new DateTime(2021, 11, 9, 11, 45, 53, 255, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(9), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(21), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(33), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(46), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(58), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(74), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(86), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(99), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(111), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(123), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(135), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(148), 10, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(160), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(172), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(245), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(260), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(273), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(286), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(298), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(311), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(323), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(340), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(352), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(365), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(378), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(390), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(403), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(415), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(427), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(440), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(452), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(464), 10, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(477), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(489), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(590), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(603), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(616), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(628), 10, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(641), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(653), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(666), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(678), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(690), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(703), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(715), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(728), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(741), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(753), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(766), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(778), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(790), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(802), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(815), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(889), 10, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(902), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(914), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(926), 3, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(939), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(951), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(963), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(976), 3, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1000), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1013), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1025), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1038), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1050), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1063), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1075), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1087), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1100), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1112), 9, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1124), 10, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1194), 1, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1207), 8, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1219), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1232), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1244), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1256), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1269), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1281), 7, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1293), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1306), 4, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1318), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1330), 5, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1343), 6, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1355), 10, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1368), 2, new DateTime(2021, 11, 9, 11, 45, 53, 256, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.CreateIndex(
                name: "IX_Account_SubscriptionId",
                table: "Account",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_SubscriptionVersionId",
                table: "Account",
                column: "SubscriptionVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Subscription_SubscriptionId",
                table: "Account",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_SubscriptionVersion_SubscriptionVersionId",
                table: "Account",
                column: "SubscriptionVersionId",
                principalTable: "SubscriptionVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Subscription_SubscriptionId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_SubscriptionVersion_SubscriptionVersionId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_SubscriptionId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_SubscriptionVersionId",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "SubscriptionId",
                table: "Account",
                newName: "SubscriptionType");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 5, DateTimeKind.Local).AddTicks(9736), new DateTime(2021, 11, 8, 17, 15, 43, 6, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(303), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(341), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(351), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(359), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(3445), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5299), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5395), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5405), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5413), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5424), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5432), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5439), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5446), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5457), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(1342), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2165), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2203), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2210), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2215), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(7775), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9464), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9550), 3, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9564), 5, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9577), 4, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9594), 5, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9686), 7, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9701), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9713), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9730), 8, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9744), 8, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9757), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9769), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9782), 8, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9795), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9807), 2, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9821), 3, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9837), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9850), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9862), 7, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9875), 9, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9887), 7, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9900), 2, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9912), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9925), 3, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9937), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(13), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(27), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(40), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(52), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(65), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(78), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(90), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(108), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(121), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(133), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(146), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(159), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(172), 1, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(184), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(197), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(210), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(222), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(235), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(247), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(334), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(347), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(360), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(373), 1, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(385), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(398), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(411), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(423), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(436), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(448), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(461), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(474), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(487), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(499), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(512), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(525), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(537), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(550), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(562), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(641), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(655), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(667), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(680), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(692), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(705), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(718), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(730), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(743), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(756), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(769), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(782), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(794), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(807), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(820), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(833), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(845), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(858), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(871), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(942), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(957), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(969), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(982), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(995), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1007), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1020), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1033), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1046), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1059), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1071), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1084), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1097), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1110), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1122), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1135), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1136) });
        }
    }
}
