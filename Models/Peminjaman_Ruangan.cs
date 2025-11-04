using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Peminjaman_Ruangan
    {
        [Key]
        public string? ID_PeminjamanRuangan { get; set; }
        public string? ID_Ruangan { get; set; }
        public string? ID_Pengguna { get; set; }
        public DateTime? Tanggal_Peminjaman_Ruangan { get; set; }
        public string? Alasan_Peminjaman_Ruangan { get; set; }
        public TimeSpan? Waktu_Mulai { get; set; } // TimeSpan adalah tipe data yang tepat untuk SQL time
        public TimeSpan? Waktu_Selesai { get; set; }
        public string? Status_Peminjaman { get; set; }
        public string? Catatan_Penolakan { get; set; }
    }
}