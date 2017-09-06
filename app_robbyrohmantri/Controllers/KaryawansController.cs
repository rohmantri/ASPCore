using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app_robbyrohmantri.Model;

namespace app_robbyrohmantri.Controllers
{
    [Route("api/karyawans")]
    public class KaryawansController : Controller
    {
        List<Karyawan> data = new List<Karyawan>() {
                new Karyawan(){
                    ID = 1,
                    Nama = "Budi",
                    Alamat = "Bandung",
                    TanggalLahir = new DateTime(1990,12,12),
                    CreateTime = DateTime.Now
                },
                new Karyawan(){
                    ID = 2,
                    Nama = "Nia",
                    Alamat = "Jakarta",
                    TanggalLahir = new DateTime(1991,11,11),
                    CreateTime = DateTime.Now
                },
            };
        
        // GET api/values
        [HttpGet]
        public IEnumerable<Karyawan> Get()
        {
            return data;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Karyawan Get(int id)
        {
            return data.Where(o => o.ID == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Karyawan> Post([FromBody]Karyawan model)
        {
            model.ID = data.Max(o => o.ID) + 1;
            data.Add(model);
            return data;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Karyawan> Put(int id, [FromBody]Karyawan model)
        {
            data.Where(o => o.ID == id).FirstOrDefault().Nama = model.Nama;
            data.Where(o => o.ID == id).FirstOrDefault().TanggalLahir = model.TanggalLahir;
            data.Where(o => o.ID == id).FirstOrDefault().Alamat = model.Alamat;

            return data;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IEnumerable<Karyawan> Delete(int id)
        {
            var karyawan = data.Where(o => o.ID == id).First();

            data.Remove(karyawan);
            return data;
        }
    }
}
