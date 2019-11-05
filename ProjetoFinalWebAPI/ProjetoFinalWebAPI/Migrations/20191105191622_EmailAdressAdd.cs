using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalWebAPI.Migrations
{
    public partial class EmailAdressAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Senha = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
