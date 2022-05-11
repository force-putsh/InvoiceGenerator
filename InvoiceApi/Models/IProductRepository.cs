namespace InvoiceApi.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
        Product GetProductById(int id);
        Product AddProduct(Product item);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        
    }
}
