using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cagrimerkezi
{
    public class CagrilarQueue:InterfaceQueue
    {
        public Cagri[] BekleyenKuyrugu;
        private int front = -1;
        private int count = 0;
        private int rear = -1;
        private int size = 0;

        public CagrilarQueue(int size)
        {
            this.size = size;
            BekleyenKuyrugu = new Cagri[size];
        }
        public bool IsEmpty()
        {
            return count == 0 ? true : false;
        }
        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Sıra Boş");
            }
            object temp = BekleyenKuyrugu[front];
            BekleyenKuyrugu[front] = null;
            front--;
            count--;
            return temp;
        }
        public void Insert(Cagri cagri)
        {
            if (IsEmpty())
            {
                front++;
                rear++;
                BekleyenKuyrugu[front] = cagri;
                count++;

            }
            else
            {
                BekleyenKuyrugu[++rear] = cagri;
                count++;
            }
        }
    }
}
