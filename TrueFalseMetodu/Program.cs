using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFalseMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrueFalse sayibul = new TrueFalse();
            bool sonuc = sayibul.TekCift(10);
            if (sonuc)
            {
                Console.WriteLine("Sayı tektir");
            }
            else
            {
                Console.WriteLine("sayı çifttir");
            }
        }
    }
    public class TrueFalse
    {
        public bool TekCift(int sayi)
        {
            if (sayi % 2 == 1)
            {
                return true;
            }
            return false;
        }

    }
}