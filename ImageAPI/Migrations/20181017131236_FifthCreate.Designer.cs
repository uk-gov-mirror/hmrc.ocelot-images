// <auto-generated />
using System;
using ImageAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ImageAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181017131236_FifthCreate")]
    partial class FifthCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ImageAPI.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<int?>("ApprovedByPID");

                    b.Property<DateTime?>("ApprovedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ImageName")
                        .IsRequired();

                    b.Property<string>("Path");

                    b.Property<string>("Placeholder")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int?>("UploadedByPID");

                    b.Property<DateTime?>("UploadedDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.HasIndex("Placeholder")
                        .IsUnique();

                    b.ToTable("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
