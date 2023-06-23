﻿// <auto-generated />
using System;
using BeautySalon.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeautySalon.Services.Migrations
{
    [DbContext(typeof(BeautySalonContext))]
    [Migration("20230519202342_UpdateServiceClass")]
    partial class UpdateServiceClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BaseUserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("RoleId", "UserId")
                        .HasName("PK_User_Roles");

                    b.HasIndex("UserId");

                    b.ToTable("BaseUserRole", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AppointmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"), 1L, 1);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CouponCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    b.Property<string>("RescheduleReason")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("RescheduleRequest")
                        .HasColumnType("datetime");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int")
                        .HasColumnName("ServiceID");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("StatusID");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("AppointmentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StatusId");

                    b.ToTable("Appointment", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.AppointmentStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StatusID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StatusId")
                        .HasName("PK__Appointm__C8EE2043ACF86CF1");

                    b.ToTable("AppointmentStatus", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.BaseUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("UserId")
                        .HasName("PK__BaseUser__1788CCAC974B022B");

                    b.ToTable("BaseUser", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CouponID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"), 1L, 1);

                    b.Property<bool>("AppliesToAllUsers")
                        .HasColumnType("bit");

                    b.Property<int?>("AppliesToAppointmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("MaxUses")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<int>("UsesRemaining")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.HasIndex("UserId");

                    b.ToTable("Coupon", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Customer", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("AppointmentCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UserId")
                        .HasName("PK__Customer__1788CCAC4342F635");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Employee", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserId")
                        .HasName("PK__Employee__1788CCAC7C287117");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int")
                        .HasColumnName("AppointmentID");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TransactionId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TransactionID");

                    b.HasKey("PaymentId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ServiceID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ServiceId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("BeautySalon.Services.Database.ServiceCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId")
                        .HasName("PK__ServiceC__19093A2B4620EB35");

                    b.ToTable("ServiceCategory", (string)null);
                });

            modelBuilder.Entity("BaseUserRole", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__BaseUserR__RoleI__29572725");

                    b.HasOne("BeautySalon.Services.Database.BaseUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__BaseUserR__UserI__2A4B4B5E");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Appointment", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK__Appointme__Custo__3A81B327");

                    b.HasOne("BeautySalon.Services.Database.Employee", "Employee")
                        .WithMany("Appointments")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK__Appointme__Emplo__3D5E1FD2");

                    b.HasOne("BeautySalon.Services.Database.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceId")
                        .IsRequired()
                        .HasConstraintName("FK__Appointme__Servi__3B75D760");

                    b.HasOne("BeautySalon.Services.Database.AppointmentStatus", "Status")
                        .WithMany("Appointments")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK__Appointme__Statu__3C69FB99");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Service");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Coupon", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.BaseUser", "User")
                        .WithMany("Coupons")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Coupon__UserID__403A8C7D");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Customer", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.BaseUser", "User")
                        .WithOne("Customer")
                        .HasForeignKey("BeautySalon.Services.Database.Customer", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Customer__UserID__2E1BDC42");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Employee", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.BaseUser", "User")
                        .WithOne("Employee")
                        .HasForeignKey("BeautySalon.Services.Database.Employee", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Employee__UserID__30F848ED");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Payment", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.Appointment", "Appointment")
                        .WithMany("Payments")
                        .HasForeignKey("AppointmentId")
                        .IsRequired()
                        .HasConstraintName("FK__Payments__Appoin__4316F928");

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Service", b =>
                {
                    b.HasOne("BeautySalon.Services.Database.ServiceCategory", "Category")
                        .WithMany("Services")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__Service__Categor__35BCFE0A");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Appointment", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.AppointmentStatus", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.BaseUser", b =>
                {
                    b.Navigation("Coupons");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Customer", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Employee", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.Service", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BeautySalon.Services.Database.ServiceCategory", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
