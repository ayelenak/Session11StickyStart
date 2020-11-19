﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using stickynotes.Data;

namespace stickynotes.Migrations
{
    [DbContext(typeof(StickyContext))]
    partial class StickyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("stickynotes.Models.Sticky", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notetext")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notetitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Sticky");
                });
#pragma warning restore 612, 618
        }
    }
}
