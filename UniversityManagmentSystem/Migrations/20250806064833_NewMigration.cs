using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLO_LearningLevel_LearningLevelId",
                table: "CLO");

            migrationBuilder.DropForeignKey(
                name: "FK_CLO_LearningType_LearningTypeId",
                table: "CLO");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOToSubject_CLO_CLOId",
                table: "CLOToSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOToSubject_ProgramSessions_ProgramSessionId",
                table: "CLOToSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOToSubject_Subjects_SubjectId",
                table: "CLOToSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_PEO_DegreeProgram_DegreeProgramId",
                table: "PEO");

            migrationBuilder.DropForeignKey(
                name: "FK_PEOToPLO_PEO_PEOId",
                table: "PEOToPLO");

            migrationBuilder.DropForeignKey(
                name: "FK_PEOToPLO_PLO_PLOId",
                table: "PEOToPLO");

            migrationBuilder.DropForeignKey(
                name: "FK_PLO_DegreeProgram_DegreeProgramId",
                table: "PLO");

            migrationBuilder.DropForeignKey(
                name: "FK_PLOToCLO_CLO_CLOId",
                table: "PLOToCLO");

            migrationBuilder.DropForeignKey(
                name: "FK_PLOToCLO_PLO_PLOId",
                table: "PLOToCLO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLOToCLO",
                table: "PLOToCLO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLO",
                table: "PLO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PEOToPLO",
                table: "PEOToPLO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PEO",
                table: "PEO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LearningType",
                table: "LearningType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LearningLevel",
                table: "LearningLevel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLOToSubject",
                table: "CLOToSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLO",
                table: "CLO");

            migrationBuilder.RenameTable(
                name: "PLOToCLO",
                newName: "PLOToCLOs");

            migrationBuilder.RenameTable(
                name: "PLO",
                newName: "PLOs");

            migrationBuilder.RenameTable(
                name: "PEOToPLO",
                newName: "PEOToPLOs");

            migrationBuilder.RenameTable(
                name: "PEO",
                newName: "PEOs");

            migrationBuilder.RenameTable(
                name: "LearningType",
                newName: "LearningTypes");

            migrationBuilder.RenameTable(
                name: "LearningLevel",
                newName: "LearningLevels");

            migrationBuilder.RenameTable(
                name: "CLOToSubject",
                newName: "CLOToSubjects");

            migrationBuilder.RenameTable(
                name: "CLO",
                newName: "CLOs");

            migrationBuilder.RenameIndex(
                name: "IX_PLOToCLO_PLOId",
                table: "PLOToCLOs",
                newName: "IX_PLOToCLOs_PLOId");

            migrationBuilder.RenameIndex(
                name: "IX_PLOToCLO_CLOId",
                table: "PLOToCLOs",
                newName: "IX_PLOToCLOs_CLOId");

            migrationBuilder.RenameIndex(
                name: "IX_PLO_DegreeProgramId",
                table: "PLOs",
                newName: "IX_PLOs_DegreeProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_PEOToPLO_PLOId",
                table: "PEOToPLOs",
                newName: "IX_PEOToPLOs_PLOId");

            migrationBuilder.RenameIndex(
                name: "IX_PEOToPLO_PEOId",
                table: "PEOToPLOs",
                newName: "IX_PEOToPLOs_PEOId");

            migrationBuilder.RenameIndex(
                name: "IX_PEO_DegreeProgramId",
                table: "PEOs",
                newName: "IX_PEOs_DegreeProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOToSubject_SubjectId",
                table: "CLOToSubjects",
                newName: "IX_CLOToSubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOToSubject_ProgramSessionId",
                table: "CLOToSubjects",
                newName: "IX_CLOToSubjects_ProgramSessionId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOToSubject_CLOId",
                table: "CLOToSubjects",
                newName: "IX_CLOToSubjects_CLOId");

            migrationBuilder.RenameIndex(
                name: "IX_CLO_LearningTypeId",
                table: "CLOs",
                newName: "IX_CLOs_LearningTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CLO_LearningLevelId",
                table: "CLOs",
                newName: "IX_CLOs_LearningLevelId");

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "University",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "University",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "University",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "SubjectTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "SubjectTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "SubjectTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "StructureUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "StructureUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "StructureUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "StructureTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "StructureTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "StructureTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "StructureDesignations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "StructureDesignations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "StructureDesignations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Semesters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Semesters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Semesters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "RoomTypesAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "RoomTypesAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "RoomTypesAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "RoomFeaturesAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "RoomFeaturesAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "RoomFeaturesAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "RoomFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "RoomFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "RoomFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "ProgramSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "ProgramSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "ProgramSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Institutes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Institutes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Institutes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "FacultyCampuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "FacultyCampuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "FacultyCampuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Faculty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Faculty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Faculty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "DegreeProgram",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "DegreeProgram",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "DegreeProgram",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "DegreeLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "DegreeLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "DegreeLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "CourseSchemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "CourseSchemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "CourseSchemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Campuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Campuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Campuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "Blocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "Blocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "Blocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "PLOToCLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "PLOToCLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "PLOToCLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "PLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "PLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "PLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "PEOToPLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "PEOToPLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "PEOToPLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "PEOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "PEOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "PEOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "LearningTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "LearningTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "LearningTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "LearningLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "LearningLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "LearningLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "CLOToSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "CLOToSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "CLOToSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOn",
                table: "CLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedOn",
                table: "CLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedOn",
                table: "CLOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLOToCLOs",
                table: "PLOToCLOs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLOs",
                table: "PLOs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PEOToPLOs",
                table: "PEOToPLOs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PEOs",
                table: "PEOs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LearningTypes",
                table: "LearningTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LearningLevels",
                table: "LearningLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLOToSubjects",
                table: "CLOToSubjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLOs",
                table: "CLOs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UiUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UiPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GlobalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRightCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GlobalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GlobalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRightAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRightId = table.Column<int>(type: "int", nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GlobalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRightAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRightAllocations_UserRights_UserRightId",
                        column: x => x.UserRightId,
                        principalTable: "UserRights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRightAllocations_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTypeAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    UserInfoId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GlobalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypeAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTypeAllocations_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTypeAllocations_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRightAllocations_UserRightId",
                table: "UserRightAllocations",
                column: "UserRightId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRightAllocations_UserTypeId",
                table: "UserRightAllocations",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypeAllocations_UserInfoId",
                table: "UserTypeAllocations",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypeAllocations_UserTypeId",
                table: "UserTypeAllocations",
                column: "UserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLOs_LearningLevels_LearningLevelId",
                table: "CLOs",
                column: "LearningLevelId",
                principalTable: "LearningLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOs_LearningTypes_LearningTypeId",
                table: "CLOs",
                column: "LearningTypeId",
                principalTable: "LearningTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOToSubjects_CLOs_CLOId",
                table: "CLOToSubjects",
                column: "CLOId",
                principalTable: "CLOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOToSubjects_ProgramSessions_ProgramSessionId",
                table: "CLOToSubjects",
                column: "ProgramSessionId",
                principalTable: "ProgramSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOToSubjects_Subjects_SubjectId",
                table: "CLOToSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PEOs_DegreeProgram_DegreeProgramId",
                table: "PEOs",
                column: "DegreeProgramId",
                principalTable: "DegreeProgram",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PEOToPLOs_PEOs_PEOId",
                table: "PEOToPLOs",
                column: "PEOId",
                principalTable: "PEOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PEOToPLOs_PLOs_PLOId",
                table: "PEOToPLOs",
                column: "PLOId",
                principalTable: "PLOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLOs_DegreeProgram_DegreeProgramId",
                table: "PLOs",
                column: "DegreeProgramId",
                principalTable: "DegreeProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLOToCLOs_CLOs_CLOId",
                table: "PLOToCLOs",
                column: "CLOId",
                principalTable: "CLOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLOToCLOs_PLOs_PLOId",
                table: "PLOToCLOs",
                column: "PLOId",
                principalTable: "PLOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLOs_LearningLevels_LearningLevelId",
                table: "CLOs");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOs_LearningTypes_LearningTypeId",
                table: "CLOs");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOToSubjects_CLOs_CLOId",
                table: "CLOToSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOToSubjects_ProgramSessions_ProgramSessionId",
                table: "CLOToSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOToSubjects_Subjects_SubjectId",
                table: "CLOToSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_PEOs_DegreeProgram_DegreeProgramId",
                table: "PEOs");

            migrationBuilder.DropForeignKey(
                name: "FK_PEOToPLOs_PEOs_PEOId",
                table: "PEOToPLOs");

            migrationBuilder.DropForeignKey(
                name: "FK_PEOToPLOs_PLOs_PLOId",
                table: "PEOToPLOs");

            migrationBuilder.DropForeignKey(
                name: "FK_PLOs_DegreeProgram_DegreeProgramId",
                table: "PLOs");

            migrationBuilder.DropForeignKey(
                name: "FK_PLOToCLOs_CLOs_CLOId",
                table: "PLOToCLOs");

            migrationBuilder.DropForeignKey(
                name: "FK_PLOToCLOs_PLOs_PLOId",
                table: "PLOToCLOs");

            migrationBuilder.DropTable(
                name: "UserRightAllocations");

            migrationBuilder.DropTable(
                name: "UserTypeAllocations");

            migrationBuilder.DropTable(
                name: "UserRights");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLOToCLOs",
                table: "PLOToCLOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLOs",
                table: "PLOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PEOToPLOs",
                table: "PEOToPLOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PEOs",
                table: "PEOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LearningTypes",
                table: "LearningTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LearningLevels",
                table: "LearningLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLOToSubjects",
                table: "CLOToSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLOs",
                table: "CLOs");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "University");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "University");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "University");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SubjectTypes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "SubjectTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "SubjectTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "StructureUnits");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "StructureUnits");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "StructureUnits");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "StructureTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "StructureDesignations");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "StructureDesignations");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "StructureDesignations");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RoomTypesAllocation");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "RoomTypesAllocation");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "RoomTypesAllocation");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RoomFeaturesAllocation");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "RoomFeaturesAllocation");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "RoomFeaturesAllocation");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RoomFeatures");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "RoomFeatures");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "RoomFeatures");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ProgramSessions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ProgramSessions");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "ProgramSessions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Institutes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Institutes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Institutes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FacultyCampuses");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FacultyCampuses");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "FacultyCampuses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DegreeProgram");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "DegreeProgram");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "DegreeProgram");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DegreeLevels");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "DegreeLevels");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "DegreeLevels");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CourseSchemes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CourseSchemes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "CourseSchemes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Campuses");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Campuses");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Campuses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PLOToCLOs");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "PLOToCLOs");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "PLOToCLOs");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PLOs");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "PLOs");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "PLOs");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PEOToPLOs");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "PEOToPLOs");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "PEOToPLOs");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PEOs");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "PEOs");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "PEOs");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "LearningTypes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "LearningTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "LearningTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "LearningLevels");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "LearningLevels");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "LearningLevels");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CLOToSubjects");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CLOToSubjects");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "CLOToSubjects");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CLOs");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CLOs");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "CLOs");

            migrationBuilder.RenameTable(
                name: "PLOToCLOs",
                newName: "PLOToCLO");

            migrationBuilder.RenameTable(
                name: "PLOs",
                newName: "PLO");

            migrationBuilder.RenameTable(
                name: "PEOToPLOs",
                newName: "PEOToPLO");

            migrationBuilder.RenameTable(
                name: "PEOs",
                newName: "PEO");

            migrationBuilder.RenameTable(
                name: "LearningTypes",
                newName: "LearningType");

            migrationBuilder.RenameTable(
                name: "LearningLevels",
                newName: "LearningLevel");

            migrationBuilder.RenameTable(
                name: "CLOToSubjects",
                newName: "CLOToSubject");

            migrationBuilder.RenameTable(
                name: "CLOs",
                newName: "CLO");

            migrationBuilder.RenameIndex(
                name: "IX_PLOToCLOs_PLOId",
                table: "PLOToCLO",
                newName: "IX_PLOToCLO_PLOId");

            migrationBuilder.RenameIndex(
                name: "IX_PLOToCLOs_CLOId",
                table: "PLOToCLO",
                newName: "IX_PLOToCLO_CLOId");

            migrationBuilder.RenameIndex(
                name: "IX_PLOs_DegreeProgramId",
                table: "PLO",
                newName: "IX_PLO_DegreeProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_PEOToPLOs_PLOId",
                table: "PEOToPLO",
                newName: "IX_PEOToPLO_PLOId");

            migrationBuilder.RenameIndex(
                name: "IX_PEOToPLOs_PEOId",
                table: "PEOToPLO",
                newName: "IX_PEOToPLO_PEOId");

            migrationBuilder.RenameIndex(
                name: "IX_PEOs_DegreeProgramId",
                table: "PEO",
                newName: "IX_PEO_DegreeProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOToSubjects_SubjectId",
                table: "CLOToSubject",
                newName: "IX_CLOToSubject_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOToSubjects_ProgramSessionId",
                table: "CLOToSubject",
                newName: "IX_CLOToSubject_ProgramSessionId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOToSubjects_CLOId",
                table: "CLOToSubject",
                newName: "IX_CLOToSubject_CLOId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOs_LearningTypeId",
                table: "CLO",
                newName: "IX_CLO_LearningTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CLOs_LearningLevelId",
                table: "CLO",
                newName: "IX_CLO_LearningLevelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLOToCLO",
                table: "PLOToCLO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLO",
                table: "PLO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PEOToPLO",
                table: "PEOToPLO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PEO",
                table: "PEO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LearningType",
                table: "LearningType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LearningLevel",
                table: "LearningLevel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLOToSubject",
                table: "CLOToSubject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLO",
                table: "CLO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CLO_LearningLevel_LearningLevelId",
                table: "CLO",
                column: "LearningLevelId",
                principalTable: "LearningLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLO_LearningType_LearningTypeId",
                table: "CLO",
                column: "LearningTypeId",
                principalTable: "LearningType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOToSubject_CLO_CLOId",
                table: "CLOToSubject",
                column: "CLOId",
                principalTable: "CLO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOToSubject_ProgramSessions_ProgramSessionId",
                table: "CLOToSubject",
                column: "ProgramSessionId",
                principalTable: "ProgramSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOToSubject_Subjects_SubjectId",
                table: "CLOToSubject",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PEO_DegreeProgram_DegreeProgramId",
                table: "PEO",
                column: "DegreeProgramId",
                principalTable: "DegreeProgram",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PEOToPLO_PEO_PEOId",
                table: "PEOToPLO",
                column: "PEOId",
                principalTable: "PEO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PEOToPLO_PLO_PLOId",
                table: "PEOToPLO",
                column: "PLOId",
                principalTable: "PLO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLO_DegreeProgram_DegreeProgramId",
                table: "PLO",
                column: "DegreeProgramId",
                principalTable: "DegreeProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLOToCLO_CLO_CLOId",
                table: "PLOToCLO",
                column: "CLOId",
                principalTable: "CLO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLOToCLO_PLO_PLOId",
                table: "PLOToCLO",
                column: "PLOId",
                principalTable: "PLO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
