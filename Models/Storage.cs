using System.ComponentModel.DataAnnotations;

namespace PENGELOLAAN_LAB.Models
{
    public class Storage
    {
        [Key]
        public string? ID_Storage { get; set; }
        public string? ID_Ruangan { get; set; }
        public string? Nama_Storage { get; set; }
        public string? Status_Storage { get; set; }
    }
}