using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_robbyrohmantri.Model
{
    public class AbstractModel
    {
        public int ID { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
    }
}
