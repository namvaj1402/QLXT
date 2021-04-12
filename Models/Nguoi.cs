using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Nguoi
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string sdt { get; set; }
        public string cmnd { get; set; }
        public DateTime ngaysinh { get; set; } = DateTime.Now;
        public string diachi { get; set; }
    }
}
