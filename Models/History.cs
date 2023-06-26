namespace PetApp.Models
{
    public class History
    {
        public int Id { get; set; }

        // When visit occurred
        public DateTime DateOfVisit { get; set; }

        // Brief description of the purpose of the visit.
        public string ReasonOfVisit { get; set; }

        // One parts of One to Many
        public Pet Pet { get; set; }

        public Veterinarian Veterinarian { get; set; }
    }
}
