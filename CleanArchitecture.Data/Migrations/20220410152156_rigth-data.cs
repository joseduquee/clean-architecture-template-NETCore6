using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class rigthdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Videos_VideoId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Director_DirectorId",
                table: "Videos");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Streamers_StreamerId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_DirectorId",
                table: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_VideoId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directores");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actores");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Directores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Directores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Directores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Directores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Directores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Directores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "Directores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Actores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Actores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Actores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Actores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Actores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Actores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directores",
                table: "Directores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actores",
                table: "Actores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "VideoActor",
                columns: table => new
                {
                    VideoId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoActor", x => new { x.ActorId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_VideoActor_Actores_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoActor_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directores_VideoId",
                table: "Directores",
                column: "VideoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoActor_VideoId",
                table: "VideoActor",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directores_Videos_VideoId",
                table: "Directores",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Streamers_StreamerId",
                table: "Videos",
                column: "StreamerId",
                principalTable: "Streamers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directores_Videos_VideoId",
                table: "Directores");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Streamers_StreamerId",
                table: "Videos");

            migrationBuilder.DropTable(
                name: "VideoActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directores",
                table: "Directores");

            migrationBuilder.DropIndex(
                name: "IX_Directores_VideoId",
                table: "Directores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actores",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Actores");

            migrationBuilder.RenameTable(
                name: "Directores",
                newName: "Director");

            migrationBuilder.RenameTable(
                name: "Actores",
                newName: "Actor");

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Director",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_DirectorId",
                table: "Videos",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_VideoId",
                table: "Actor",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Videos_VideoId",
                table: "Actor",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Director_DirectorId",
                table: "Videos",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Streamers_StreamerId",
                table: "Videos",
                column: "StreamerId",
                principalTable: "Streamers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
