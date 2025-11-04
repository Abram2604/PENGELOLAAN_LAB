using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Pengembalian_Barang
    {
        [Key]
        public string? ID_PengembalianBarang { get; set; }
        public string? ID_PeminjamanBarang { get; set; }
        public DateTime? Tanggal_Kembali { get; set; }
        public string? Kondisi_Barang { get; set; }
        public int? Jumlah_Kembali { get; set; }
        public string? Catatan_Pengembalian { get; set; }
    }
}