namespace Chap03_Proprietes 
{
    public class Product 
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal Price { get; set; }
        public string Name { get; private set; }
        public decimal ProfitMargin { get; set;}
        public decimal SalePrice 
        {
            get => Price * ProfitMargin;
        }
    }
}