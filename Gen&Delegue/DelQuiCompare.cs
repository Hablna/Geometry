using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Delegue
{
    /// <summary>
    /// Délégué qui compare deux machins et renvoie un booléen
    /// pour coder la comparaison qu'on veut
    /// </summary>
    /// <typeparam name="TypeDeMachin"></typeparam>
    /// <param name="machin1">premier machin à comparer</param>
    /// <param name="machin2">deuxième machin à comparer</param>
    /// <returns>Resultat de la comparaison</returns>
    public delegate bool delegueQuiCompare<TypeDeMachin>(TypeDeMachin machin1, TypeDeMachin machin2);
}
