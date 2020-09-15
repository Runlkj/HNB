using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicNB.Migrations
{
    public partial class NB9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "yaoPinKuCun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    YaoBianma = table.Column<string>(maxLength: 30, nullable: true),
                    YaoName = table.Column<string>(maxLength: 30, nullable: true),
                    YaoTyPeID = table.Column<int>(nullable: false),
                    YaoChang = table.Column<string>(nullable: true),
                    YaoKucun = table.Column<int>(nullable: false),
                    YaoPrice = table.Column<int>(nullable: false),
                    YaoGuige = table.Column<string>(maxLength: 30, nullable: true),
                    YaoZt = table.Column<int>(nullable: false),
                    YaoTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yaoPinKuCun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "yaoPinRuku",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Yaoruku = table.Column<string>(maxLength: 30, nullable: true),
                    YaorukuTime = table.Column<DateTime>(nullable: false),
                    YaorukurenID = table.Column<int>(nullable: false),
                    Yaogys = table.Column<string>(maxLength: 30, nullable: true),
                    YaozhidanTime = table.Column<DateTime>(nullable: false),
                    YaoBeizhu = table.Column<string>(maxLength: 30, nullable: true),
                    YaopinId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yaoPinRuku", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "yaoType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    TypeName = table.Column<string>(maxLength: 30, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yaoType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "yaoPinKuCun");

            migrationBuilder.DropTable(
                name: "yaoPinRuku");

            migrationBuilder.DropTable(
                name: "yaoType");
        }
    }
}
