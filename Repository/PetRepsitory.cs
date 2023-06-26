using PetApp.Data;
using PetApp.Interface;
using PetApp.Models;

namespace PetApp.Repository
{
    public class PetRepsitory : iPetRepository
    {
        // Use repository to get our database calls
        private readonly DataContext _context;
        public PetRepsitory(DataContext context)
        {
            _context = context;
        }

        // ICollection cannot be edited and can only be shown/read
        public ICollection<Pet> GetPets()
        {
            return _context.Pets.OrderBy(p => p.Id).ToList();
        }
    }
}
