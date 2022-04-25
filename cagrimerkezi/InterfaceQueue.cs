using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cagrimerkezi
{
    public interface InterfaceQueue
    {
        void Insert(Cagri cagri);
        object Remove();
        bool IsEmpty();

    }
}
