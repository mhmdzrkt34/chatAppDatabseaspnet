﻿// <auto-generated />
using System;
using ChatAppDatabase.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatAppDatabase.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240521141552_start")]
    partial class start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChatAppDatabase.Models.Contact", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reciever_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("reciever_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("user_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("user_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("contact");
                });

            modelBuilder.Entity("ChatAppDatabase.Models.Messages", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("reciever_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("sender_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("reciever_id");

                    b.HasIndex("sender_id");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("ChatAppDatabase.Models.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ChatAppDatabase.Models.Contact", b =>
                {
                    b.HasOne("ChatAppDatabase.Models.User", "user")
                        .WithMany("contacts")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ChatAppDatabase.Models.Messages", b =>
                {
                    b.HasOne("ChatAppDatabase.Models.User", "reciever")
                        .WithMany("RecievedMessages")
                        .HasForeignKey("reciever_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ChatAppDatabase.Models.User", "sender")
                        .WithMany("SendedMessages")
                        .HasForeignKey("sender_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("reciever");

                    b.Navigation("sender");
                });

            modelBuilder.Entity("ChatAppDatabase.Models.User", b =>
                {
                    b.Navigation("RecievedMessages");

                    b.Navigation("SendedMessages");

                    b.Navigation("contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
