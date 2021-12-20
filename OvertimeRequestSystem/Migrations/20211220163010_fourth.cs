using Microsoft.EntityFrameworkCore.Migrations;

namespace OvertimeRequestSystem.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_AccountRole_TB_T_Account_AccountNIP",
                table: "TB_T_AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Overtime_TB_T_Employee_EmployeeNIP",
                table: "TB_T_Overtime");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Overtime_EmployeeNIP",
                table: "TB_T_Overtime");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_AccountRole_AccountNIP",
                table: "TB_T_AccountRole");

            migrationBuilder.DropColumn(
                name: "EmployeeNIP",
                table: "TB_T_Overtime");

            migrationBuilder.DropColumn(
                name: "AccountNIP",
                table: "TB_T_AccountRole");

            migrationBuilder.AddColumn<int>(
                name: "ManagerOrFinanceId",
                table: "TB_M_Response",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Overtime_NIP",
                table: "TB_T_Overtime",
                column: "NIP");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_AccountRole_NIP",
                table: "TB_T_AccountRole",
                column: "NIP");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_AccountRole_TB_T_Account_NIP",
                table: "TB_T_AccountRole",
                column: "NIP",
                principalTable: "TB_T_Account",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Overtime_TB_T_Employee_NIP",
                table: "TB_T_Overtime",
                column: "NIP",
                principalTable: "TB_T_Employee",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_AccountRole_TB_T_Account_NIP",
                table: "TB_T_AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Overtime_TB_T_Employee_NIP",
                table: "TB_T_Overtime");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Overtime_NIP",
                table: "TB_T_Overtime");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_AccountRole_NIP",
                table: "TB_T_AccountRole");

            migrationBuilder.DropColumn(
                name: "ManagerOrFinanceId",
                table: "TB_M_Response");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNIP",
                table: "TB_T_Overtime",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountNIP",
                table: "TB_T_AccountRole",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Overtime_EmployeeNIP",
                table: "TB_T_Overtime",
                column: "EmployeeNIP");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_AccountRole_AccountNIP",
                table: "TB_T_AccountRole",
                column: "AccountNIP");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_AccountRole_TB_T_Account_AccountNIP",
                table: "TB_T_AccountRole",
                column: "AccountNIP",
                principalTable: "TB_T_Account",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Overtime_TB_T_Employee_EmployeeNIP",
                table: "TB_T_Overtime",
                column: "EmployeeNIP",
                principalTable: "TB_T_Employee",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
