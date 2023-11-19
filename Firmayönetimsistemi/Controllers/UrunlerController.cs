using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace Firmayönetimsistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private static List<Urunler> mal = new List<Urunler>
        {
            new Urunler{Id=1,
                UrunAd="Metal Plaka",
                UrunStok=1000,
                UrunFiyat=1000}
        };
        [HttpGet]
        public async Task<ActionResult<List<Urunler>>> Get()
        {
            return Ok(mal);
        }
        [HttpGet("id")]
        public async Task<ActionResult<Urunler>> Get(int id)
        {
            var firm = mal.Find(h => h.Id == id);
            if (firm == null)
                return BadRequest("firm bulunamadı!?");
            return Ok(mal);
        }
        [HttpPost]
        public async Task<ActionResult<List<Urunler>>> Add(Urunler urus)
        {
            mal.Add(urus);
            return Ok(mal);
        }
        [HttpPut]
        public async Task<ActionResult<List<Urunler>>> Updt(Urunler uruz)
        {
            var firm = mal.Find(h => h.Id == uruz.Id);
            if (firm == null)
                return BadRequest("firm bulunamadı!?");
            uruz.UrunAd = uruz.UrunAd;
            uruz.UrunStok = uruz.UrunStok;
            uruz.UrunFiyat = uruz.UrunFiyat;
            return Ok(mal);
        }

    }
}
