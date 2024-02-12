﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPISchool.Data;

#nullable disable

namespace WebAPISchool.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240212050941_SchoolMig")]
    partial class SchoolMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPISchool.Models.School", b =>
                {
                    b.Property<int>("RollNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RollNo"), 1L, 1);

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marks")
                        .HasColumnType("int");

                    b.HasKey("RollNo");

                    b.ToTable("School");
                });
#pragma warning restore 612, 618
        }
    }
}
