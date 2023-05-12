using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFLibraryDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "phone",
                table: "persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "persons");
        }
    }
}
