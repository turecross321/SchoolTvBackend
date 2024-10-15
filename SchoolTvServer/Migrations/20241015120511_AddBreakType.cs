using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolTvServer.Migrations
{
    /// <inheritdoc />
    public partial class AddBreakType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlwaysShow",
                table: "SchoolBreaks",
                newName: "BreakType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BreakType",
                table: "SchoolBreaks",
                newName: "AlwaysShow");
        }
    }
}
