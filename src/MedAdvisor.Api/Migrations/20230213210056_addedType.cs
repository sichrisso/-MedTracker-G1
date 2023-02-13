using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedAdvisor.Api.Migrations
{
    /// <inheritdoc />
    public partial class addedType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileTypes",
                table: "Documents",
                newName: "FileType");

            migrationBuilder.AddColumn<string>(
                name: "PhoneTypeAsString",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneTypeAsString",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "FileType",
                table: "Documents",
                newName: "FileTypes");
        }
    }
}
