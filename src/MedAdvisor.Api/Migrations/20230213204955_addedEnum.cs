using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedAdvisor.Api.Migrations
{
    /// <inheritdoc />
    public partial class addedEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoneType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneTypeAsString",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneTypeAsString",
                table: "Users");
        }
    }
}
