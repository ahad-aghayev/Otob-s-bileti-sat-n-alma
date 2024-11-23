using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class OtobusBileti
    {
        public double fiyat(int kisi)
        {
            return kisi * 1000;
        }
        public double indirim(int kisi)
        {
            return kisi*1000 * 0.85;
        }
    }
}
