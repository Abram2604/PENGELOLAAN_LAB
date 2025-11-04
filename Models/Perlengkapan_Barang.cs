using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Perlengkapan_Barang
    {
        [Key]
        public string? ID_Perlengkapan { get; set; }
        public string? ID_Barang { get; set; }
        public string? Nama_Perlengkapan { get; set; }
        public string? Status_Perlengkapan { get; set; }
    }
}