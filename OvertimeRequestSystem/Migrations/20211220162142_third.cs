using Microsoft.EntityFrameworkCore.Migrations;

namespace OvertimeRequestSystem.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Response_TB_T_Employee_EmployeeNIP",
                table: "TB_M_Response");

            migrationBuilder.DropColumn(
                name: "ManagerOrFinanceId",
                table: "TB_M_Response");

            migrationBuilder.RenameColumn(
                name: "EmployeeNIP",
                table: "TB_M_Response",
                newName: "ManagerOfFinanceId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_M_Response_EmployeeNIP",
                table: "TB_M_Response",
                newName: "IX_TB_M_Response_ManagerOfFinanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Response_TB_T_Employee_ManagerOfFinanceId",
                table: "TB_M_Response",
                column: "ManagerOfFinanceId",
                principalTable: "TB_T_Employee",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Response_TB_T_Employee_ManagerOfFinanceId",
                table: "TB_M_Response");

            migrationBuilder.RenameColumn(
                name: "ManagerOfFinanceId",
                table: "TB_M_Response",
                newName: "EmployeeNIP");

            migrationBuilder.RenameIndex(
                name: "IX_TB_M_Response_ManagerOfFinanceId",
                table: "TB_M_Response",
                newName: "IX_TB_M_Response_EmployeeNIP");

            migrationBuilder.AddColumn<int>(
                name: "ManagerOrFinanceId",
                table: "TB_M_Response",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Response_TB_T_Employee_EmployeeNIP",
                table: "TB_M_Response",
                column: "EmployeeNIP",
                principalTable: "TB_T_Employee",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
