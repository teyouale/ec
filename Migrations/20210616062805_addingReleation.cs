using Microsoft.EntityFrameworkCore.Migrations;

namespace ec.Migrations
{
    public partial class addingReleation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Peoople_Id",
                table: "People",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Movie_Id",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Movie_Id",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Peoople_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Movie_Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Movies_Movie_Id",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_Movie_Id",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Peoople_Id",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Movie_Id",
                table: "People");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Movie_Id",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
