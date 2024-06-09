﻿// <auto-generated />
using System;
using FPTCourseManagement.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FPTCourseManagement.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240530093143_FirstDb")]
    partial class FirstDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Courses.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TypeSlotId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("SubjectId");

                    b.HasIndex("TypeSlotId");

                    b.ToTable("course", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Courses.CourseStudent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("course_student", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Roles.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("char(25)")
                        .HasColumnName("permission_name")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("permission", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Roles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Roles.RolePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("role_permission", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Schedules.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ScheduleId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("StudentId");

                    b.ToTable("attendance", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Schedules.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TimeSlotId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("TimeSlotId");

                    b.ToTable("schedule", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Slot.TimeSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("time_slot", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Slot.TypeSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Type")
                        .HasMaxLength(25)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("type_slot", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Subjects.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfSlot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.Student", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("StudentCode")
                        .HasMaxLength(25)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<Guid?>("UserId1")
                        .HasColumnType("char(36)");

                    b.HasKey("AccountId");

                    b.HasIndex("UserId1");

                    b.ToTable("student", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.Teacher", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("TeacherCode")
                        .HasMaxLength(25)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.HasKey("AccountId");

                    b.ToTable("teacher", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Courses.Course", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Subjects.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Slot.TypeSlot", "TypeSlot")
                        .WithMany("Courses")
                        .HasForeignKey("TypeSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("TypeSlot");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Courses.CourseStudent", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Courses.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Users.Student", "Student")
                        .WithMany("CourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Roles.RolePermission", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Roles.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Roles.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Schedules.Attendance", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Schedules.Schedule", "Schedule")
                        .WithMany("Attendances")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Users.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Schedules.Schedule", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Courses.Course", "Course")
                        .WithMany("Schedules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Users.Teacher", "Teacher")
                        .WithMany("Schedules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Slot.TimeSlot", "TimeSlot")
                        .WithMany("Schedules")
                        .HasForeignKey("TimeSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");

                    b.Navigation("TimeSlot");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.Student", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Users.User", "User")
                        .WithMany("students")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTCourseManagement.Domain.Entities.Users.User", null)
                        .WithMany("Students")
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.Teacher", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Users.User", "User")
                        .WithMany("Teachers")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("FPTCourseManagement.Domain.Entities.Roles.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Courses.Course", b =>
                {
                    b.Navigation("CourseStudents");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Roles.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Roles.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Schedules.Schedule", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Slot.TimeSlot", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Slot.TypeSlot", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Subjects.Subject", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.Student", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("CourseStudents");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.Teacher", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("FPTCourseManagement.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");

                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
