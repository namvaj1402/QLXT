using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Phong
    {
        public int id { get; set; }
        public string sophong { get; set; }
        public string status { get; set; }
        public List<Nguoi> Nguoi { get; set; } = new List<Nguoi>();
        public List<Tien> Tien { get; set; } = new List<Tien>();
    }
}
