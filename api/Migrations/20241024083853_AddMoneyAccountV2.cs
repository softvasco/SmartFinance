using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddMoneyAccountV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "MoneyAccounts",
                newName: "SmallDescription");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseDate",
                table: "MoneyAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CloseExtractDay",
                table: "MoneyAccounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DebtCapital",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityNumber",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullDescription",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IBAN",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Installment",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NIB",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OpenDate",
                table: "MoneyAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PayDay",
                table: "MoneyAccounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PercentageOfPayment",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Plafon",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefNumber",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "StartingCapital",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Swift",
                table: "MoneyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TAN",
                table: "MoneyAccounts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoneyAccountId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_MoneyAccounts_MoneyAccountId",
                        column: x => x.MoneyAccountId,
                        principalTable: "MoneyAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_MoneyAccountId",
                table: "Document",
                column: "MoneyAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "CloseExtractDay",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "DebtCapital",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "EntityNumber",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "FullDescription",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "IBAN",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Installment",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "NIB",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "OpenDate",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "PayDay",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "PercentageOfPayment",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Plafon",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "RefNumber",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "StartingCapital",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "Swift",
                table: "MoneyAccounts");

            migrationBuilder.DropColumn(
                name: "TAN",
                table: "MoneyAccounts");

            migrationBuilder.RenameColumn(
                name: "SmallDescription",
                table: "MoneyAccounts",
                newName: "Description");
        }
    }
}
