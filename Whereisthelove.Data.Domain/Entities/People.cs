namespace Whereisthelove.Data.Domain.Entities
{
    public class People : BaseGuidEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string News { get; set; }
        public string Title { get; set; }
    }
}
