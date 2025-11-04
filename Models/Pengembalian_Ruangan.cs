using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Pengembalian_Ruangan
    {
        [Key]
        public string? ID_PeminjamanRuangan { get; set; } // Ini adalah PK dan juga FK
        public string? Catatan_Pengembalian { get; set; }
        public string? Kondisi_Ruangan { get; set; }
        public byte[]? Dokumentasi_Sebelum { get; set; }
        public byte[]? Dokumentasi_Sesudah { get; set; }
    }
}