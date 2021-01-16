using Whereisthelove.Data.Dal.Abstract;
using Whereisthelove.Data.Domain.Entities;

namespace Whereisthelove.Data.Dal.Concrete
{
    public interface IDeathDateRepository : IEfRepository<DeathDate>
    {

    }
    public class DeathDateRepository : EfRepository<DeathDate>, IDeathDateRepository
    {
        public DeathDateRepository(EntityContext context):base(context)
        {

        }
    }
}
