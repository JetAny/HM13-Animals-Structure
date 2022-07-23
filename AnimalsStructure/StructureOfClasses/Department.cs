using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Department
    {
        private string titlDepartment;

        public Department(string titlDepartment)
        {
            this.titlDepartment = titlDepartment;
        }

        public override string ToString()
        {
            return
                $"{titlDepartment}";
        }
    }
}
