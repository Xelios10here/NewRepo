using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace Firmayönetimsistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private static List<Siparis> alım = new List<Siparis> //alım adında nesne türetildi.
        {
            new Siparis
            {
                Id = 1,
                müsteri = "Ahmet",
                siparistarihi = "18/11/2024"
            },
            new Siparis
            {
                Id = 2,
                müsteri = "Gizem",
                siparistarihi = "19/11/2024"
            }
        };
        [HttpGet]
        public async Task<ActionResult<List<Siparis>>> Get() //get metodunda alım nesnesini ekrana döndürüyor.
        {
            return Ok(alım);
        }
        [HttpGet("id")]
        public async Task<ActionResult<Siparis>> Get(int id) //alım nesnesine firm adında başka bir nesne tanımlıyorum bu sayede get metodu aksi bir durumda badrequest ile yanlılş olduğunu tanımıyorum
        {
            var firm = alım.Find(h => h.Id == id);
            if (firm == null)
                return BadRequest("firm bulunamadı!?");
            return Ok(alım);
        }
        [HttpPost]
        public async Task<ActionResult<List<Siparis>>> Add(Siparis sips) //post metodu ile alım nesnesine sips parametresini ekliyoruz.
        {
            alım.Add(sips);
            return Ok(alım);
        }
        [HttpPut]
        public async Task<ActionResult<List<Firmalar>>> Updt(Siparis upsip) //put metodu ile güncelleme işlemi için upsis parametresini alım nesnesine tanımlıyoruz.
        {
            var sips = alım.Find(h => h.Id == upsip.Id);
            if (sips == null)
                return BadRequest("firm bulunamadı!?");
            sips.siparistarihi = upsip.müsteri;
            return Ok(sips);
        }
    }
}
