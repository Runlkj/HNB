using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicNB.Migrations
{
    public partial class NB21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfficeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    KName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    HName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    GDanhao = table.Column<string>(nullable: true),
                    KeShi = table.Column<int>(nullable: false),
                    LType = table.Column<string>(nullable: true),
                    Doctor = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    GDate = table.Column<DateTime>(nullable: false),
                    GuaName = table.Column<string>(nullable: true),
                    GName = table.Column<string>(nullable: true),
                    GNum = table.Column<string>(nullable: true),
                    GAge = table.Column<int>(nullable: false),
                    GBirthday = table.Column<DateTime>(nullable: false),
                    GSex = table.Column<string>(nullable: true),
                    GTel = table.Column<string>(nullable: true),
                    GZheng = table.Column<string>(nullable: true),
                    GXiang = table.Column<string>(nullable: true),
                    GZhen = table.Column<string>(nullable: true),
                    GYizhu = table.Column<string>(nullable: true),
                    Yid = table.Column<int>(nullable: false),
                    Zhuang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeInfo");

            migrationBuilder.DropTable(
                name: "PriceInfo");

            migrationBuilder.DropTable(
                name: "ProInfo");

            migrationBuilder.DropTable(
                name: "RegInfo");
        }
    }
}
