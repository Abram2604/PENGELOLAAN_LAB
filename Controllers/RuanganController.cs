using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Library penting untuk EF Core
using PENGELOLAAN_LAB.Data;      // Namespace untuk DbContext Anda
using PENGELOLAAN_LAB.Models;     // Namespace untuk Model Anda

namespace PENGELOLAAN_LAB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuanganController : ControllerBase
    {
        // 1. Variabel untuk menampung "pelayan" (DbContext)
        private readonly ApplicationDbContext _context;

        // 2. Constructor: Di sinilah "keajaiban" terjadi.
        //    ASP.NET Core akan otomatis memberikan ApplicationDbContext yang sudah kita daftarkan di Program.cs
        public RuanganController(ApplicationDbContext context)
        {
            _context = context; // Simpan "pelayan" itu ke dalam variabel kita
        }

        // 3. Membuat Endpoint untuk mengambil SEMUA data ruangan
        //    Ini akan merespon ke: GET http://localhost:xxxx/api/Ruangan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ruangan>>> GetRuangan()
        {
            // Cek jika tabel Ruangan ada isinya atau tidak
            if (_context.Ruangan == null)
            {
                return NotFound(); // Kirim status 404 Not Found jika tabel tidak ada
            }

            // Ambil semua data dari tabel Ruangan dan kembalikan sebagai response
            var ruanganList = await _context.Ruangan.ToListAsync();

            return Ok(ruanganList); // Kirim status 200 OK beserta datanya
        }
    }
}