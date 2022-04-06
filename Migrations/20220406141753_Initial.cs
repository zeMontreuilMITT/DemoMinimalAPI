using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "char(35)", unicode: false, fixedLength: true, maxLength: 35, nullable: false, defaultValueSql: "('')"),
                    CountryCode = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    District = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Population = table.Column<int>(type: "int", nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    Name = table.Column<string>(type: "char(52)", unicode: false, fixedLength: true, maxLength: 52, nullable: false, defaultValueSql: "('')"),
                    Continent = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('Asia')"),
                    Region = table.Column<string>(type: "char(26)", unicode: false, fixedLength: true, maxLength: 26, nullable: false, defaultValueSql: "('')"),
                    SurfaceArea = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValueSql: "('0.00')"),
                    IndepYear = table.Column<short>(type: "smallint", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: false, defaultValueSql: "('0')"),
                    LifeExpectancy = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    GNP = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    GNPOld = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    LocalName = table.Column<string>(type: "char(45)", unicode: false, fixedLength: true, maxLength: 45, nullable: false, defaultValueSql: "('')"),
                    GovernmentForm = table.Column<string>(type: "char(45)", unicode: false, fixedLength: true, maxLength: 45, nullable: false, defaultValueSql: "('')"),
                    HeadOfState = table.Column<string>(type: "char(60)", unicode: false, fixedLength: true, maxLength: 60, nullable: true),
                    Capital = table.Column<int>(type: "int", nullable: true),
                    Code2 = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__country__A25C5AA6F1A7F7FD", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "countrylanguage",
                columns: table => new
                {
                    CountryCode = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false, defaultValueSql: "('')"),
                    Language = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    IsOfficial = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('F')"),
                    Percentage = table.Column<decimal>(type: "decimal(4,1)", nullable: false, defaultValueSql: "('0.0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__countryl__51A654086D9E467C", x => new { x.CountryCode, x.Language });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "countrylanguage");
        }
    }
}
