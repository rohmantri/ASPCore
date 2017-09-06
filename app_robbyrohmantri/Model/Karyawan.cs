using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_robbyrohmantri.Model
{
    public class Karyawan : AbstractModel
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public DateTime TanggalLahir { get; set; }
    }
}
