using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPracticing.Migrations
{
    /// <inheritdoc />
    public partial class RelationsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuyId",
                table: "Passports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Passports_GuyId",
                table: "Passports",
                column: "GuyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Guys_GuyId",
                table: "Passports",
                column: "GuyId",
                principalTable: "Guys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Guys_GuyId",
                table: "Passports");

            migrationBuilder.DropIndex(
                name: "IX_Passports_GuyId",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "GuyId",
                table: "Passports");
        }
    }
}
