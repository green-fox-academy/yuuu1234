﻿// <auto-generated />
using System;
using FoxCoin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoxCoin.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181207063643_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoxCoin.Models.Transaction", b =>
                {
                    b.Property<long>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ReceiverId");

                    b.Property<long?>("SenderId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("TransactionId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new { TransactionId = 1L, ReceiverId = 2L, SenderId = 1L, Timestamp = new DateTime(2018, 12, 7, 6, 36, 43, 400, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("FoxCoin.Models.UserAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");

                    b.HasData(
                        new { Id = 1L, Balance = 100m, Username = "john" },
                        new { Id = 2L, Balance = 100m, Username = "jane" }
                    );
                });

            modelBuilder.Entity("FoxCoin.Models.Transaction", b =>
                {
                    b.HasOne("FoxCoin.Models.UserAccount", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId");

                    b.HasOne("FoxCoin.Models.UserAccount", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");
                });
#pragma warning restore 612, 618
        }
    }
}
