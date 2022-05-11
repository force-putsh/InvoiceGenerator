namespace InvoiceApi.Models
{
    public class ProductRepository : IProductRepository
    {
        readonly InnovationDBContext _conext;

        public ProductRepository(InnovationDBContext context)
        {
            _conext = context;
        }

        //Recuperer tous les produits

        public IEnumerable<Product> GetAllProducts()
        {
            return _conext.Products;
        }

        //Reucpéré tous les produits par CategoriId

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _conext.Products.Where(p => p.CategoryId == categoryId);
        }

        //Recuperer un produit par son id

        public Product GetProductById(int id)
        {
            return _conext.Products.FirstOrDefault(p => p.ProductId == id);
        }

        //Ajouter un produit

        public Product AddProduct(Product product)
        {
            _conext.Products.Add(product);
            _conext.SaveChanges();
            return product;
        }

        //Modifier un produit et retourner true si le produit a ete modifiee

        public bool UpdateProduct(Product product)
        {
            var _product = _conext.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (_product != null)
            {
                _product.ProductName = product.ProductName;
                _product.CategoryId = product.CategoryId;
                _product.UnitPrice = product.UnitPrice;
                _conext.SaveChanges();
                return true;
            }
            return false;
        }

        //Supprimer un produit

        public bool DeleteProduct(int id)
        {
            var _product = _conext.Products.FirstOrDefault(p => p.ProductId == id);
            if (_product != null)
            {
                _conext.Products.Remove(_product);
                _conext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
