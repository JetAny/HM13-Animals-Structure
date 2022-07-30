namespace AnimalsStructure2
{
    internal class Cats : Predatory

    {
        public override string GetName(string name)
        {
            return $"{base.GetName(name)}.Кошачи";
        }
    }
}
