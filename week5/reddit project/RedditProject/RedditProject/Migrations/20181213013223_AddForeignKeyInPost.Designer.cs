﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedditProject;

namespace RedditProject.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181213013223_AddForeignKeyInPost")]
    partial class AddForeignKeyInPost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedditProject.Models.Post", b =>
                {
                    b.Property<long>("postId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostContent");

                    b.Property<DateTime>("PostDate");

                    b.Property<string>("Url");

                    b.Property<long>("Vote");

                    b.Property<long?>("userId");

                    b.HasKey("postId");

                    b.HasIndex("userId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("RedditProject.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RedditProject.Models.Post", b =>
                {
                    b.HasOne("RedditProject.Models.User")
                        .WithMany("Posts")
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}
