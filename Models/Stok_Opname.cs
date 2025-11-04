using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Stok_Opname
    {
        [Key]
        public string? ID_StokOpname { get; set; }
        public string? ID_Barang { get; set; }
        public DateTime? Tanggal { get; set; }
        public DateTime? Bulan { get; set; }
        public DateTime? Tahun { get; set; }
        public int? Jumlah { get; set; }
        public string? Kondisi { get; set; }
        public string? Lokasi_Barang { get; set; }
        public DateTime? Jadwal_StokOpname { get; set; }
    }
}