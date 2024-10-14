using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolTvServer.Migrations
{
    /// <inheritdoc />
    public partial class AddColorHexToBreaks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorHex",
                table: "SchoolBreaks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorHex",
                table: "SchoolBreaks");
        }
    }
}
