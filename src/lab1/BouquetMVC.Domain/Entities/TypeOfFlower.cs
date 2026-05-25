namespace BouquetMVC.Domain.Entities
{
    public class TypeOfFlower : Entity
    {
        public string Name { get; private set; }

        public string Color { get; private set; }

        public int? Height { get; private set; }

        public decimal Price { get; private set; }

        private TypeOfFlower()
        {
        }

        public TypeOfFlower(string name, string color, int? height, decimal price)
        {
            Name = name;
            Color = color;
            Height = height;
            Price = price;
        }
    }
}