using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourOfHeroApi.Migrations
{
    /// <inheritdoc />
    public partial class AddAlter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Alter",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alter",
                table: "Heroes");
        }
    }
}
