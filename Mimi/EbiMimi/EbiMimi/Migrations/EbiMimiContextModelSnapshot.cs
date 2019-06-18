﻿// <auto-generated />
using System;
using EbiMimi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EbiMimi.Migrations
{
    [DbContext(typeof(EbiMimiContext))]
    partial class EbiMimiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EbiMimi.Models.Media", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Desc");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("EbiMimi.Models.Photo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublicSchedule");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UploadDT");

                    b.Property<long>("photo");

                    b.HasKey("ID");

                    b.ToTable("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}