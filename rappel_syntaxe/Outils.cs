using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rappel_syntaxe
{
    internal static class Outils
    {
        public static string MajAuDebDesMots(this string  phrase)
        {
            var mots = phrase.Split(' ');
            for (int i = 0; i < mots.Length; i++)
            {
               if (mots[i].Length > 0)
                {
                    mots[i] = char.ToUpper(mots[i][0]) + mots[i].Substring(1);
                }
            }
            return string.Join(" ", mots);
        }
    }
}
