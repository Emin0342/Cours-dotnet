using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjoutBibliothequeBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BibliothequeBook",
                columns: table => new
                {
                    BibliothequeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BibliothequeId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibliothequeBook", x => x.BibliothequeId);
                    table.ForeignKey(
                        name: "FK_BibliothequeBook_Bibliotheque_BibliothequeId1",
                        column: x => x.BibliothequeId1,
                        principalTable: "Bibliotheque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BibliothequeBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BibliothequeBook_BibliothequeId1",
                table: "BibliothequeBook",
                column: "BibliothequeId1");

            migrationBuilder.CreateIndex(
                name: "IX_BibliothequeBook_BookId",
                table: "BibliothequeBook",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BibliothequeBook");
        }
    }
}
