﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure2
{
    internal class ForestCat:Cats
    {
        public override string GetName(string name)
        {
            return $"{base.GetName(name)}.Лесной кот";
        }
    }
}