using Whereisthelove.Data.Dal.Abstract;

namespace Whereisthelove.Data.Dal.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(EntityContext context, IPeopleRepository peopleRepository,
            IAdminRepository adminRepository)
        {
            Context = context;
            PeopleRepository = peopleRepository;
            AdminRepository = adminRepository;
        }
        public EntityContext Context;
        public IPeopleRepository PeopleRepository { get; set; }
        public IAdminRepository AdminRepository{ get; set; }
        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
