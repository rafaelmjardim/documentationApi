using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace documentationApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Documentations",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "patch",
                table: "Documentations",
                newName: "Patch");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Documentations",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Documentations",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Documentations",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Patch",
                table: "Documentations",
                newName: "patch");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Documentations",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Documentations",
                newName: "id");
        }
    }
}
