using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Models.Models;

namespace TeduShop.Data.Respositories
{
    public interface IPostCategoryRepository
    {
    }

    public class PostCategoryRepository : RepositoryBase<Product>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}