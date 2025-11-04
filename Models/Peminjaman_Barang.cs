using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Peminjaman_Barang
    {
        [Key]
        public string? ID_PeminjamanBarang { get; set; }
        public string? ID_Barang { get; set; }
        public string? ID_Pengguna { get; set; }
        public DateTime? Tanggal_Pinjam { get; set; }
        public DateTime? Tanggal_Kembali { get; set; } // Nullable karena saat pinjam belum tentu tahu kapan kembali
        public string? Alasan_Peminjaman { get; set; }
        public byte[]? File_Surat { get; set; }
        public string? Status_Peminjaman { get; set; }
        public string? Catatan_Penolakan { get; set; }
    }
}