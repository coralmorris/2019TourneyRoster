using Microsoft.EntityFrameworkCore.Migrations;

namespace _2019TourneyRoster.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_TeamRosters_TeamRosterID",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_TeamRosters_TeamRosterID",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "TeamRosters");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamRosterID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamRosterID",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamRosterID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamRosterID",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "ShirtSize",
                table: "Players",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                table: "Players",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "TeamRosterID",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShirtSize",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "TeamRosterID",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeamRosters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRosters", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamRosterID",
                table: "Teams",
                column: "TeamRosterID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamRosterID",
                table: "Players",
                column: "TeamRosterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_TeamRosters_TeamRosterID",
                table: "Players",
                column: "TeamRosterID",
                principalTable: "TeamRosters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_TeamRosters_TeamRosterID",
                table: "Teams",
                column: "TeamRosterID",
                principalTable: "TeamRosters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
