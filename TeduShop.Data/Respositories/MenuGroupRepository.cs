using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Models.Models;

namespace TeduShop.Data.Respositories
{
    public interface IMenuGroupRepository
    {
    }

    public class MenuGroupRepository : RepositoryBase<Product>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}