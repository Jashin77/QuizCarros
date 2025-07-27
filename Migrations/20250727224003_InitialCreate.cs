using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizCarros.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perguntas",
                columns: table => new
                {
                    PerguntasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Enunciado = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Alternativa1 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Alternativa2 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Alternativa3 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Alternativa4 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    RespostaCorreta = table.Column<int>(type: "INTEGER", nullable: false),
                    ImagemUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perguntas", x => x.PerguntasId);
                });

            migrationBuilder.Sql("INSERT INTO perguntas (Enunciado, Alternativa1, Alternativa2, Alternativa3, Alternativa4, RespostaCorreta, ImagemUrl) VALUES " +
                "('Qual foi o primeiro carro produzido em massa?', 'Ford Model T', 'Chevrolet Bel Air', 'Volkswagen Fusca', 'Fiat Uno', 0, '/img/baixados.jpeg')," +
                "('De qual país é a origem da marca Ferrari?', 'Alemanha', 'Itália', 'França', 'Reino Unido', 1, '/img/Branding Fun_ Ferrari http___marketingisnotselling_com_branding-fun-ferrari_.jpeg')," +
                "('Quantos campeonatos de Formula 1 o piloto Ayrton Senna conquistou?', '1', '2', '3', '4', 2, '/img/baixados (1).jpeg')," +
                "('Qual fabricante é responsável pelo icônico modelo Mustang?', 'Chevrolet', 'Dodge', 'Ford', 'Toyota', 2, '/img/Classic Ford Mustang in the Wild.jpeg')," +
                "('Qual desses modelos é considerado o carro símbulo da Porsche?', 'Porsche 911', 'Porsche Macan', 'Porsche Boxter', 'Porsche Panamera', 0, '/img/911.jpeg')," +
                "('Qual desses modelos é um ícone dos carros esportivos italianos?', 'Ferrari F40', 'Ford Mustang', 'Chevrolet Camaro', 'Nissan GT-R', 0, '/img/Bandiera della Repubblica italiana _ Vettore Premium.jpeg')," +
                "('Em que ano foi fundada a Porsche?', '1931', '1948', '1920', '1955', 0, '/img/baixados (2).jpeg')," +
                "('Qual a principal função de um radiador em um automóvel?', 'Armazenar combustivel', 'Resfriar o motor', 'Aumentar a potência', 'Lubrificar as peças do motor', 1, '/img/Ventoinha do radiador não funciona_ Saiba o que fazer.jpeg')," +
                "('Qual a função de um turbo compressor em um automovél?', 'Resfriar o motor', 'Aumentar a potência, colocando mais ar dentro do motor', 'Reduzir o consumo de combustível', 'Controlar a ignição', 1, '/img/@branddiee __ Precision Turbo.jpeg')," +
                "('Qual corrida tradicional do automobilismo é conhecida pela sua longa duração?', '24 horas de Le Mans', 'grande prêmio de mônaco', 'indianapolis 500', '500 milhas de Daytona', 0, '/img/baixados (3).jpeg');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perguntas");
        }
    }
}

