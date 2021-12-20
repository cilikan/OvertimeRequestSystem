﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OvertimeRequestSystem.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20211220163010_fourth")]
    partial class fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("OvertimeRequestSystem.Models.Account", b =>
                {
                    b.Property<int>("NIP")
                        .HasColumnType("int");

                    b.Property<string>("AccountStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIP");

                    b.ToTable("TB_T_Account");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.AccountRole", b =>
                {
                    b.Property<int>("AccountRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NIP")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("AccountRoleId");

                    b.HasIndex("NIP");

                    b.HasIndex("RoleId");

                    b.ToTable("TB_T_AccountRole");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Employee", b =>
                {
                    b.Property<int>("NIP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BasicSalary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIP");

                    b.ToTable("TB_T_Employee");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Overtime", b =>
                {
                    b.Property<int>("OvertimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NIP")
                        .HasColumnType("int");

                    b.Property<int>("OvertimeSalary")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusByFinance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusByManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SumOvertimeHour")
                        .HasColumnType("int");

                    b.HasKey("OvertimeId");

                    b.HasIndex("NIP");

                    b.ToTable("TB_T_Overtime");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.OvertimeDetail", b =>
                {
                    b.Property<int>("OvertimeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<TimeSpan>("EndHour")
                        .HasColumnType("time");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OvertimeId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartHour")
                        .HasColumnType("time");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OvertimeDetailId");

                    b.HasIndex("OvertimeId");

                    b.ToTable("TB_T_OvertimeDetail");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Parameter", b =>
                {
                    b.Property<int>("ParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ParameterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("ParameterId");

                    b.ToTable("TB_M_Parameter");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Response", b =>
                {
                    b.Property<int>("ResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ManagerOfFinanceId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerOrFinanceId")
                        .HasColumnType("int");

                    b.Property<int>("OvertimeId")
                        .HasColumnType("int");

                    b.Property<string>("ResponseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResponseId");

                    b.HasIndex("ManagerOfFinanceId");

                    b.HasIndex("OvertimeId");

                    b.ToTable("TB_M_Response");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("TB_M_Role");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Account", b =>
                {
                    b.HasOne("OvertimeRequestSystem.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("OvertimeRequestSystem.Models.Account", "NIP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.AccountRole", b =>
                {
                    b.HasOne("OvertimeRequestSystem.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("NIP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OvertimeRequestSystem.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Overtime", b =>
                {
                    b.HasOne("OvertimeRequestSystem.Models.Employee", "Employee")
                        .WithMany("overtimes")
                        .HasForeignKey("NIP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.OvertimeDetail", b =>
                {
                    b.HasOne("OvertimeRequestSystem.Models.Overtime", "Overtime")
                        .WithMany("overtimeDetails")
                        .HasForeignKey("OvertimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Overtime");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Response", b =>
                {
                    b.HasOne("OvertimeRequestSystem.Models.Employee", "Employee")
                        .WithMany("responses")
                        .HasForeignKey("ManagerOfFinanceId");

                    b.HasOne("OvertimeRequestSystem.Models.Overtime", "Overtime")
                        .WithMany("responses")
                        .HasForeignKey("OvertimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Overtime");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Employee", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("overtimes");

                    b.Navigation("responses");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Overtime", b =>
                {
                    b.Navigation("overtimeDetails");

                    b.Navigation("responses");
                });

            modelBuilder.Entity("OvertimeRequestSystem.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
