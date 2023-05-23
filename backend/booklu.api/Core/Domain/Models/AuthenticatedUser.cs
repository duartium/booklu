namespace booklu.api.Core.Domain.Models
{
    public class AuthenticatedUser
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string CreatedAt { get; set; }
        public int ProfileId { get; set; }
        public string VerifiedAt { get; set; }
    }
}
