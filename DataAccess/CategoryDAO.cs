using BusinessObject;
using BusinessObject.Models;
namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        private static readonly object locker = new object();
        private FStoreDBContext context = new FStoreDBContext();
        public static CategoryDAO Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Category> getCategories()
        {
            return context.Categories.ToList();
        }
    }
}
