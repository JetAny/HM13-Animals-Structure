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
         
           var animal1= new Animal(
                new View("Ленсной кот"),
                new Genus("Кошки"),
                new Family("Кошачьи"),
                new Order("Хищники"),
                new Classes ("Млекопитающие"),
                new Department ("Хордовые"),
                new Kingdom("Животные"),
                new Domain("Эукариоты"),
                new Live("Живые организмы"));
            animal1.AddAnimalName("Кот Васька");
            Console.WriteLine(animal1);

            var animal2 = new Animal(
               new View("Ленсной кот"),
               new Genus("Кошки"),
               new Family("Кошачьи"),
               new Order("Хищники"),
               new Classes("Млекопитающие"),
               new Department("Хордовые"),
               new Kingdom("Животные"),
               new Domain("Эукариоты"),
               new Live("Живые организмы"));
            animal2.AddAnimalName("Кот Кузя");
            Console.WriteLine(animal2);

            var animal3  = new Animal(
              new View("Волк"),
              new Genus("Волки"),
              new Family("Псовые"),
              new Order("Хищники"),
              new Classes("Млекопитающие"),
              new Department("Хордовые"),
              new Kingdom("Животные"),
              new Domain("Эукариоты"),
              new Live("Живые организмы"));
            animal3.AddAnimalName("Пес бобик");
            Console.WriteLine(animal3);

            var animal4 = new Animal(
              new View("Черный аист"),
              new Genus("Аисты"),
              new Family("Аистовые"),
              new Order("Аистообразные"),
              new Classes("Птицы"),
              new Department("Хордовые"),
              new Kingdom("Животные"),
              new Domain("Эукариоты"),
              new Live("Живые организмы"));
            animal4.AddAnimalName("Аист Борька");
            Console.WriteLine(animal4);
        }
    }
}