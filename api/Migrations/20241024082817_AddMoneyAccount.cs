using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddMoneyAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionAccounts",
                table: "TransactionAccounts");

            migrationBuilder.RenameTable(
                name: "TransactionAccounts",
                newName: "MoneyAccounts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndGoalDate",
                table: "FinanceGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfMoneyAccount",
                table: "MoneyAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoneyAccounts",
                table: "MoneyAccounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MoneyAccountUser",
                columns: table => new
                {
                    MoneyAccountsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyAccountUser", x => new { x.MoneyAccountsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MoneyAccountUser_MoneyAccounts_MoneyAccountsId",
                        column: x => x.MoneyAccountsId,
                        principalTable: "MoneyAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoneyAccountUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoneyAccountUser_UsersId",
                table: "MoneyAccountUser",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneyAccountUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoneyAccounts",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "TypeOfMoneyAccount",
                table: "MoneyAccounts");

            migrationBuilder.RenameTable(
                name: "MoneyAccounts",
                newName: "TransactionAccounts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndGoalDate",
                table: "FinanceGoals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionAccounts",
                table: "TransactionAccounts",
                column: "Id");
        }
    }
}
