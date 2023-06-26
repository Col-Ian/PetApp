namespace PetApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        // One part of One to Many
        public Address Address { get; set; }

        // Many to Many
        public ICollection<PetOwner> PetOwners { get; set; }
    }
}
