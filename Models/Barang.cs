using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Barang
    {
        [Key]
        public string? ID_Barang { get; set; }
        public string? ID_Storage { get; set; }
        public string? Nama_Barang { get; set; }
        public string? Lokasi_Barang { get; set; }
        public int? Stok_Barang { get; set; }
        public string? Status_Barang { get; set; }
        public bool isDeleted { get; set; }
        public string? Jenis_Barang { get; set; }
        public string? Serial_Number { get; set; }
        public string? Kondisi_Barang { get; set; }
    }
}