using BusinessObject;

namespace DataAccess
{
    public class ProductDAO
    {
        private static readonly object _locker = new object();
        private static ProductDAO _instance = null;
        SalesContext context = new SalesContext();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductDAO();
                    }
                    return _instance;
                }
            }
        }

        public void UpdateQuantity(ShoppingCart cart)
        {
            List<CartItem> cartItems = cart.GetCart();
            foreach (var item in cartItems)
            {
                var product = GetProductByID(item.ProductID);
                product.UnitsInStock -= item.Quantity;
                context.Update(product);
            }
            context.SaveChanges();
        }
        public List<Product> GetProducts()
        {
            List<Product> products = context.Products.ToList();
            return products;
        }
        public Product GetProductByID(int productID)
        {
            return context.Products.FirstOrDefault(p => p.ProductId == productID);
        }

        // Search by id, name, price, unit in stock
        public List<Product> SearchProduct(int id, string? name, decimal unitPrice, int unitInstock)
        {
            return context.Products.Where(p => p.ProductId == id
        || p.ProductName.Contains(name)
        || p.UnitPrice == unitPrice
        || p.UnitsInStock == unitInstock).ToList();
        }
        public void CreateProduct(Product product)
        {
            Product p = GetProductByID(product.ProductId);
            var fstorecontext = new SalesContext();
            if (p == null)
            {
                fstorecontext.Products.Add(product);
                fstorecontext.SaveChanges();
            }
            else
            {
                throw new Exception("Product existed");
            }
        }
        public void DeleteProduct(int productID)
        {
            Product p = GetProductByID(productID);
            var fstorecontext = new SalesContext();
            if (p != null)
            {
                fstorecontext.Products.Remove(p);
                fstorecontext.SaveChanges();
            }
            else
            {
                throw new Exception("Product is not existed");
            }
        }

        public void UpdateProduct(Product product)
        {
            Product oldProduct = GetProductByID(product.ProductId);
            if (product != null)
            {
                oldProduct.ProductId = product.ProductId;
                oldProduct.ProductName = product.ProductName;
                oldProduct.CategoryId = product.CategoryId;
                oldProduct.UnitPrice = product.UnitPrice;
                oldProduct.UnitsInStock = product.UnitsInStock;
                oldProduct.Weight = product.Weight;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Product is not existed");
            }
        }

        public int GetMaxProductID()
        {
            return context.Products.Max(p => p.ProductId);
        }
    }
}
