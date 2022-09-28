﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trello.Infrastructure.Data;

namespace Trello.Infrastructure.Migrations
{
    [DbContext(typeof(TrelloContext))]
    [Migration("20220928082658_TrelloSchema")]
    partial class TrelloSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trello.Core.Entities.Board", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPinned")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsStarred")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSubscribed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastActivity")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastViewed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Board");
                });

            modelBuilder.Entity("Trello.Core.Entities.Card", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ColumnName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSubscribed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastActivity")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.HasIndex("ColumnName");

                    b.HasIndex("UserName");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Trello.Core.Entities.Column", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BoardName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.HasIndex("BoardName");

                    b.ToTable("Column");
                });

            modelBuilder.Entity("Trello.Core.Entities.Label", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.HasIndex("CardName");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("Trello.Core.Entities.User", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsBusinessClass")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Trello.Core.Entities.Card", b =>
                {
                    b.HasOne("Trello.Core.Entities.Column", null)
                        .WithMany("Cards")
                        .HasForeignKey("ColumnName");

                    b.HasOne("Trello.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Trello.Core.Entities.Column", b =>
                {
                    b.HasOne("Trello.Core.Entities.Board", null)
                        .WithMany("Columns")
                        .HasForeignKey("BoardName");
                });

            modelBuilder.Entity("Trello.Core.Entities.Label", b =>
                {
                    b.HasOne("Trello.Core.Entities.Card", null)
                        .WithMany("Tags")
                        .HasForeignKey("CardName");
                });

            modelBuilder.Entity("Trello.Core.Entities.Board", b =>
                {
                    b.Navigation("Columns");
                });

            modelBuilder.Entity("Trello.Core.Entities.Card", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Trello.Core.Entities.Column", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}