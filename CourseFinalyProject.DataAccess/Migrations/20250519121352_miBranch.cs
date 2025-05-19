using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFinalyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class miBranch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Branch",
                table: "MilitaryServices",
                newName: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "MilitaryServices",
                newName: "Branch");
        }
    }
}
