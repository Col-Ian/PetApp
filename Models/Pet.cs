namespace PetApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Brithday { get; set; }
        public float Weight { get; set; }

        // One part of One to Many
        public Species Species { get; set; }

        // Many part of One to Many
        public ICollection<History> Histories { get; set; }

        // Many to Many
        public ICollection<PetOwner> PetOwners { get; set; }
    }
}
