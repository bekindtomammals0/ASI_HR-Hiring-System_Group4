namespace Basecode.Data.Models
{
    public class CharacterReference
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Responded { get; set; }
    }
}
