using Microsoft.AspNetCore.Http;

namespace Admin.Models.PeopleViewModel
{
    public class PeopleCEViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string News { get; set; }
        public string Detail { get; set; }
        public string Description { get; set; }
    }
}
