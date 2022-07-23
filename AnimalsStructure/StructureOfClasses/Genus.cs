using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Genus
    {
        private string titleGenus { get; set; }

        public Genus(string titleGenus)
        {
            this.titleGenus = titleGenus;
        }

        public override string ToString()
        {
            return
                $"{titleGenus}";
        }
    }
}
