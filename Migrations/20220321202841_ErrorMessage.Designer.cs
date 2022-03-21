﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2proj2.Models;

namespace _2proj2.Migrations
{
    [DbContext(typeof(TimeFormContext))]
    [Migration("20220321202841_ErrorMessage")]
    partial class ErrorMessage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("_2proj2.Models.Time", b =>
                {
                    b.Property<int>("TimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeID");

                    b.ToTable("slots");

                    b.HasData(
                        new
                        {
                            TimeID = 1,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 2,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 3,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 4,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 5,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 6,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 7,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 8,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 9,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 10,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 11,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 12,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 13,
                            Available = true,
                            End = new DateTime(2022, 4, 1, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 14,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 15,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 16,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 17,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 18,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 19,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 20,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 21,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 22,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 23,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 24,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 25,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 26,
                            Available = true,
                            End = new DateTime(2022, 4, 2, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 27,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 28,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 29,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 30,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 31,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 32,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 33,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 34,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 35,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 36,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 37,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 38,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 39,
                            Available = true,
                            End = new DateTime(2022, 4, 3, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 40,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 41,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 42,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 43,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 44,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 45,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 46,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 47,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 48,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 49,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 50,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 51,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 52,
                            Available = true,
                            End = new DateTime(2022, 4, 4, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 53,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 54,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 55,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 56,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 57,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 58,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 59,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 60,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 61,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 62,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 63,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 64,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 65,
                            Available = true,
                            End = new DateTime(2022, 4, 5, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 66,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 67,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 68,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 69,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 70,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 71,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 72,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 73,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 74,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 75,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 76,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 77,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 78,
                            Available = true,
                            End = new DateTime(2022, 4, 6, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 79,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 8, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 80,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 9, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 81,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 10, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 82,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 11, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 83,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 12, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 84,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 13, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 85,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 14, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 86,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 15, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 87,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 16, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 88,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 89,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 18, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 90,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 19, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 91,
                            Available = true,
                            End = new DateTime(2022, 4, 7, 20, 59, 59, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2022, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("_2proj2.Models.User", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupId");

                    b.HasIndex("TimeId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            GroupId = 2,
                            Email = "aberg21@gmail.com",
                            GroupSize = 25,
                            Name = "Austin Berg",
                            PhoneNumber = "123-456-7890",
                            TimeId = 1
                        },
                        new
                        {
                            GroupId = 3,
                            Email = "test@test.com",
                            GroupSize = 6,
                            Name = "matt mccord",
                            PhoneNumber = "123-456-7234",
                            TimeId = 4
                        });
                });

            modelBuilder.Entity("_2proj2.Models.User", b =>
                {
                    b.HasOne("_2proj2.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}