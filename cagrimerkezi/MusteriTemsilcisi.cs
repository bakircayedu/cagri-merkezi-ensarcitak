using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cagrimerkezi
{
    public class MusteriTemsilcisi
    {
        public int temsilciId { get; set; }
        public string temsilciTuru { get; set; }
        public bool temsilciUygunlugu { get; set; }
        public CagrilarQueue Sira { get; set; }

    }
}
