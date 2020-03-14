using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Intli
{
    class Koro
    {
        ISesVerebilenler[] solistler = new ISesVerebilenler[5];
        int eklenen = 0;

        public void solistEkle(ISesVerebilenler solist)
        {
            solistler[eklenen++] = solist;
        }

        public void koroSoylesin()
        {
            for (int i = 0; i < eklenen; i++)
                solistler[i].sesVer();

        }
    }
}
