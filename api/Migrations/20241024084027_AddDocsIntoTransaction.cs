using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddDocsIntoTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Document",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Document_TransactionId",
                table: "Document",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Transactions_TransactionId",
                table: "Document",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Transactions_TransactionId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_TransactionId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Document");
        }
    }
}
