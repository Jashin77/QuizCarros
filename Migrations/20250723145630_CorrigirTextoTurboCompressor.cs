using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizCarros.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirTextoTurboCompressor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               "UPDATE perguntas " +
               "SET Alternativa2 = 'Aumentar a potência, colocando mais ar dentro do motor' " +
               "WHERE Enunciado = 'Qual a função de um turbo compressor em um automovél?'");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "UPDATE perguntas " +
                "SET Alternativa2 = 'Aumentar a potência,colocando mair ar dentro do motor' " +
                "WHERE Enunciado = 'Qual a função de um turbo compressor em um automovél?'");
        }
    }
}
