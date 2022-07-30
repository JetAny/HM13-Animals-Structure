
using AnimalsStructure2;

ForestCat cat1=new ForestCat();
ForestCat cat2=new ForestCat();

 Console.WriteLine( cat1.GetName("Кот Васька"));
Console.WriteLine(cat1.GetName("Кошка Мурка"));

Wolves dog1=new Wolves();
Console.WriteLine(dog1.GetName("Пес Бобик"));

Herons herons1=new Herons();
Console.WriteLine(herons1.GetName("Цапля Борька"));

var cat3=new Predatory();
Console.WriteLine(cat3.GetName("Кот Кузя"));

var herons2=new Birds();
Console.WriteLine(herons2.GetName("Цапля Василиса"));
