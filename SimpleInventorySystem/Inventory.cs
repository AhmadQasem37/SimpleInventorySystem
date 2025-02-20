namespace SimpleInventorySystem
{
    class Inventory
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void ViewAllProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product);
            }
        }
        public void EditProduct(string name)
        {
            Product product = null;
            foreach (var p in _products)
            {
                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    product = p;
                    break;
                }
            }

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter new price: ");
            decimal newPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Enter new quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());

            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQuantity;

            Console.WriteLine("Product updated successfully.");
        }
    }
}