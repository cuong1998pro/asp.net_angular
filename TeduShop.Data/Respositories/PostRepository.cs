using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Models.Models;

namespace TeduShop.Data.Respositories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Product>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}