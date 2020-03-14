using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Intli
{
    class Insans:ISesVerebilenler,IDansEdebilenler
    {
        public void sesVer()
        {
            Console.WriteLine("DoReMiFaSolLaSiDo");
        }
        public void dansEt()
        {
            Console.WriteLine("O zaman danss..");
        }
    }
}
