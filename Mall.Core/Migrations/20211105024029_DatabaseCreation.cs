using Microsoft.EntityFrameworkCore.Migrations;

namespace Mall.Core.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PmsProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false, comment: "上级分类的编号：0 表示一级分类"),
                    Name = table.Column<string>(type: "varchar(64)", nullable: true, comment: "名称"),
                    Level = table.Column<int>(type: "int", nullable: false, comment: "分类级别： 0->1级；1->2级"),
                    ProductCount = table.Column<int>(type: "int", nullable: false, comment: "商品数量"),
                    ProductUnit = table.Column<string>(type: "varchar(64)", nullable: true, comment: "商品单位"),
                    NavStatus = table.Column<int>(type: "int", nullable: false, comment: "是否显示在导航栏：0->不显示；1->显示"),
                    ShowStatus = table.Column<int>(type: "int", nullable: false, comment: "显示状态：0->不显示；1->显示"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    Icon = table.Column<string>(type: "varchar(255)", nullable: true, comment: "图标"),
                    Keywords = table.Column<string>(type: "varchar(255)", nullable: true, comment: "关键字"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "描述")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PmsProductCategories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PmsProductCategories");
        }
    }
}
