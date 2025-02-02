namespace APIConcepts.Services
{
    public interface IProductService
    {
        IEnumerable<string> GetProducts();
        string GetProductById(int id);
        void AddProduct(string product);
        void UpdateProduct(int id, string product);
        void DeleteProduct(int id);
    }

}
