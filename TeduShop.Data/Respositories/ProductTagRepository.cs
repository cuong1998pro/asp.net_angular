using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Models.Models;

namespace TeduShop.Data.Respositories
{
    public interface IProductTagRepository
    {
    }

    public class ProductTagRepository : RepositoryBase<Product>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}