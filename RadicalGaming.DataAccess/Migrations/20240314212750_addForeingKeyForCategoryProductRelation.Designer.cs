﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RadicalGaming.DataAccess.Data;

#nullable disable

namespace RadicalGaming.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240314212750_addForeingKeyForCategoryProductRelation")]
    partial class addForeingKeyForCategoryProductRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RadicalGaming.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Mouse"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Keyboard"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Headset"
                        });
                });

            modelBuilder.Entity("RadicalGaming.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Achieve the next level of absolute control with the Razer Viper 8KHz, a ambidextrous e-sports mouse with a true 8000 Hz polling rate for the fastest speed and lowest latency ever achieved.",
                            Price = 69.0,
                            Title = "Viper Gamingmouse"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Mechanical gaming keyboard with Chroma RGB (Digital multifunction wheel and media keys, Ergonomic wrist rest) Black, Nordic/Swedish layout",
                            Price = 139.0,
                            Title = "BlackWidow V3 Keyboard"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Defeat all enemies with the Razer Kraken X Lite gaming headset. With lightweight design, 7.1 surround sound, reliable microphone, and versatile compatibility, you can take on any challenge.",
                            Price = 39.0,
                            Title = "Kraken X Headset"
                        });
                });

            modelBuilder.Entity("RadicalGaming.Model.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "David"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Charllie"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Albin"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Rick"
                        });
                });

            modelBuilder.Entity("RadicalGaming.Model.Product", b =>
                {
                    b.HasOne("RadicalGaming.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
