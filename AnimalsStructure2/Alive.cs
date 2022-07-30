using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure2
{
    internal class Alive
    {
        public virtual string GetName(string name)
        {
            return $"{name}: Живые";
        }
    }
}
