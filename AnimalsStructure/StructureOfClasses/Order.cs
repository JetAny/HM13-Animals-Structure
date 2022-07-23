namespace AnimalsStructure.StructureOfClasses
{
    internal class Order
    {

        private string titlOrder;

        public Order(string titlOrder)
        {
            this.titlOrder = titlOrder;
        }

        public override string ToString()
        {
            return
                $"{titlOrder}";
        }
    }
}

