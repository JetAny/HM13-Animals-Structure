using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Kingdom
    {
        private string titlKingdom;

        public Kingdom(string titlKingdom)
        {
            this.titlKingdom = titlKingdom;
        }

        public override string ToString()
        {
            return
                $"{titlKingdom}";
        }
    }
}
