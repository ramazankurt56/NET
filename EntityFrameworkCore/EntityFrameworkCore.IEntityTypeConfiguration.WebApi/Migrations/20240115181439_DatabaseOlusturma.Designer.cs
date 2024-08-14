﻿// <auto-generated />
using System;
using EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240115181439_DatabaseOlusturma")]
    partial class DatabaseOlusturma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Models.Product", b =>
                {
                    b.HasOne("EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityFrameworkCore.IEntityTypeConfiguration.WebApi.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
