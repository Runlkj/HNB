using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicNB.Migrations
{
    public partial class NB30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeptInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Dname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EjrInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Eid = table.Column<int>(nullable: false),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    JobName = table.Column<int>(nullable: false),
                    Rid = table.Column<int>(nullable: false),
                    Rname = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjrInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    DeptId = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployJob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Eid = table.Column<int>(nullable: false),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    JobName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployJob", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Eid = table.Column<int>(nullable: false),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false),
                    Rid = table.Column<int>(nullable: false),
                    Rname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    JobName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    JobId = table.Column<int>(nullable: false),
                    JobName = table.Column<string>(nullable: true),
                    Rid = table.Column<int>(nullable: false),
                    Rname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Rname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeptInfo");

            migrationBuilder.DropTable(
                name: "EjrInfo");

            migrationBuilder.DropTable(
                name: "EmployInfo");

            migrationBuilder.DropTable(
                name: "EmployJob");

            migrationBuilder.DropTable(
                name: "EmployRole");

            migrationBuilder.DropTable(
                name: "JobInfo");

            migrationBuilder.DropTable(
                name: "JobRole");

            migrationBuilder.DropTable(
                name: "RoleInfo");
        }
    }
}
