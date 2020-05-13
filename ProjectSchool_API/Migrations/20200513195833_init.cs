using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSchool_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataNasc = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Alunos_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "ID", "Nome" },
                values: new object[] { 1, "Daniel" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "ID", "Nome" },
                values: new object[] { 2, "Vinicius" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "ID", "Nome" },
                values: new object[] { 3, "Paula" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "ID", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 1, "01/01/2000", "Maria", 1, "José" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "ID", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 2, "20/01/1990", "João", 2, "Paulo" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "ID", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 3, "25/06/1981", "Alex", 3, "Feraz" });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ProfessorId",
                table: "Alunos",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
