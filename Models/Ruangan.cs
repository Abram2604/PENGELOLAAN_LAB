using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Ruangan
    {
        [Key]
        public string? ID_Ruangan { get; set; }
        public string? Nama_Ruangan { get; set; }
        public string? Kondisi_Ruangan { get; set; }
        public string? Status { get; set; }
        public bool isDeleted { get; set; }
    }
}