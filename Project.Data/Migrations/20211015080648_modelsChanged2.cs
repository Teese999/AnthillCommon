using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Data.Migrations
{
    public partial class modelsChanged2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Organisation");

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Office",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Office_OrganisationId",
                table: "Office",
                column: "OrganisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Office_Organisation_OrganisationId",
                table: "Office",
                column: "OrganisationId",
                principalTable: "Organisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Office_Organisation_OrganisationId",
                table: "Office");

            migrationBuilder.DropIndex(
                name: "IX_Office_OrganisationId",
                table: "Office");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Office");

            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Organisation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
