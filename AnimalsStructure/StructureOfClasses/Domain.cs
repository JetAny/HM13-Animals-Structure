using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Domain
    {
        private string titlDomain;

        public Domain(string titlDomain)
        {
            this.titlDomain = titlDomain;
        }

        public override string ToString()
        {
            return
                $"{titlDomain}";
        }
    }
}
