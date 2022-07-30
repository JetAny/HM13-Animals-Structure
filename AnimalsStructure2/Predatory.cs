namespace AnimalsStructure2
{
    internal class Predatory : Mammals
    {
        public override string GetName(string name)
        {
            return $"{base.GetName(name)}.Хищные";
        }
    }
}
