using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddDocs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_MoneyAccounts_MoneyAccountId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Transactions_TransactionId",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document",
                table: "Document");

            migrationBuilder.RenameTable(
                name: "Document",
                newName: "Documents");

            migrationBuilder.RenameIndex(
                name: "IX_Document_TransactionId",
                table: "Documents",
                newName: "IX_Documents_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_MoneyAccountId",
                table: "Documents",
                newName: "IX_Documents_MoneyAccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_MoneyAccounts_MoneyAccountId",
                table: "Documents",
                column: "MoneyAccountId",
                principalTable: "MoneyAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Transactions_TransactionId",
                table: "Documents",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_MoneyAccounts_MoneyAccountId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Transactions_TransactionId",
                table: "Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "Document");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_TransactionId",
                table: "Document",
                newName: "IX_Document_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_MoneyAccountId",
                table: "Document",
                newName: "IX_Document_MoneyAccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document",
                table: "Document",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_MoneyAccounts_MoneyAccountId",
                table: "Document",
                column: "MoneyAccountId",
                principalTable: "MoneyAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Transactions_TransactionId",
                table: "Document",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");
        }
    }
}
