using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnMonHTN.Migrations
{
    /// <inheritdoc />
    public partial class editDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_Uid",
                table: "Logs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Logs_Uid",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Logs");

            migrationBuilder.AlterColumn<string>(
                name: "CardId",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Did",
                table: "Logs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LogId",
                table: "Logs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CardId",
                table: "Logs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Did",
                table: "Device",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CardId",
                table: "Logs",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_CardId",
                table: "Logs",
                column: "CardId",
                principalTable: "User",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_CardId",
                table: "Logs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Logs_CardId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Logs");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Uid",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Did",
                table: "Logs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "LogId",
                table: "Logs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Uid",
                table: "Logs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Did",
                table: "Device",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_Uid",
                table: "Logs",
                column: "Uid");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_Uid",
                table: "Logs",
                column: "Uid",
                principalTable: "User",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
