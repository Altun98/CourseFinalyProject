using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFinalyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mi2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtenstionOFServiceLives_EmployeeDocuments_EmpDocID",
                table: "ExtenstionOFServiceLives");

            migrationBuilder.DropForeignKey(
                name: "FK_Gives_DodtGoAbroads_DodtGoAbroadId",
                table: "Gives");

            migrationBuilder.DropForeignKey(
                name: "FK_Gives_EmployeeDocuments_EmployeeDocumentId",
                table: "Gives");

            migrationBuilder.DropForeignKey(
                name: "FK_Gives_ExtenstionOFServiceLives_ExtenstionOFServiceLifeId",
                table: "Gives");

            migrationBuilder.DropForeignKey(
                name: "FK_Gives_MilitaryServices_MilitaryServiceId",
                table: "Gives");

            migrationBuilder.DropIndex(
                name: "IX_Gives_DodtGoAbroadId",
                table: "Gives");

            migrationBuilder.DropIndex(
                name: "IX_Gives_ExtenstionOFServiceLifeId",
                table: "Gives");

            migrationBuilder.DropIndex(
                name: "IX_Gives_EmployeeDocumentId",
                table: "Gives");

            migrationBuilder.DropIndex(
                name: "IX_Gives_MilitaryServiceId",
                table: "Gives");

            migrationBuilder.DropIndex(
                name: "IX_ExtenstionOFServiceLives_EmpDocID",
                table: "ExtenstionOFServiceLives");

            migrationBuilder.DropColumn(
                name: "DodtGoAbroadId",
                table: "Gives");

            migrationBuilder.DropColumn(
                name: "EmployeeDocumentId",
                table: "Gives");

            migrationBuilder.DropColumn(
                name: "ExtenstionOFServiceLifeId",
                table: "Gives");

            migrationBuilder.DropColumn(
                name: "MilitaryServiceId",
                table: "Gives");

            migrationBuilder.DropColumn(
                name: "EmpDocID",
                table: "ExtenstionOFServiceLives");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DodtGoAbroadId",
                table: "Gives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeDocumentId",
                table: "Gives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExtenstionOFServiceLifeId",
                table: "Gives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MilitaryServiceId",
                table: "Gives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpDocID",
                table: "ExtenstionOFServiceLives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gives_DodtGoAbroadId",
                table: "Gives",
                column: "DodtGoAbroadId");

            migrationBuilder.CreateIndex(
                name: "IX_Gives_ExtenstionOFServiceLifeId",
                table: "Gives",
                column: "ExtenstionOFServiceLifeId");

            migrationBuilder.CreateIndex(
                name: "IX_Gives_EmployeeDocumentId",
                table: "Gives",
                column: "EmployeeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Gives_MilitaryServiceId",
                table: "Gives",
                column: "MilitaryServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtenstionOFServiceLives_EmpDocID",
                table: "ExtenstionOFServiceLives",
                column: "EmpDocID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtenstionOFServiceLives_EmployeeDocuments_EmpDocID",
                table: "ExtenstionOFServiceLives",
                column: "EmpDocID",
                principalTable: "EmployeeDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gives_DodtGoAbroads_DodtGoAbroadId",
                table: "Gives",
                column: "DodtGoAbroadId",
                principalTable: "DodtGoAbroads",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gives_EmployeeDocuments_EmployeeDocumentId",
                table: "Gives",
                column: "EmployeeDocumentId",
                principalTable: "EmployeeDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gives_ExtenstionOFServiceLives_ExtenstionOFServiceLifeId",
                table: "Gives",
                column: "ExtenstionOFServiceLifeId",
                principalTable: "ExtenstionOFServiceLives",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gives_MilitaryServices_MilitaryServiceId",
                table: "Gives",
                column: "MilitaryServiceId",
                principalTable: "MilitaryServices",
                principalColumn: "Id");
        }
    }
}
