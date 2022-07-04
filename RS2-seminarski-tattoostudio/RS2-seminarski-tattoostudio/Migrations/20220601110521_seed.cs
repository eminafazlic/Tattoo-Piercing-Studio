using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace RS2_seminarski_tattoostudio.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(Directory.GetCurrentDirectory(), "tattoostudio.sql");
            //var sqlFile = "";
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
