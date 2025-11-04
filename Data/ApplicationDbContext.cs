using Microsoft.EntityFrameworkCore;
using PENGELOLAAN_LAB.Models;

namespace PENGELOLAAN_LAB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Pengguna> Pengguna { get; set; }
        public DbSet<Ruangan> Ruangan { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Barang> Barang { get; set; }
        public DbSet<Perlengkapan_Barang> Perlengkapan_Barang { get; set; }
        public DbSet<Stok_Opname> Stok_Opname { get; set; }
        public DbSet<Peminjaman_Barang> Peminjaman_Barang { get; set; }
        public DbSet<Pengembalian_Barang> Pengembalian_Barang { get; set; }
        public DbSet<Peminjaman_Ruangan> Peminjaman_Ruangan { get; set; }
        public DbSet<Pengembalian_Ruangan> Pengembalian_Ruangan { get; set; }
    }
}