using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__placement__class__6754599E",
                table: "PlacementOfATeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_PlacementOfATeacher_ClassId",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "IsMorning",
                table: "PlacementOfATeacher");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNamber2",
                table: "Users",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecoverLostsDate",
                table: "RecoverLosts",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek1A",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek1M",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek2A",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek2M",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek3A",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek3M",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek4A",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek4M",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek5A",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek5M",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek6M",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MessageDateTime",
                table: "Messages",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CurrentDate",
                table: "KidsAttendance",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBorn",
                table: "Kids",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImageDate",
                table: "Images",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExternalDataDate",
                table: "ExternalData",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCare",
                table: "DayCare",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DailyActivityDate",
                table: "ActivityUpdate",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "FK__exte__class___5DCAEF64",
                table: "Users",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__exte__class___5DCAEF64",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DayInWeek1A",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek1M",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek2A",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek2M",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek3A",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek3M",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek4A",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek4M",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek5A",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek5M",
                table: "PlacementOfATeacher");

            migrationBuilder.DropColumn(
                name: "DayInWeek6M",
                table: "PlacementOfATeacher");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNamber2",
                table: "Users",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecoverLostsDate",
                table: "RecoverLosts",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayInWeek",
                table: "PlacementOfATeacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsMorning",
                table: "PlacementOfATeacher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MessageDateTime",
                table: "Messages",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CurrentDate",
                table: "KidsAttendance",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBorn",
                table: "Kids",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ImageDate",
                table: "Images",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExternalDataDate",
                table: "ExternalData",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCare",
                table: "DayCare",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DailyActivityDate",
                table: "ActivityUpdate",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateIndex(
                name: "IX_PlacementOfATeacher_ClassId",
                table: "PlacementOfATeacher",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK__placement__class__6754599E",
                table: "PlacementOfATeacher",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
