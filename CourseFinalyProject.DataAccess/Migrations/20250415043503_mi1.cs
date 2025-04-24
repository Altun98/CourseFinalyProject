using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFinalyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocDade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTypeID = table.Column<int>(type: "int", nullable: false),
                    GiveID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    RankID = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DocDade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departament = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    GiveID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RankStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RankTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RankGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextTimeRank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOpertaionClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOpertaionClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeDocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentType_EmployeeDocuments_EmployeeDocumentId",
                        column: x => x.EmployeeDocumentId,
                        principalTable: "EmployeeDocuments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExtenstionOFServiceLives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DocDade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiveID = table.Column<int>(type: "int", nullable: false),
                    EmpDocID = table.Column<int>(type: "int", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtenstionOFServiceLives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtenstionOFServiceLives_EmployeeDocuments_EmpDocID",
                        column: x => x.EmpDocID,
                        principalTable: "EmployeeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrancName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiplomaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inventions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicDegrees_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombatOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Territory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Injury = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VeteranCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VeteranCardStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombatOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombatOperations_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conscriptio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DepartamentID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MilitaryOathTakingDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conscriptio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conscriptio_Departaments_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conscriptio_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DodtGoAbroads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DocDade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiveID = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBusinnessTrip = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodtGoAbroads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DodtGoAbroads_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationTypeID = table.Column<int>(type: "int", nullable: false),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ipecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsMilitary = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_EducationTypes_EducationTypeID",
                        column: x => x.EducationTypeID,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Educations_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodID = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_BloodTypes_BloodID",
                        column: x => x.BloodID,
                        principalTable: "BloodTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrutherEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCourse = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrutherEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrutherEducations_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaborActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaborActivity_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMilitaryRank",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    MilitaryRanksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMilitaryRank", x => new { x.EmployeesId, x.MilitaryRanksId });
                    table.ForeignKey(
                        name: "FK_EmployeeMilitaryRank_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeMilitaryRank_MilitaryRanks_MilitaryRanksId",
                        column: x => x.MilitaryRanksId,
                        principalTable: "MilitaryRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountedServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MilitaryServisID = table.Column<int>(type: "int", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coefficent = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountedServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountedServices_MilitaryServices_MilitaryServisID",
                        column: x => x.MilitaryServisID,
                        principalTable: "MilitaryServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMilitaryService",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    MilitaryServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMilitaryService", x => new { x.EmployeesId, x.MilitaryServicesId });
                    table.ForeignKey(
                        name: "FK_EmployeeMilitaryService_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeMilitaryService_MilitaryServices_MilitaryServicesId",
                        column: x => x.MilitaryServicesId,
                        principalTable: "MilitaryServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryRankRankStatus",
                columns: table => new
                {
                    MilitaryRanksId = table.Column<int>(type: "int", nullable: false),
                    RankStatusesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryRankRankStatus", x => new { x.MilitaryRanksId, x.RankStatusesId });
                    table.ForeignKey(
                        name: "FK_MilitaryRankRankStatus_MilitaryRanks_MilitaryRanksId",
                        column: x => x.MilitaryRanksId,
                        principalTable: "MilitaryRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MilitaryRankRankStatus_RankStatuses_RankStatusesId",
                        column: x => x.RankStatusesId,
                        principalTable: "RankStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryRankRankType",
                columns: table => new
                {
                    MilitaryRanksId = table.Column<int>(type: "int", nullable: false),
                    RankTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryRankRankType", x => new { x.MilitaryRanksId, x.RankTypesId });
                    table.ForeignKey(
                        name: "FK_MilitaryRankRankType_MilitaryRanks_MilitaryRanksId",
                        column: x => x.MilitaryRanksId,
                        principalTable: "MilitaryRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MilitaryRankRankType_RankTypes_RankTypesId",
                        column: x => x.RankTypesId,
                        principalTable: "RankTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeExtenstionOFServiceLife",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    ExtenstionOFServiceLivesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeExtenstionOFServiceLife", x => new { x.EmployeesId, x.ExtenstionOFServiceLivesId });
                    table.ForeignKey(
                        name: "FK_EmployeeExtenstionOFServiceLife_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeExtenstionOFServiceLife_ExtenstionOFServiceLives_ExtenstionOFServiceLivesId",
                        column: x => x.ExtenstionOFServiceLivesId,
                        principalTable: "ExtenstionOFServiceLives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiveName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DodtGoAbroadId = table.Column<int>(type: "int", nullable: true),
                    EmployeeDocumentId = table.Column<int>(type: "int", nullable: true),
                    ExtenstionOFServiceLifeId = table.Column<int>(type: "int", nullable: true),
                    MilitaryServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gives_DodtGoAbroads_DodtGoAbroadId",
                        column: x => x.DodtGoAbroadId,
                        principalTable: "DodtGoAbroads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gives_EmployeeDocuments_EmployeeDocumentId",
                        column: x => x.EmployeeDocumentId,
                        principalTable: "EmployeeDocuments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gives_ExtenstionOFServiceLives_ExtenstionOFServiceLifeId",
                        column: x => x.ExtenstionOFServiceLifeId,
                        principalTable: "ExtenstionOFServiceLives",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gives_MilitaryServices_MilitaryServiceId",
                        column: x => x.MilitaryServiceId,
                        principalTable: "MilitaryServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Attestations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DocDade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiveID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attestations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attestations_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attestations_Gives_GiveID",
                        column: x => x.GiveID,
                        principalTable: "Gives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicDegrees_EmployeeID",
                table: "AcademicDegrees",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Attestations_EmployeeID",
                table: "Attestations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Attestations_GiveID",
                table: "Attestations",
                column: "GiveID");

            migrationBuilder.CreateIndex(
                name: "IX_CombatOperations_EmployeeID",
                table: "CombatOperations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Conscriptio_DepartamentID",
                table: "Conscriptio",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Conscriptio_EmployeeID",
                table: "Conscriptio",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiscountedServices_MilitaryServisID",
                table: "DiscountedServices",
                column: "MilitaryServisID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentType_EmployeeDocumentId",
                table: "DocumentType",
                column: "EmployeeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DodtGoAbroads_EmployeeID",
                table: "DodtGoAbroads",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EducationTypeID",
                table: "Educations",
                column: "EducationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EmployeeID",
                table: "Educations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtenstionOFServiceLives_EmpDocID",
                table: "ExtenstionOFServiceLives",
                column: "EmpDocID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeExtenstionOFServiceLife_ExtenstionOFServiceLivesId",
                table: "EmployeeExtenstionOFServiceLife",
                column: "ExtenstionOFServiceLivesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_BloodID",
                table: "EmployeeInfo",
                column: "BloodID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_EmployeeID",
                table: "EmployeeInfo",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMilitaryRank_MilitaryRanksId",
                table: "EmployeeMilitaryRank",
                column: "MilitaryRanksId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMilitaryService_MilitaryServicesId",
                table: "EmployeeMilitaryService",
                column: "MilitaryServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_FrutherEducations_EmployeeID",
                table: "FrutherEducations",
                column: "EmployeeID");

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
                name: "IX_LaborActivity_EmployeeID",
                table: "LaborActivity",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryRankRankStatus_RankStatusesId",
                table: "MilitaryRankRankStatus",
                column: "RankStatusesId");

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryRankRankType_RankTypesId",
                table: "MilitaryRankRankType",
                column: "RankTypesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicDegrees");

            migrationBuilder.DropTable(
                name: "Attestations");

            migrationBuilder.DropTable(
                name: "CombatOperations");

            migrationBuilder.DropTable(
                name: "Conscriptio");

            migrationBuilder.DropTable(
                name: "DiscountedServices");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmployeeExtenstionOFServiceLife");

            migrationBuilder.DropTable(
                name: "EmployeeInfo");

            migrationBuilder.DropTable(
                name: "EmployeeMilitaryRank");

            migrationBuilder.DropTable(
                name: "EmployeeMilitaryService");

            migrationBuilder.DropTable(
                name: "FrutherEducations");

            migrationBuilder.DropTable(
                name: "LaborActivity");

            migrationBuilder.DropTable(
                name: "MilitaryRankRankStatus");

            migrationBuilder.DropTable(
                name: "MilitaryRankRankType");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOpertaionClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Gives");

            migrationBuilder.DropTable(
                name: "Departaments");

            migrationBuilder.DropTable(
                name: "EducationTypes");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "RankStatuses");

            migrationBuilder.DropTable(
                name: "MilitaryRanks");

            migrationBuilder.DropTable(
                name: "RankTypes");

            migrationBuilder.DropTable(
                name: "DodtGoAbroads");

            migrationBuilder.DropTable(
                name: "ExtenstionOFServiceLives");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeDocuments");
        }
    }
}
