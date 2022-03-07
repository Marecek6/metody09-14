﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody10
{
    class Cifry
    {
        public static bool obsahujeCif(string a, out int cifSoucet, out int lichSoucet, out int sudSoucet)
        {
            bool obsahujeCif = false;
            cifSoucet = 0;
            lichSoucet = 0;
            sudSoucet = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (Char.IsNumber(a[i]))
                {
                    obsahujeCif = true;
                    cifSoucet += int.Parse(a[i].ToString());

                    if (int.Parse(a[i].ToString()) % 2 != 0)
                    {
                        lichSoucet += int.Parse(a[i].ToString());
                    }
                    else if (int.Parse(a[i].ToString()) % 2 == 0)
                    {
                        sudSoucet += int.Parse(a[i].ToString());
                    }
                }
            }

            return obsahujeCif;
        }

        public static int pocetSlov(string retezec, out string bezcisel)
        {
            int pocetSlov = 0;
            char[] separators = {' '};
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = poleSlov.Length;
            int i = 0;
            while (i < retezec.Length)
            {
                if (Char.IsNumber(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                }
                else i++;
            }
            bezcisel = retezec;
            return pocetSlov;
        }

        public static int pocetSlov2(ref string retezec)
        {
            int pocetSlov = 0;
            char[] separators = { ' ' };
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = poleSlov.Length;
            int i = 0;
            while (i < retezec.Length)
            {
                if (Char.IsNumber(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                }
                else i++;
            }
            return pocetSlov;
        }
        public static bool obsahujeSlovo(string retezec, out string nejkratsiSlovo, out string nejdelsiSlovo)
        {
            bool obsahujeSlovo = false;
            int pocetSlov = 0;
            nejdelsiSlovo = "";
            nejkratsiSlovo = "";
            int max = int.MinValue, min = int.MaxValue;
            char[] separators = { ' ' };
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = poleSlov.Length;
            if(pocetSlov >= 1)
            {
                obsahujeSlovo = true;
            }
            foreach(string s in poleSlov)
            {
                if(s.Length > max)
                {
                    nejdelsiSlovo = s;
                }
                if(s.Length < min)
                {
                    nejkratsiSlovo = s;
                }
            }
            return obsahujeSlovo;
        }
    }
}
