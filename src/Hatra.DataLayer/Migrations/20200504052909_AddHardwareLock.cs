using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hatra.DataLayer.Migrations
{
    public partial class AddHardwareLock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HardwareLocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComputerName = table.Column<string>(nullable: true),
                    CpuSerialNumber = table.Column<string>(nullable: true),
                    LockSerialNumber = table.Column<string>(nullable: true),
                    CompanyCount = table.Column<int>(nullable: false),
                    FinancialYearCount = table.Column<int>(nullable: false),
                    DocumentCount = table.Column<int>(nullable: false),
                    UserCount = table.Column<int>(nullable: false),
                    AndroidUserCount = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareLocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardwareLockFinancialYears",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HardwareLockId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    FinancialYearId = table.Column<Guid>(nullable: false),
                    FinancialYearName = table.Column<string>(nullable: true),
                    IsArchive = table.Column<bool>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareLockFinancialYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareLockFinancialYears_HardwareLocks_HardwareLockId",
                        column: x => x.HardwareLockId,
                        principalTable: "HardwareLocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HardwareLockFinancialYears_HardwareLockId",
                table: "HardwareLockFinancialYears",
                column: "HardwareLockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareLockFinancialYears");

            migrationBuilder.DropTable(
                name: "HardwareLocks");
        }
    }
}
