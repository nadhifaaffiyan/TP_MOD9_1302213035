using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TP_MOD9_1302213035
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : Controller
    {
        private const string V = "{id}";
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Nama = "NADHIFA AFFIYAN ZALWI", Nim = "1302213035"},
            new mahasiswa {Nama = "Shielda Diasavitri Chaerry", Nim = "1302210044"},
            new mahasiswa {Nama = "Marsya Rayani Humaira" Nim = "1302213003"},
            new mahasiswa {Nama = "Hilmi Fauziyyah S", Nim = "1302210081},
            new mahasiswa {Nama = "Gabriela Sheryl Audrey T", Nim = "1302213054"}
        };

        // GET: api/<Mahasiswa>
        // mereturn output berupa list dari semua obj mhs
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        // GET api/<Mahasiswa>/{id}
        // mereturn output berupa obj mhs ke-i
        [HttpGet("{id}")]
        public mahasiswa Get(int id)
        {
            return mhs[id];
        }

        // POST api/<Mahasiswa>
        // menambah obj mhs baru 
        public IActionResult Post([FromBody] mahasiswa newMhs)
        {
            mhs.Add(newMhs);
            return Ok();
        }

        // DELETE api/<Mahasiswa>/{id}
        // menghapus obj mhs ke-i
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }
    }

    public class Controller
    {
    }

    internal class FromBodyAttribute : Attribute
    {
    }

    public interface IActionResult
    {
    }

    internal class HttpDeleteAttribute : Attribute
    {
    }

    internal class HttpPostAttribute : Attribute
    {
    }

    internal class HttpGetAttribute : Attribute
    {
        public HttpGetAttribute(string v)
        {
        }
    }

    public class mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}