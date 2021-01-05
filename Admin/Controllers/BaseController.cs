using Admin.Core;
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
        private IFileManager fileManager;
        public IFileManager FileManager
        {
            get
            {
                if (fileManager == null)
                    fileManager = (IFileManager)HttpContext.RequestServices.GetService(typeof(IFileManager));
                return fileManager;
            }
        }
    }
}
