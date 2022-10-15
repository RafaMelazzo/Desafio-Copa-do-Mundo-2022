using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa_do_Mundo_2022.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fases", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "grupos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "partidas_clubes",
                columns: table => new
                {
                    partidas_id = table.Column<int>(type: "int", nullable: false),
                    clubes_id_a = table.Column<int>(type: "int", nullable: false),
                    clubes_id_b = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "partidas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fases_id = table.Column<int>(type: "int", nullable: false),
                    iniciado = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    finalizado = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partidas", x => x.id);
                    table.ForeignKey(
                        name: "FK_partidas_fases_fases_id",
                        column: x => x.fases_id,
                        principalTable: "fases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clubes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    url_bandeira = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grupos_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clubes", x => x.id);
                    table.ForeignKey(
                        name: "FK_clubes_grupos_grupos_id",
                        column: x => x.grupos_id,
                        principalTable: "grupos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estatisticas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    partidas_id = table.Column<int>(type: "int", nullable: false),
                    clubes_id = table.Column<int>(type: "int", nullable: false),
                    chutes = table.Column<int>(type: "int", nullable: true),
                    chutes_a_gol = table.Column<int>(type: "int", nullable: true),
                    posse_de_bola = table.Column<int>(type: "int", nullable: true),
                    passes = table.Column<int>(type: "int", nullable: true),
                    precisao_de_passes = table.Column<int>(type: "int", nullable: true),
                    faltas = table.Column<int>(type: "int", nullable: true),
                    cartoes_amarelos = table.Column<int>(type: "int", nullable: true),
                    cartoes_vermelhos = table.Column<int>(type: "int", nullable: true),
                    impedimentos = table.Column<int>(type: "int", nullable: true),
                    escanteios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estatisticas", x => x.id);
                    table.ForeignKey(
                        name: "FK_estatisticas_clubes_clubes_id",
                        column: x => x.clubes_id,
                        principalTable: "clubes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_estatisticas_partidas_partidas_id",
                        column: x => x.partidas_id,
                        principalTable: "partidas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_clubes_grupos_id",
                table: "clubes",
                column: "grupos_id");

            migrationBuilder.CreateIndex(
                name: "IX_estatisticas_clubes_id",
                table: "estatisticas",
                column: "clubes_id");

            migrationBuilder.CreateIndex(
                name: "IX_estatisticas_partidas_id",
                table: "estatisticas",
                column: "partidas_id");

            migrationBuilder.CreateIndex(
                name: "IX_partidas_fases_id",
                table: "partidas",
                column: "fases_id");

            migrationBuilder.CreateIndex(
                name: "IX_partidas_clubes_partidas_id",
                table: "partidas_clubes",
                column: "partidas_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "estatisticas");

            migrationBuilder.DropTable(
                name: "partidas_clubes");

            migrationBuilder.DropTable(
                name: "clubes");

            migrationBuilder.DropTable(
                name: "partidas");

            migrationBuilder.DropTable(
                name: "grupos");

            migrationBuilder.DropTable(
                name: "fases");
        }
    }
}
