using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{

    internal class View
    {

        private string titleView;


        public View(string titleView)
        {
            this.titleView = titleView;
        }
        
        public override string ToString()
        {
            return 
                $" {titleView}";
        }
    }
}
