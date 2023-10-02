﻿// <auto-generated />
using System;
using Crito.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crito.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230929111327_Contactform Updated")]
    partial class ContactformUpdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Crito.Models.Entity.ContactFormEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("Crito.Models.Entity.NewsletterFormEntity", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("NewsletterForms");
                });
#pragma warning restore 612, 618
        }
    }
}
