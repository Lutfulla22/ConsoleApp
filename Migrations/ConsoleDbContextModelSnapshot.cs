﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efconsole.Data;

namespace efconsole.Migrations
{
    [DbContext(typeof(ConsoleDbContext))]
    partial class ConsoleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("efconsole.Entity.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MentorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("efconsole.Entity.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("efconsole.Entity.Student", b =>
                {
                    b.HasOne("efconsole.Entity.Teacher", null)
                        .WithMany("Students")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("efconsole.Entity.Teacher", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
