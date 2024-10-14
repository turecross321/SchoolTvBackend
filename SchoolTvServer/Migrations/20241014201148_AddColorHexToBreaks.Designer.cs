﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolTvServer.Database;

#nullable disable

namespace SchoolTvServer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241014201148_AddColorHexToBreaks")]
    partial class AddColorHexToBreaks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("SchoolTvServer.Types.DbSchoolBreak", b =>
                {
                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AlwaysShow")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColorHex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StartDate");

                    b.ToTable("SchoolBreaks");
                });

            modelBuilder.Entity("SchoolTvServer.Types.DbTemperature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Celsius")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Temperatures");
                });
#pragma warning restore 612, 618
        }
    }
}
