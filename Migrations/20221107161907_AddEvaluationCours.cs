using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mock_signets.Migrations
{
    public partial class AddEvaluationCours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvaluationCours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sigle = table.Column<string>(type: "TEXT", nullable: false),
                    Groupe = table.Column<string>(type: "TEXT", nullable: false),
                    Enseignant = table.Column<string>(type: "TEXT", nullable: false),
                    CodeProf = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CodeEtudiant = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TypeEvaluation = table.Column<string>(type: "TEXT", nullable: false),
                    EstComplete = table.Column<bool>(type: "INTEGER", nullable: false),
                    userId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationCours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationCours_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationCours_userId",
                table: "EvaluationCours",
                column: "userId");


            //John doe test user (main user for testing)
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "CodeAccesUniversel", "MotPasse", "Nom", "Prenom", "CodePermanent", "SoldeTotal", "Masculin" },
                values: new object[] { "ZZ00001", "test", "Doe", "John", "DOEJ00112305", "0.00", true });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluationCours");
        }
    }
}
