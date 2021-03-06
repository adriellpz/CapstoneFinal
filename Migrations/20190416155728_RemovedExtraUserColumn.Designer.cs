﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using content;

namespace content.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190416155728_RemovedExtraUserColumn")]
    partial class RemovedExtraUserColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CapstoneFinal.Models.Courthouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("fjc_court_id");

                    b.Property<string>("full_name");

                    b.Property<double>("position");

                    b.HasKey("Id");

                    b.ToTable("Courthouses");
                });

            modelBuilder.Entity("CapstoneFinal.Models.Docket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourthouseId");

                    b.Property<string>("CurrentStatus");

                    b.Property<DateTime?>("DateTerminated");

                    b.Property<int>("DocketNumber");

                    b.Property<DateTime?>("HearingDate");

                    b.Property<int?>("UsersId");

                    b.Property<string>("case_name");

                    b.Property<DateTime?>("date_created");

                    b.HasKey("Id");

                    b.HasIndex("CourthouseId");

                    b.HasIndex("UsersId");

                    b.ToTable("Dockets");
                });

            modelBuilder.Entity("CapstoneFinal.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("userID");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CapstoneFinal.Models.Docket", b =>
                {
                    b.HasOne("CapstoneFinal.Models.Courthouse", "CourtHouses")
                        .WithMany("Dockets")
                        .HasForeignKey("CourthouseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CapstoneFinal.Models.Users")
                        .WithMany("Dockets")
                        .HasForeignKey("UsersId");
                });
#pragma warning restore 612, 618
        }
    }
}
