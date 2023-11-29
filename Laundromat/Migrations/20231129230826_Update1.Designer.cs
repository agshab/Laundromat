﻿// <auto-generated />
using System;
using Laundromat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Laundromat.Migrations
{
    [DbContext(typeof(LaundromatContext))]
    [Migration("20231129230826_Update1")]
    partial class Update1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("Laundromat.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerSex")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.HasIndex("StoreId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Laundromat.Equipment", b =>
                {
                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CustomerPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("EquipmentType")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SerialNumber");

                    b.HasIndex("StoreId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("Laundromat.EquipmentUsage", b =>
                {
                    b.Property<int>("EquipmentUsageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EquipmentSerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StoreId")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("TimeWashCycle")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeofEquipmentinUse")
                        .HasColumnType("TEXT");

                    b.HasKey("EquipmentUsageId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EquipmentSerialNumber");

                    b.HasIndex("StoreId");

                    b.ToTable("EquipmentUsages");
                });

            modelBuilder.Entity("Laundromat.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BusinessRevenue")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CostToRun")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HoursofOperationEndoftheDay")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HoursofOperationstartoftheDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreName")
                        .HasColumnType("TEXT");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Laundromat.Customer", b =>
                {
                    b.HasOne("Laundromat.Store", null)
                        .WithMany("CustomersinStore")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("Laundromat.Equipment", b =>
                {
                    b.HasOne("Laundromat.Store", null)
                        .WithMany("EquipmentInStore")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("Laundromat.EquipmentUsage", b =>
                {
                    b.HasOne("Laundromat.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Laundromat.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentSerialNumber");

                    b.HasOne("Laundromat.Store", null)
                        .WithMany("EquipmentInUuseInStore")
                        .HasForeignKey("StoreId");

                    b.Navigation("Customer");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("Laundromat.Store", b =>
                {
                    b.Navigation("CustomersinStore");

                    b.Navigation("EquipmentInStore");

                    b.Navigation("EquipmentInUuseInStore");
                });
#pragma warning restore 612, 618
        }
    }
}
