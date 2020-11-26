using Microsoft.AspNetCore.Mvc;
using Whereisthelove.Data.Dal.Abstract;

namespace Admin.Controllers
{
    public class BaseController : Controller
    {
        public IUnitOfWork unitOfWork;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (unitOfWork == null)
                    unitOfWork = (IUnitOfWork)HttpContext.RequestServices.GetService(typeof(IUnitOfWork)); 
                return unitOfWork;
            }
        }
    }
}
