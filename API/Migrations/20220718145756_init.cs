using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Legend = table.Column<string>(type: "varchar(250)", nullable: false),
                    Author = table.Column<string>(type: "varchar(250)", nullable: false),
                    Tags = table.Column<string>(type: "varchar(250)", nullable: false),
                    Thumb = table.Column<string>(type: "varchar(250)", nullable: false),
                    GalleryImages = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "varchar(250)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Hat = table.Column<string>(type: "varchar(80)", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Text = table.Column<string>(type: "varchar(255)", nullable: false),
                    Author = table.Column<string>(type: "varchar(80)", nullable: false),
                    Img = table.Column<string>(type: "varchar(255)", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "varchar(255)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Hat = table.Column<string>(type: "varchar(250)", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Author = table.Column<string>(type: "varchar(250)", nullable: false),
                    Thumbnail = table.Column<string>(type: "varchar(250)", nullable: false),
                    UrlVideo = table.Column<string>(type: "varchar(250)", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "varchar(250)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Video");
        }
    }
}
