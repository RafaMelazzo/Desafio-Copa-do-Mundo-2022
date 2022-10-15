using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa_do_Mundo_2022.Migrations
{
    public partial class PartidasClubesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubeAId",
                table: "partidas_clubes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClubeBId",
                table: "partidas_clubes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_partidas_clubes_ClubeAId",
                table: "partidas_clubes",
                column: "ClubeAId");

            migrationBuilder.CreateIndex(
                name: "IX_partidas_clubes_ClubeBId",
                table: "partidas_clubes",
                column: "ClubeBId");

            migrationBuilder.AddForeignKey(
                name: "FK_partidas_clubes_clubes_ClubeAId",
                table: "partidas_clubes",
                column: "ClubeAId",
                principalTable: "clubes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_partidas_clubes_clubes_ClubeBId",
                table: "partidas_clubes",
                column: "ClubeBId",
                principalTable: "clubes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_partidas_clubes_partidas_partidas_id",
                table: "partidas_clubes",
                column: "partidas_id",
                principalTable: "partidas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_partidas_clubes_clubes_ClubeAId",
                table: "partidas_clubes");

            migrationBuilder.DropForeignKey(
                name: "FK_partidas_clubes_clubes_ClubeBId",
                table: "partidas_clubes");

            migrationBuilder.DropForeignKey(
                name: "FK_partidas_clubes_partidas_partidas_id",
                table: "partidas_clubes");

            migrationBuilder.DropIndex(
                name: "IX_partidas_clubes_ClubeAId",
                table: "partidas_clubes");

            migrationBuilder.DropIndex(
                name: "IX_partidas_clubes_ClubeBId",
                table: "partidas_clubes");

            migrationBuilder.DropColumn(
                name: "ClubeAId",
                table: "partidas_clubes");

            migrationBuilder.DropColumn(
                name: "ClubeBId",
                table: "partidas_clubes");
        }
    }
}
