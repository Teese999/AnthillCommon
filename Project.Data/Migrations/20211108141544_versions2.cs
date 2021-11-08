using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class versions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subscription",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionType",
                table: "Subscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Subscription",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SubscriptionType" },
                values: new object[] { "Basic", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(7775), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9464), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9550), 3, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9564), 5, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9577), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9594), 5, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9686), 7, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9701), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9713), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9730), 8, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9744), 8, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9757), 1, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9769), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9782), 8, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9795), 2, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9807), 2, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9821), 3, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9837), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9850), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9862), 7, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9875), 9, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9887), 7, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9900), 2, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9912), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9925), new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9937), 6, new DateTime(2021, 11, 8, 17, 15, 43, 7, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(13), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(27), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(40), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(52), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(65), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(78), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(90), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(108), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(121), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(133), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(146), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(159), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(172), 1, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(184), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(197), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(210), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(222), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(235), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(247), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(320), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(334), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(347), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(360), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(373), 1, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(385), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(398), 1, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(411), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(423), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(436), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(448), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(461), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(474), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(487), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(499), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(512), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(525), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(537), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(550), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(562), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(641), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(655), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(667), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(680), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(692), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(705), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(718), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(730), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(743), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(756), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(769), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(782), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(794), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(807), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(820), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(833), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(845), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(858), 4, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(871), 7, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(942), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(957), new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(969), 9, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(982), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(995), 5, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1007), 10, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1020), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1033), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1046), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1059), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1071), 2, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1084), 8, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1097), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1110), 3, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1122), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1135), 6, new DateTime(2021, 11, 8, 17, 15, 43, 8, DateTimeKind.Local).AddTicks(1136) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionType",
                table: "Subscription");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Subscription",
                type: "int",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 46, DateTimeKind.Local).AddTicks(2031), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3583), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3618), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3628), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3637), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(6758), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8577), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8745), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8756), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8764), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8776), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8784), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8790), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8798), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8807), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(4679), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5477), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5521), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5529), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5534), new DateTime(2021, 11, 8, 17, 3, 17, 47, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Subscription",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(1175), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2859), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2928), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2943), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2957), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2975), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2989), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3003), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3017), 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3033), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3046), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3059), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3073), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3085), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3099), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3189), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3204), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3222), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3235), 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3248), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3261), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3273), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3286), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3299), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3312), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3325), 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3338), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3351), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3363), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3376), 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3389), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3401), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3414), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3430), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3600), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3614), 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3627), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3641), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3654), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3667), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3679), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3692), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3705), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3718), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3731), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3744), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3757), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3770), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3783), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3795), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3808), 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3821), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3834), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3846), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3859), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3959), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3973), 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3986), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(3999), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4012), 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4025), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4038), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4051), 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4064), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4077), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4095), 10, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4107), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4120), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4133), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4146), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4158), 4, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4171), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4184), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4290), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4305), 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4318), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4331), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4343), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4356), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4369), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4382), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4394), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4407), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4420), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4433), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateDate", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4446), new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4459), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4472), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4484), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4497), 3, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4510), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4534), 1, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4558), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4576), 7, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4671), 6, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4693), 5, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4710), 8, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4728), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4743), 9, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateDate", "OfficeId", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4762), 2, new DateTime(2021, 11, 8, 17, 3, 17, 48, DateTimeKind.Local).AddTicks(4763) });
        }
    }
}
