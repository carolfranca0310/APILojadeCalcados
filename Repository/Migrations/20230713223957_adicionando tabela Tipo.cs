using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class adicionandotabelaTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Produtos",
                newName: "TipoId");

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_TipoId",
                table: "Produtos",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Tipos_TipoId",
                table: "Produtos",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("insert into Tipos (TipoNome) values('Sandália')");
            migrationBuilder.Sql("insert into Tipos (TipoNome) values('Sapatilha')");
            migrationBuilder.Sql("insert into Tipos (TipoNome) values('Sapato')");
            migrationBuilder.Sql("insert into Tipos (TipoNome) values('Tênis')");
            migrationBuilder.Sql("insert into Tipos (TipoNome) values('Rasteirinha')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Tipos_TipoId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_TipoId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "TipoId",
                table: "Produtos",
                newName: "Tipo");
        }
    }
}
