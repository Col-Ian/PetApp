namespace PetApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        // Many part of One to Many
        public ICollection<Owner> Owners { get; set; }
    }
}
