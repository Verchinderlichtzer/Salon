using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salon.Shared.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    JenisKelamin = table.Column<byte>(type: "INTEGER", nullable: false),
                    TanggalLahir = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alamat = table.Column<string>(type: "TEXT", nullable: false),
                    Telepon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Layanan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    Tarif = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layanan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    Satuan = table.Column<string>(type: "TEXT", nullable: false),
                    Harga = table.Column<int>(type: "INTEGER", nullable: false),
                    Stok = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Nama = table.Column<string>(type: "TEXT", nullable: false),
                    JenisKelamin = table.Column<byte>(type: "INTEGER", nullable: false),
                    Telepon = table.Column<string>(type: "TEXT", nullable: false),
                    JenisUser = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaksi",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    IdUser = table.Column<string>(type: "TEXT", nullable: false),
                    IdCustomer = table.Column<string>(type: "TEXT", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BiayaProduk = table.Column<int>(type: "INTEGER", nullable: false),
                    BiayaLayanan = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalBiaya = table.Column<int>(type: "INTEGER", nullable: false),
                    Bayar = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaksi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaksi_Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaksi_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailLayanan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdTransaksi = table.Column<string>(type: "TEXT", nullable: false),
                    IdLayanan = table.Column<string>(type: "TEXT", nullable: false),
                    Tarif = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailLayanan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailLayanan_Layanan_IdLayanan",
                        column: x => x.IdLayanan,
                        principalTable: "Layanan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailLayanan_Transaksi_IdTransaksi",
                        column: x => x.IdTransaksi,
                        principalTable: "Transaksi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailProduk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdTransaksi = table.Column<string>(type: "TEXT", nullable: false),
                    IdProduk = table.Column<string>(type: "TEXT", nullable: false),
                    Jumlah = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailProduk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailProduk_Produk_IdProduk",
                        column: x => x.IdProduk,
                        principalTable: "Produk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailProduk_Transaksi_IdTransaksi",
                        column: x => x.IdTransaksi,
                        principalTable: "Transaksi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Alamat", "JenisKelamin", "Nama", "TanggalLahir", "Telepon" },
                values: new object[,]
                {
                    { "C-00001", "Bekasi", (byte)2, "Putri", new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0853 4677 3443" },
                    { "C-00002", "Jakarta", (byte)1, "Andi", new DateTime(1997, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0833 5275 9486" }
                });

            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "Id", "Harga", "Nama", "Satuan", "Stok" },
                values: new object[,]
                {
                    { "P-0001", 10000, "Wardah", "Pcs", 0 },
                    { "P-0002", 90000, "Purbasari", "Pcs", 0 },
                    { "P-0003", 20000, "Bedak Lulur", "Botol", 0 },
                    { "P-0004", 15000, "Pemutih Wajah", "Cepuk", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailLayanan_IdLayanan",
                table: "DetailLayanan",
                column: "IdLayanan");

            migrationBuilder.CreateIndex(
                name: "IX_DetailLayanan_IdTransaksi",
                table: "DetailLayanan",
                column: "IdTransaksi");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProduk_IdProduk",
                table: "DetailProduk",
                column: "IdProduk");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProduk_IdTransaksi",
                table: "DetailProduk",
                column: "IdTransaksi");

            migrationBuilder.CreateIndex(
                name: "IX_Transaksi_IdCustomer",
                table: "Transaksi",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Transaksi_IdUser",
                table: "Transaksi",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailLayanan");

            migrationBuilder.DropTable(
                name: "DetailProduk");

            migrationBuilder.DropTable(
                name: "Layanan");

            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "Transaksi");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
