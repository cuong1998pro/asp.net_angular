using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Models.Models;

namespace TeduShop.Data.Respositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Product>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}