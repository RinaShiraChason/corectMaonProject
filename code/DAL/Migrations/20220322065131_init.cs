using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "Hebrew_CI_AS");

            migrationBuilder.CreateTable(
                name: "TypeClass",
                columns: table => new
                {
                    IdTypeClass = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeClassName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__type_cla__D21A678A5C59ED67", x => x.IdTypeClass);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ClassTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Classes__BF62B0120F430C85", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK__class_type__6C190EBB",
                        column: x => x.ClassTypeId,
                        principalTable: "TypeClass",
                        principalColumn: "IdTypeClass",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTz = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    PhoneNamber1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PhoneNamber2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__user__54384119BEE1AB93", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__exte__class___5DCAEF64",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityUpdate",
                columns: table => new
                {
                    IdActivityUpdate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyActivityDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DailyActivitySubject = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    DailyActivityInfo = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Activity__BF62B0120F430C85", x => x.IdActivityUpdate);
                    table.ForeignKey(
                        name: "FK__Activity___class__6B24EA82",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Activity___teacher__6C190EBB",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExternalData",
                columns: table => new
                {
                    ExternalDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalDataTitle = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ExternalDataLink = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ExternalDataDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__externaldata__5234F2D4EE33DA1B", x => x.ExternalDataId);
                    table.ForeignKey(
                        name: "FK__ext__class___5DCAEF64",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ext__user___5DCAEF64",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ImageTitle = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ImageData = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ImageDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__image__5234F2D4EE33DA1B", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK__images__class___5DCAEF64",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__images__user___5DCAEF64",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kids",
                columns: table => new
                {
                    KidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKid = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    TzKid = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    AgeKid = table.Column<double>(type: "float", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    DateBorn = table.Column<DateTime>(type: "datetime", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kids__FB5DFF00013EE552", x => x.KidId);
                    table.ForeignKey(
                        name: "FK__kids__class_id__60A75C0F",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__kids__parents_id__619B8048",
                        column: x => x.ParentId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacementOfATeacher",
                columns: table => new
                {
                    IdPlacementOfATeacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayInWeek1M = table.Column<int>(type: "int", nullable: true),
                    DayInWeek1A = table.Column<int>(type: "int", nullable: true),
                    DayInWeek2M = table.Column<int>(type: "int", nullable: true),
                    DayInWeek2A = table.Column<int>(type: "int", nullable: true),
                    DayInWeek4M = table.Column<int>(type: "int", nullable: true),
                    DayInWeek4A = table.Column<int>(type: "int", nullable: true),
                    DayInWeek3M = table.Column<int>(type: "int", nullable: true),
                    DayInWeek3A = table.Column<int>(type: "int", nullable: true),
                    DayInWeek5M = table.Column<int>(type: "int", nullable: true),
                    DayInWeek5A = table.Column<int>(type: "int", nullable: true),
                    DayInWeek6M = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__placemen__EC1AB144B1E88409", x => x.IdPlacementOfATeacher);
                    table.ForeignKey(
                        name: "FK__placement__teach__68487DD7",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecoverLosts",
                columns: table => new
                {
                    RecoverLostsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecoverLostsInfo = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    RecoverLostsImage = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    RecoverLostsDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rec__5234F2D4EE33DA1B", x => x.RecoverLostsId);
                    table.ForeignKey(
                        name: "FK__rec__user___5DCAEF64",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayCare",
                columns: table => new
                {
                    IdDayCare = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCare = table.Column<DateTime>(type: "datetime", nullable: false),
                    BehaviorDayCare = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    DressDayCare = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    CommentDayCare = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    SleepDayCare = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    FoodDayCare = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    KidId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__day_care__3DDF0F6C2DFCB989", x => x.IdDayCare);
                    table.ForeignKey(
                        name: "FK__Activity___KidId__6C190EBB",
                        column: x => x.KidId,
                        principalTable: "Kids",
                        principalColumn: "KidId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KidsAttendance",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsArrived = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    KidId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kids_att__20D6A96841C11ED2", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK__kids__attendance__619B8048",
                        column: x => x.KidId,
                        principalTable: "Kids",
                        principalColumn: "KidId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageContent = table.Column<string>(type: "varchar(max)", unicode: false, maxLength: 10000, nullable: false),
                    MessageDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserFromId = table.Column<int>(type: "int", nullable: false),
                    KidId = table.Column<int>(type: "int", nullable: false),
                    UserToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__message__3DDF0F6C2DFCB989", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK__Activity___Kid_message__6C190EBB",
                        column: x => x.KidId,
                        principalTable: "Kids",
                        principalColumn: "KidId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Activity___userfrom__6C190EBB",
                        column: x => x.UserFromId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK__Activity___userto__6C190EBC",
                        column: x => x.UserToId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityUpdate_ClassId",
                table: "ActivityUpdate",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityUpdate_TeacherId",
                table: "ActivityUpdate",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassTypeId",
                table: "Classes",
                column: "ClassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DayCare_KidId",
                table: "DayCare",
                column: "KidId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalData_ClassId",
                table: "ExternalData",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalData_TeacherId",
                table: "ExternalData",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ClassId",
                table: "Images",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_TeacherId",
                table: "Images",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_ClassId",
                table: "Kids",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Kids_ParentId",
                table: "Kids",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_KidsAttendance_KidId",
                table: "KidsAttendance",
                column: "KidId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_KidId",
                table: "Messages",
                column: "KidId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserFromId",
                table: "Messages",
                column: "UserFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserToId",
                table: "Messages",
                column: "UserToId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacementOfATeacher_TeacherId",
                table: "PlacementOfATeacher",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_RecoverLosts_IdUser",
                table: "RecoverLosts",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClassId",
                table: "Users",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityUpdate");

            migrationBuilder.DropTable(
                name: "DayCare");

            migrationBuilder.DropTable(
                name: "ExternalData");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "KidsAttendance");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PlacementOfATeacher");

            migrationBuilder.DropTable(
                name: "RecoverLosts");

            migrationBuilder.DropTable(
                name: "Kids");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "TypeClass");

            migrationBuilder.AlterDatabase(
                oldCollation: "Hebrew_CI_AS");
        }
    }
}
