namespace APIConcepts.Services
{
    public class ProductService : IProductService
    {
        private readonly List<string> _products;

        public ProductService()
        {
            _products = new List<string> { "Product1", "Product2", "Product3" };
        }

        public IEnumerable<string> GetProducts()
        {
            return _products;
        }

        public string GetProductById(int id)
        {
            if (id < 0 || id >= _products.Count)
            {
                return null;
            }
            return _products[id];
        }

        public void AddProduct(string product)
        {
            _products.Add(product);
        }

        public void UpdateProduct(int id, string product)
        {
            if (id < 0 || id >= _products.Count)
            {
                return;
            }
            _products[id] = product;
        }

        public void DeleteProduct(int id)
        {
            if (id < 0 || id >= _products.Count)
            {
                return;
            }
            _products.RemoveAt(id);
        }
    }

}
