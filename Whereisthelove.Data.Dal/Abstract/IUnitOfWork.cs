using Whereisthelove.Data.Dal.Concrete;

namespace Whereisthelove.Data.Dal.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        IPeopleRepository PeopleRepository { get; set; }
        IAdminRepository AdminRepository { get; set; }
    }
}
