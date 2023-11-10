using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class OrderInfoRepository : GenericRepository<OrderInfo>, IOrderInfoRepository
    {
        public OrderInfoRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}