namespace PetApp.Models
{
    public class Species
    {
        public int Id { get; set; }

        // cat, dog, bird, etc
        public string Type { get; set; }

        public string Breed { get; set; }

        // Many part of One to Many
        public ICollection<Pet> Pets { get; set; }
    }
}
