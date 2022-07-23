using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Family
    {
        private string titlFamily;

        public Family(string titlFamily)
        {
            this.titlFamily = titlFamily;
        }

        public override string ToString()
        {
            return
                $"{titlFamily}";
        }
    }
}
