using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Intli
{
    class Program
    {
        static void Main(string[] args)
        {
            Koro koromuz = new Koro();
            Kedi k = new Kedi();
            koromuz.solistEkle(k);

            Insans i = new Insans();
            koromuz.solistEkle(i);

            DansToplulugu dt = new DansToplulugu();
            dt.dansciEkle(i);
            //dt.dansciEkle(k);

            koromuz.koroSoylesin();

            dt.dansBaslasin();

        }
    }
}
