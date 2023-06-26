namespace PetApp.Models
{
    public class Veterinarian
    {
        public int Id { get; set; }

        // Information of the Vet who saw the pet.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Many part of One to Many
        public ICollection<History> Histories { get; set; }
    }
}
