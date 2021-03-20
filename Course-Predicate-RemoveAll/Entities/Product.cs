using System.Globalization;

namespace Course_Predicate_RemoveAll.Entities
{
    class Product
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Product(string title, double price)
        {
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return Title + ", " + Price.ToString("F", CultureInfo.InvariantCulture);
        }
    }
}
