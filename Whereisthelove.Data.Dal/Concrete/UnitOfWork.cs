using Whereisthelove.Data.Dal.Abstract;

namespace Whereisthelove.Data.Dal.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(EntityContext context, IPeopleRepository peopleRepository,
            IAdminRepository adminRepository, IDeathDateRepository deathDateRepository)
        {
            Context = context;
            PeopleRepository = peopleRepository;
            AdminRepository = adminRepository;
            DeathDateRepository = deathDateRepository;
        }
        public EntityContext Context;
        public IPeopleRepository PeopleRepository { get; set; }
        public IAdminRepository AdminRepository{ get; set; }
        public IDeathDateRepository DeathDateRepository{ get; set; }
        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
