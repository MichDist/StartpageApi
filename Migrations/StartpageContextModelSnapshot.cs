﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StartpageApi.Data;

namespace StartpageApi.Migrations
{
    [DbContext(typeof(StartpageContext))]
    partial class StartpageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StartpageApi.Models.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("image_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("important")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("user_idid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_idid");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("StartpageApi.Models.History", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("object_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("table")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("StartpageApi.Models.Link", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("groupid")
                        .HasColumnType("int");

                    b.Property<string>("hyper_link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("important")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("user_idid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("groupid");

                    b.HasIndex("user_idid");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("StartpageApi.Models.Statistic", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("linkid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("linkid");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("StartpageApi.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StartpageApi.Models.Group", b =>
                {
                    b.HasOne("StartpageApi.Models.User", "user_id")
                        .WithMany()
                        .HasForeignKey("user_idid");

                    b.Navigation("user_id");
                });

            modelBuilder.Entity("StartpageApi.Models.Link", b =>
                {
                    b.HasOne("StartpageApi.Models.Group", "group")
                        .WithMany()
                        .HasForeignKey("groupid");

                    b.HasOne("StartpageApi.Models.User", "user_id")
                        .WithMany()
                        .HasForeignKey("user_idid");

                    b.Navigation("group");

                    b.Navigation("user_id");
                });

            modelBuilder.Entity("StartpageApi.Models.Statistic", b =>
                {
                    b.HasOne("StartpageApi.Models.Link", "link")
                        .WithMany()
                        .HasForeignKey("linkid");

                    b.Navigation("link");
                });
#pragma warning restore 612, 618
        }
    }
}
