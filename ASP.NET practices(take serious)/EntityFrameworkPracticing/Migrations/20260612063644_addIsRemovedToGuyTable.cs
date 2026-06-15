using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPracticing.Migrations
{
    /// <inheritdoc />
    public partial class addIsRemovedToGuyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Guys",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Guys");
        }
    }
}
