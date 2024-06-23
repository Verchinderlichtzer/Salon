﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salon.Shared;

#nullable disable

namespace Salon.Shared.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Salon.Shared.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("JenisKelamin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telepon")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Salon.Shared.Models.DetailLayanan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdLayanan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tarif")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdLayanan");

                    b.ToTable("DetailLayanan");
                });

            modelBuilder.Entity("Salon.Shared.Models.DetailProduk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdProduk")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Jumlah")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdProduk");

                    b.ToTable("DetailProduk");
                });

            modelBuilder.Entity("Salon.Shared.Models.Layanan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tarif")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Layanan");
                });

            modelBuilder.Entity("Salon.Shared.Models.Produk", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Harga")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Satuan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Stok")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Produk");

                    b.HasData(
                        new
                        {
                            Id = "P-0001",
                            Harga = 10000,
                            Nama = "Wardah",
                            Satuan = "Pcs",
                            Stok = 0
                        },
                        new
                        {
                            Id = "P-0002",
                            Harga = 90000,
                            Nama = "Purbasari",
                            Satuan = "Pcs",
                            Stok = 0
                        },
                        new
                        {
                            Id = "P-0003",
                            Harga = 20000,
                            Nama = "Bedak Lulur",
                            Satuan = "Botol",
                            Stok = 0
                        },
                        new
                        {
                            Id = "P-0004",
                            Harga = 15000,
                            Nama = "Pemutih Wajah",
                            Satuan = "Cepuk",
                            Stok = 0
                        });
                });

            modelBuilder.Entity("Salon.Shared.Models.Transaksi", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Bayar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BiayaLayanan")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BiayaProduk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdCustomer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Tanggal")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalBiaya")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdUser");

                    b.ToTable("Transaksi");
                });

            modelBuilder.Entity("Salon.Shared.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<byte>("JenisKelamin")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("JenisUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telepon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Salon.Shared.Models.DetailLayanan", b =>
                {
                    b.HasOne("Salon.Shared.Models.Layanan", "Layanan")
                        .WithMany("DetailLayanan")
                        .HasForeignKey("IdLayanan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Layanan");
                });

            modelBuilder.Entity("Salon.Shared.Models.DetailProduk", b =>
                {
                    b.HasOne("Salon.Shared.Models.Produk", "Produk")
                        .WithMany("DetailProduk")
                        .HasForeignKey("IdProduk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produk");
                });

            modelBuilder.Entity("Salon.Shared.Models.Transaksi", b =>
                {
                    b.HasOne("Salon.Shared.Models.Customer", "Customer")
                        .WithMany("Transaksi")
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salon.Shared.Models.User", "User")
                        .WithMany("Transaksi")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Salon.Shared.Models.Customer", b =>
                {
                    b.Navigation("Transaksi");
                });

            modelBuilder.Entity("Salon.Shared.Models.Layanan", b =>
                {
                    b.Navigation("DetailLayanan");
                });

            modelBuilder.Entity("Salon.Shared.Models.Produk", b =>
                {
                    b.Navigation("DetailProduk");
                });

            modelBuilder.Entity("Salon.Shared.Models.User", b =>
                {
                    b.Navigation("Transaksi");
                });
#pragma warning restore 612, 618
        }
    }
}
