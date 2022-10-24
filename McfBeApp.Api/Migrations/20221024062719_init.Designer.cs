﻿// <auto-generated />
using System;
using McfBeApp.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace McfBeApp.Api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221024062719_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("McfBeApp.Api.Model.BpkpTransaction", b =>
                {
                    b.Property<string>("AgrrementNumber")
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("agreement_number");

                    b.Property<DateTime>("BpkbDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("bpkp_date");

                    b.Property<DateTime>("BpkbDateIn")
                        .HasColumnType("datetime2")
                        .HasColumnName("bpkp_date_in");

                    b.Property<string>("BpkbNumber")
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("bpkb_number");

                    b.Property<DateTime>("FakturDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("faktur_date");

                    b.Property<string>("LocationId")
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("location_id");

                    b.Property<string>("PoliceNumber")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("police_no");

                    b.HasKey("AgrrementNumber");

                    b.HasIndex("LocationId");

                    b.ToTable("tr_bpkb");
                });

            modelBuilder.Entity("McfBeApp.Api.Model.StorageLocation", b =>
                {
                    b.Property<string>("LocationId")
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("location_id");

                    b.Property<string>("LocationName")
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("location_name");

                    b.HasKey("LocationId");

                    b.ToTable("ms_storage_location");
                });

            modelBuilder.Entity("McfBeApp.Api.Model.BpkpTransaction", b =>
                {
                    b.HasOne("McfBeApp.Api.Model.StorageLocation", "StorageLocation")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("StorageLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
