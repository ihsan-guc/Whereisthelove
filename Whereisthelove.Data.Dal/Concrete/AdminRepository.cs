using Whereisthelove.Data.Dal.Abstract;
using Whereisthelove.Data.Domain.Entities;

namespace Whereisthelove.Data.Dal.Concrete
{
    public interface IAdminRepository : IEfRepository<ApplicationAdmin>
    {

    }
    public class AdminRepository : EfRepository<ApplicationAdmin>, IAdminRepository
    {
        public AdminRepository(EntityContext context):base(context)
        {

        }
    }
}
