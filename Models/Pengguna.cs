using System.ComponentModel.DataAnnotations;
namespace PENGELOLAAN_LAB.Models
{
    public class Pengguna
    {
        [Key]
        public string? ID_Pengguna { get; set; }
        public string? Nama_Pengguna { get; set; }
        [EmailAddress]
        public string? Email_Pengguna { get; set; }
        public string? Jenis_Role { get; set; }
        public string? Kata_Sandi { get; set; }
        public bool isDeleted { get; set; }
    }
}
