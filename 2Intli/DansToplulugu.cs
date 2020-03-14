using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Intli
{
    class DansToplulugu
    {
        IDansEdebilenler[] danscilar = new IDansEdebilenler[5];
        int eklenen = 0;

        public void dansciEkle(IDansEdebilenler dansci)
        {
            danscilar[eklenen++] = dansci;
        }

        public void dansBaslasin()
        {
            for (int i = 0; i < eklenen; i++)
                danscilar[i].dansEt();
        }
    }
}
