﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public interface IForme
    {
        double CalculerPerimetre();//pas besoin de specifier public c'est sous-entendu
        double CalculerSurface();
    }
}
