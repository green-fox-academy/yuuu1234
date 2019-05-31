﻿// <auto-generated />
using System;
using ImageUploadService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImageUploadService.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181201034433_ResizedImages")]
    partial class ResizedImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImageUploadService.Models.Image", b =>
                {
                    b.Property<long>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<long?>("RawImageId");

                    b.Property<long>("Size");

                    b.Property<string>("Url");

                    b.HasKey("ImageId");

                    b.HasIndex("RawImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ImageUploadService.Models.Image", b =>
                {
                    b.HasOne("ImageUploadService.Models.Image", "RawImage")
                        .WithMany("ResizedVariants")
                        .HasForeignKey("RawImageId");
                });
#pragma warning restore 612, 618
        }
    }
}