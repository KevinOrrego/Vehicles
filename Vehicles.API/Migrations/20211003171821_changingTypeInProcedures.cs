using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.API.Migrations
{
    public partial class changingTypeInProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Procedures_ProcedureId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_ProcedureId",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "ProcedureId",
                table: "Procedures");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details");

            migrationBuilder.AddColumn<int>(
                name: "ProcedureId",
                table: "Procedures",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "Details",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_ProcedureId",
                table: "Procedures",
                column: "ProcedureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Procedures_ProcedureId",
                table: "Procedures",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
