using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static long Fattoriale(int num)
        {
            long fattoriale = num;

            for (int i = num - 1; i > 1; i--)
            {
                fattoriale = fattoriale * i;
            }

            if (num == 0)
            {
                fattoriale = 1;
            }

            return fattoriale;
        }
    }
}
