namespace Whereisthelove.Data.Domain.Entities
{
    public class ApplicationAdmin : BaseGuidEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
