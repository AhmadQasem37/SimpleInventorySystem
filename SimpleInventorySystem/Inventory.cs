namespace SimpleInventorySystem
{
    class Inventory 
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ViewAllProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}