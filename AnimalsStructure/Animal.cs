using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnimalsStructure.StructureOfClasses;
namespace AnimalsStructure
    
{
    internal class Animal
    { 
        public View _view { get; set; }
        public Genus _genus { get; set; }
        public Family _family { get; set; }
        public Order _order { get; set; }
        public Classes _classes { get; set; }
        public Department _department { get; set; }
        public Kingdom _kingdom { get; set; }
        public Domain _domain { get; set; }
        public Live _live { get; set; }

        private string _animalName { get; set; }

        public Animal(View view, Genus genus,Family family,Order order,Classes classes,Department department,Kingdom kingdom, Domain domain,Live live)
        {
            _view = view;
            _genus = genus;
            _family = family;
            _order = order;
            _classes = classes;
            _department = department;
            _kingdom = kingdom;
            _domain = domain;
            _live = live;          
        }
        List<string> animalNames = new List<string>()
        {
        };

        public void AddAnimalName(string animalName)
        {
             animalNames.Add(animalName);
            _animalName = animalNames[0];
        }

        public override string ToString()
        {
            return $"Имя:   {_animalName}\n" +
                $"Вид: {_view}\n" +
                $"Род: {_genus}\n" +
                $"Семейство: {_family}\n" +
                $"Отряд: {_order}\n" +
                $"Класс: {_classes}\n" +
                $"Тип: {_department}\n" +
                $"Царство: {_kingdom}\n" +
                $"Домен: {_domain}\n"+
                $"Жизнь: {_kingdom}\n";
        }

    }
}
