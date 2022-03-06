using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Activity___userfrom__6C190EBB",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK__Activity___userto__6C190EBC",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "currentDate",
                table: "KidsAttendance",
                newName: "CurrentDate");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AgeKid",
                table: "Kids",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClassId",
                table: "Users",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK__Activity___userfrom__6C190EBB",
                table: "Messages",
                column: "UserFromId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK__Activity___userto__6C190EBC",
                table: "Messages",
                column: "UserToId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Activity___userfrom__6C190EBB",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK__Activity___userto__6C190EBC",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClassId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CurrentDate",
                table: "KidsAttendance",
                newName: "currentDate");

            migrationBuilder.AlterColumn<double>(
                name: "AgeKid",
                table: "Kids",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK__Activity___userfrom__6C190EBB",
                table: "Messages",
                column: "UserFromId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Activity___userto__6C190EBC",
                table: "Messages",
                column: "UserToId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
