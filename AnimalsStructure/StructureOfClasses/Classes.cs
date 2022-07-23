using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Classes
    {
        private string titlClasses;

        public Classes(string titlClasses)
        {
            this.titlClasses = titlClasses;
        }

        public override string ToString()
        {
            return
                $"{titlClasses}";
        }
    }
}
