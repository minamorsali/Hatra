using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hatra.DataLayer.Migrations
{
    public partial class AddFiledsToHardwareLock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LockSerialNumber",
                table: "HardwareLocks",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CpuSerialNumber",
                table: "HardwareLocks",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComputerName",
                table: "HardwareLocks",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentVersion",
                table: "HardwareLocks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "HardwareLocks",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "HardwareLocks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "HardwareLocks",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FinancialYearName",
                table: "HardwareLockFinancialYears",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "HardwareLockFinancialYears",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentVersion",
                table: "HardwareLocks");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "HardwareLocks");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "HardwareLocks");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "HardwareLocks");

            migrationBuilder.AlterColumn<string>(
                name: "LockSerialNumber",
                table: "HardwareLocks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CpuSerialNumber",
                table: "HardwareLocks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComputerName",
                table: "HardwareLocks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "FinancialYearName",
                table: "HardwareLockFinancialYears",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "HardwareLockFinancialYears",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
