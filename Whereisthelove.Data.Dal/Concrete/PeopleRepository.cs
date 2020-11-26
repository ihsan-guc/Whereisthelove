using Whereisthelove.Data.Dal.Abstract;
using Whereisthelove.Data.Domain.Entities;

namespace Whereisthelove.Data.Dal.Concrete
{
    public interface IPeopleRepository : IEfRepository<People>
    {

    }
    public class PeopleRepository : EfRepository<People>, IPeopleRepository
    {
        public PeopleRepository(EntityContext context):base(context)
        {

        }
    }
}
