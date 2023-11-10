using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class CouponRepository : GenericRepository<Coupon>, ICouponRepository
    {
        public CouponRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}