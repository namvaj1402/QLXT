using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Tien
    {
        public int id { get; set; }
        public float tienphong { get; set; }
        public float tiendien { get; set; }
        public float tiennuoc { get; set; }
        //public string ghichu { get; set; }
    }
}
