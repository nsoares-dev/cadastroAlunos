using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroAlunos.Migrations
{
    /// <inheritdoc />
    public partial class DBAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefoneAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAluno = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunosId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
