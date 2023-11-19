using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firmayönetimsistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmalarController : ControllerBase
    {
        private static List<Firmalar> sirket = new List<Firmalar>
            {
                new Firmalar { Id = 1,
                    FirmaAd="Kardemir",
                    FirmaDurum="Onaylı",
                    Siparisbaslangic="8:00",
                    Siparisbitis=TimeOnly.FromDateTime (DateTime.Now ) },
                new Firmalar { Id = 2,
                    FirmaAd="Kardökmak",
                    FirmaDurum="Onaysız",
                    Siparisbaslangic="00000",
                    Siparisbitis=TimeOnly.FromDateTime (DateTime.Now )}
            };
        [HttpGet]
        public async Task<ActionResult<List<Firmalar>>> Get()
        {
            return Ok(sirket);
        }
        [HttpGet("id")]
        public async Task<ActionResult<Firmalar>> Get(int id)
        {
            var firm = sirket.Find(h => h.Id == id);
            if (firm == null)
                return BadRequest("firm bulunamadı!?");
            return Ok(sirket);
        }
        [HttpPost]
        public async Task<ActionResult<List<Firmalar>>> Add(Firmalar firm)
        {
            sirket.Add(firm);
            return Ok(sirket);
        }
        [HttpPut]
        public async Task<ActionResult<List<Firmalar>>> Updt(Firmalar talep)
        {
            var firm = sirket.Find(h => h.Id == talep.Id);
            if (firm == null)
                return BadRequest("firm bulunamadı!?");
            firm.FirmaAd = talep.FirmaAd;
            firm.FirmaDurum = talep.FirmaDurum;
            firm.Siparisbaslangic = talep.Siparisbaslangic;
            firm.Siparisbitis = talep.Siparisbitis;
            return Ok(sirket);
        }
    }
}
