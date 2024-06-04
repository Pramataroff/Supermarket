namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string duma = null;
            do
            {
                Console.Write("Want to add product (yes/stocked): ");
                duma = Console.ReadLine();
                if (duma == "stocked")
                {

                }
                else
                {
                    Console.Write("name: ");
                    string name = Console.ReadLine();
                    Console.Write("price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("quantity: ");
                    double quantity = double.Parse(Console.ReadLine());
                    Product product1 = new Product(name, price, quantity);
                    product1.QuantityPrice = product1.Quantity * product1.Price;
                    Product.Sum += product1.QuantityPrice;
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Name == name)
                        {
                            products.RemoveAt(i);

                        }
                    }
                    products.Add(product1);
                }

            } while (duma != "stocked");
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Pechat();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Total: {Product.Sum:F2}");
        }
    }
}        
