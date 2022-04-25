using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cagrimerkezi
{
    public class Cagri
    {
        public int cagriID { get; set; }
        public string musteriTuru { get; set; }
        public DateTime aramaZamani { get; set; }
        public DateTime temsilciyeBaglanmaZamani { get; set; }
        public DateTime cagriBitisZamani { get; set; }
        public int temsilciID { get; set; }
        public string notlar { get; set; }

        public Cagri()
        {
            cagriID = 0;
        }
    }
}
