using PetApp.Models;

namespace PetApp.Interface
{
    public interface iPetRepository
    {
        // API call
        ICollection<Pet> GetPets();
    }
}
