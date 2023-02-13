using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedAdvisor.Api.Migrations
{
    /// <inheritdoc />
    public partial class addedenumType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileType",
                table: "Documents",
                newName: "FileTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileTypes",
                table: "Documents",
                newName: "FileType");
        }
    }
}
