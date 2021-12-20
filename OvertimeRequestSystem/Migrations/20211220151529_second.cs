using Microsoft.EntityFrameworkCore.Migrations;

namespace OvertimeRequestSystem.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountRoles_Accounts_AccountNIP",
                table: "AccountRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountRoles_Roles_RoleId",
                table: "AccountRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Employees_NIP",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_OvertimeDetails_Overtimes_OvertimeId",
                table: "OvertimeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Overtimes_Employees_EmployeeNIP",
                table: "Overtimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Employees_EmployeeNIP",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Overtimes_OvertimeId",
                table: "Responses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responses",
                table: "Responses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parameters",
                table: "Parameters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Overtimes",
                table: "Overtimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OvertimeDetails",
                table: "OvertimeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "TB_M_Role");

            migrationBuilder.RenameTable(
                name: "Responses",
                newName: "TB_M_Response");

            migrationBuilder.RenameTable(
                name: "Parameters",
                newName: "TB_M_Parameter");

            migrationBuilder.RenameTable(
                name: "Overtimes",
                newName: "TB_T_Overtime");

            migrationBuilder.RenameTable(
                name: "OvertimeDetails",
                newName: "TB_T_OvertimeDetail");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "TB_T_Employee");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "TB_T_Account");

            migrationBuilder.RenameTable(
                name: "AccountRoles",
                newName: "TB_T_AccountRole");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_OvertimeId",
                table: "TB_M_Response",
                newName: "IX_TB_M_Response_OvertimeId");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_EmployeeNIP",
                table: "TB_M_Response",
                newName: "IX_TB_M_Response_EmployeeNIP");

            migrationBuilder.RenameIndex(
                name: "IX_Overtimes_EmployeeNIP",
                table: "TB_T_Overtime",
                newName: "IX_TB_T_Overtime_EmployeeNIP");

            migrationBuilder.RenameIndex(
                name: "IX_OvertimeDetails_OvertimeId",
                table: "TB_T_OvertimeDetail",
                newName: "IX_TB_T_OvertimeDetail_OvertimeId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountRoles_RoleId",
                table: "TB_T_AccountRole",
                newName: "IX_TB_T_AccountRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountRoles_AccountNIP",
                table: "TB_T_AccountRole",
                newName: "IX_TB_T_AccountRole_AccountNIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_M_Role",
                table: "TB_M_Role",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_M_Response",
                table: "TB_M_Response",
                column: "ResponseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_M_Parameter",
                table: "TB_M_Parameter",
                column: "ParameterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_T_Overtime",
                table: "TB_T_Overtime",
                column: "OvertimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_T_OvertimeDetail",
                table: "TB_T_OvertimeDetail",
                column: "OvertimeDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_T_Employee",
                table: "TB_T_Employee",
                column: "NIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_T_Account",
                table: "TB_T_Account",
                column: "NIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_T_AccountRole",
                table: "TB_T_AccountRole",
                column: "AccountRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Response_TB_T_Employee_EmployeeNIP",
                table: "TB_M_Response",
                column: "EmployeeNIP",
                principalTable: "TB_T_Employee",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Response_TB_T_Overtime_OvertimeId",
                table: "TB_M_Response",
                column: "OvertimeId",
                principalTable: "TB_T_Overtime",
                principalColumn: "OvertimeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Account_TB_T_Employee_NIP",
                table: "TB_T_Account",
                column: "NIP",
                principalTable: "TB_T_Employee",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_AccountRole_TB_M_Role_RoleId",
                table: "TB_T_AccountRole",
                column: "RoleId",
                principalTable: "TB_M_Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_OvertimeDetail_TB_T_Overtime_OvertimeId",
                table: "TB_T_OvertimeDetail",
                column: "OvertimeId",
                principalTable: "TB_T_Overtime",
                principalColumn: "OvertimeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Response_TB_T_Employee_EmployeeNIP",
                table: "TB_M_Response");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Response_TB_T_Overtime_OvertimeId",
                table: "TB_M_Response");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Account_TB_T_Employee_NIP",
                table: "TB_T_Account");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_AccountRole_TB_M_Role_RoleId",
                table: "TB_T_AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_AccountRole_TB_T_Account_AccountNIP",
                table: "TB_T_AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Overtime_TB_T_Employee_EmployeeNIP",
                table: "TB_T_Overtime");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OvertimeDetail_TB_T_Overtime_OvertimeId",
                table: "TB_T_OvertimeDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_T_OvertimeDetail",
                table: "TB_T_OvertimeDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_T_Overtime",
                table: "TB_T_Overtime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_T_Employee",
                table: "TB_T_Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_T_AccountRole",
                table: "TB_T_AccountRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_T_Account",
                table: "TB_T_Account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_M_Role",
                table: "TB_M_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_M_Response",
                table: "TB_M_Response");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_M_Parameter",
                table: "TB_M_Parameter");

            migrationBuilder.RenameTable(
                name: "TB_T_OvertimeDetail",
                newName: "OvertimeDetails");

            migrationBuilder.RenameTable(
                name: "TB_T_Overtime",
                newName: "Overtimes");

            migrationBuilder.RenameTable(
                name: "TB_T_Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "TB_T_AccountRole",
                newName: "AccountRoles");

            migrationBuilder.RenameTable(
                name: "TB_T_Account",
                newName: "Accounts");

            migrationBuilder.RenameTable(
                name: "TB_M_Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "TB_M_Response",
                newName: "Responses");

            migrationBuilder.RenameTable(
                name: "TB_M_Parameter",
                newName: "Parameters");

            migrationBuilder.RenameIndex(
                name: "IX_TB_T_OvertimeDetail_OvertimeId",
                table: "OvertimeDetails",
                newName: "IX_OvertimeDetails_OvertimeId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_T_Overtime_EmployeeNIP",
                table: "Overtimes",
                newName: "IX_Overtimes_EmployeeNIP");

            migrationBuilder.RenameIndex(
                name: "IX_TB_T_AccountRole_RoleId",
                table: "AccountRoles",
                newName: "IX_AccountRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_T_AccountRole_AccountNIP",
                table: "AccountRoles",
                newName: "IX_AccountRoles_AccountNIP");

            migrationBuilder.RenameIndex(
                name: "IX_TB_M_Response_OvertimeId",
                table: "Responses",
                newName: "IX_Responses_OvertimeId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_M_Response_EmployeeNIP",
                table: "Responses",
                newName: "IX_Responses_EmployeeNIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OvertimeDetails",
                table: "OvertimeDetails",
                column: "OvertimeDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Overtimes",
                table: "Overtimes",
                column: "OvertimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "NIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles",
                column: "AccountRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "NIP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responses",
                table: "Responses",
                column: "ResponseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parameters",
                table: "Parameters",
                column: "ParameterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRoles_Accounts_AccountNIP",
                table: "AccountRoles",
                column: "AccountNIP",
                principalTable: "Accounts",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRoles_Roles_RoleId",
                table: "AccountRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Employees_NIP",
                table: "Accounts",
                column: "NIP",
                principalTable: "Employees",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OvertimeDetails_Overtimes_OvertimeId",
                table: "OvertimeDetails",
                column: "OvertimeId",
                principalTable: "Overtimes",
                principalColumn: "OvertimeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Overtimes_Employees_EmployeeNIP",
                table: "Overtimes",
                column: "EmployeeNIP",
                principalTable: "Employees",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Employees_EmployeeNIP",
                table: "Responses",
                column: "EmployeeNIP",
                principalTable: "Employees",
                principalColumn: "NIP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Overtimes_OvertimeId",
                table: "Responses",
                column: "OvertimeId",
                principalTable: "Overtimes",
                principalColumn: "OvertimeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
