using Microsoft.EntityFrameworkCore.Migrations;

namespace ec.Migrations
{
    public partial class adding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Movies_Movie_Id",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_Movie_Id",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "Movie_Id1",
                table: "People",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_Movie_Id1",
                table: "People",
                column: "Movie_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Movies_Movie_Id1",
                table: "People",
                column: "Movie_Id1",
                principalTable: "Movies",
                principalColumn: "Movie_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Movies_Movie_Id1",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_Movie_Id1",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Movie_Id1",
                table: "People");

            migrationBuilder.CreateIndex(
                name: "IX_People_Movie_Id",
                table: "People",
                column: "Movie_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Movies_Movie_Id",
                table: "People",
                column: "Movie_Id",
                principalTable: "Movies",
                principalColumn: "Movie_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
