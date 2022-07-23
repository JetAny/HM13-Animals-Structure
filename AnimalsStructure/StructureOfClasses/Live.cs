using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStructure.StructureOfClasses
{
    internal class Live
    {
        private string titlLive;

        public Live(string titlLive)
        {
            this.titlLive = titlLive;
        }

        public override string ToString()
        {
            return
                $"{titlLive}";
        }
        //public string animalView { get; set; }
        //public string animalGenus { get; set; }
        //public string animalFamily { get; set; }
        //public string animalOrder { get; set; }
        //public string anivalClases { get; set; }
        //public string animalDepartment { get; set; }
        //public string animalKingdom { get; set; }
        //public string animalDomain { get; set; }
        //public string animalLive { get; set; }
        //public string animalName { get; set; }

        //public Live(
        //    string animalView, string animalGenus, string animalFamily, string animalOrder, string anivalClases,
        //   string animalDepartment, string animalKingdom, string animalDomain, string animalLive)
        //{
        //    this.animalView = animalView;
        //    this.animalGenus = animalGenus;
        //    this.animalFamily = animalFamily;
        //    this.animalOrder = animalOrder;
        //    this.anivalClases = anivalClases;
        //    this.animalDepartment = animalDepartment;
        //    this.animalKingdom = animalKingdom;
        //    this.animalDomain = animalDomain;
        //    this.animalLive = animalLive;
        //}
        //public virtual void PrintAnimal(Live animal)
        //{
        //    Console.WriteLine($"Animal name: {animalName}+ {animal.ToString()}");
        //}
    }
}
