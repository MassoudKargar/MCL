﻿// <auto-generated />
using System;
using MCL.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MCL.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230831172931_SeedDataEf")]
    partial class SeedDataEf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MCL.Domain.LeaveAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveId")
                        .HasColumnType("int");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("int");

                    b.Property<int>("Priod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveAllocations");
                });

            modelBuilder.Entity("MCL.Domain.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Approved")
                        .HasColumnType("bit");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateActioned")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<string>("RequestComments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("MCL.Domain.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultDay")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DefaultDay = 10,
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vacation"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DefaultDay = 12,
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sick"
                        });
                });

            modelBuilder.Entity("MCL.Domain.LeaveAllocation", b =>
                {
                    b.HasOne("MCL.Domain.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("MCL.Domain.LeaveRequest", b =>
                {
                    b.HasOne("MCL.Domain.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });
#pragma warning restore 612, 618
        }
    }
}
