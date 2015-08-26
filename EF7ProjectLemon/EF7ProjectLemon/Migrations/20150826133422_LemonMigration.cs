using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace EF7ProjectLemonMigrations
{
    public partial class LemonMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Auth",
                columns: table => new
                {
                    AuthId = table.Column(type: "INTEGER", nullable: false) ,
                    Login = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.AuthId);
                });
            migration.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column(type: "INTEGER", nullable: false) ,
                    Name = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Auth");
            migration.DropTable("Person");
        }
    }
}
