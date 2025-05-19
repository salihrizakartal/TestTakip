using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTakip.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestDate",
                table: "TestPlans",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "TestPlans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TestPlans");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "TestPlans",
                newName: "TestDate");
        }
    }
}
