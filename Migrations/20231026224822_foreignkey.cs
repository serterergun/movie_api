using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace imdb_api.Migrations
{
    /// <inheritdoc />
    public partial class foreignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Casts_MovieId",
                table: "Casts",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Casts_PersonId",
                table: "Casts",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Casts_Movies_MovieId",
                table: "Casts",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Casts_People_PersonId",
                table: "Casts",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casts_Movies_MovieId",
                table: "Casts");

            migrationBuilder.DropForeignKey(
                name: "FK_Casts_People_PersonId",
                table: "Casts");

            migrationBuilder.DropIndex(
                name: "IX_Casts_MovieId",
                table: "Casts");

            migrationBuilder.DropIndex(
                name: "IX_Casts_PersonId",
                table: "Casts");
        }
    }
}
