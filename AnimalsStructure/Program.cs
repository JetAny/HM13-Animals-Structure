using AnimalsStructure.StructureOfClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalsStructure
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
         
           var cat= new Animal(
                new View("Ленсной кот"),
                new Genus("Кошки"),
                new Family("Кошачьи"),
                new Order("Хищники"),
                new Classes ("Млекопитающие"),
                new Department ("Хордовые"),
                new Kingdom("Животные"),
                new Domain("Эукариоты"),
                new Live("Живые организмы"));
            cat.AddAnimalName("Васька");
            Console.WriteLine(cat);
        }
    }
}