﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Organogram.API.Data;

namespace Organogram.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210216095918_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ASP_React.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("ASP_React.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ASP_React.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ASP_React.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("ASP_React.Models.ProductionUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionUnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("ProdutionUnit");
                });

            modelBuilder.Entity("ASP_React.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ProductionUnitId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductionUnitId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("ASP_React.Models.Branch", b =>
                {
                    b.HasOne("ASP_React.Models.Company", null)
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ASP_React.Models.Department", b =>
                {
                    b.HasOne("ASP_React.Models.Branch", null)
                        .WithMany("Departments")
                        .HasForeignKey("BranchId");
                });

            modelBuilder.Entity("ASP_React.Models.Line", b =>
                {
                    b.HasOne("ASP_React.Models.Section", null)
                        .WithMany("Lines")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("ASP_React.Models.ProductionUnit", b =>
                {
                    b.HasOne("ASP_React.Models.Department", null)
                        .WithMany("ProductionUnits")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("ASP_React.Models.Section", b =>
                {
                    b.HasOne("ASP_React.Models.ProductionUnit", null)
                        .WithMany("Sections")
                        .HasForeignKey("ProductionUnitId");
                });

            modelBuilder.Entity("ASP_React.Models.Branch", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("ASP_React.Models.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("ASP_React.Models.Department", b =>
                {
                    b.Navigation("ProductionUnits");
                });

            modelBuilder.Entity("ASP_React.Models.ProductionUnit", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ASP_React.Models.Section", b =>
                {
                    b.Navigation("Lines");
                });
#pragma warning restore 612, 618
        }
    }
}
