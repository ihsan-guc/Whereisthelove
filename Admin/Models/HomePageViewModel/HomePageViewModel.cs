using System.Collections.Generic;
using Whereisthelove.Data.Domain.Entities;

namespace Admin.Models.HomePageViewModel
{
    public class HomePageViewModel : BaseHomeViewModel<DeathDate>
    {
        public HomePageViewModel()
        {
            PeopleList = new List<People>();
            DeathDateList = new List<DeathDate>();
        }
        public List<People> PeopleList{ get; set; }
        public List<DeathDate> DeathDateList{ get; set; }
    }
}
