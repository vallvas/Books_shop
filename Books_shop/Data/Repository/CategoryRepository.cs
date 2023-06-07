using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using System.Collections.Generic;

namespace Books_shop.Data.Repository
{
    public class CategoryRepository : IBooksCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
