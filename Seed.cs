// Mock Data to inject

using PetApp.Data;
using PetApp.Models;

namespace PetApp
{
    // Seed info into the DB
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void SeedDataContext()
        {
            var petOwners = new List<PetOwner>()
            {
                new PetOwner()
                {
                    Pet = new Pet()
                    {
                        Name = "Archie",
                        Brithday = new DateTime(2022,2,27),
                        Weight = 17.3F,
                        Species = new Species()
                        {
                            Type = "Dog",
                            Breed = "Cavalier King Charles Spaniel"
                        },
                        Histories = new List<History>()
                        {
                            new History
                            {
                                DateOfVisit = new DateTime(2022,5,25),
                                ReasonOfVisit = "3 month vaccination needles.",
                                Veterinarian = new Veterinarian(){ FirstName = "John", LastName = "Smith"}
                            }
                        }
                    },
                    Owner = new Owner()
                    {
                        FirstName = "Ian",
                        LastName = "Collins",
                        PhoneNumber = "709-123-1234",
                        Address = new Address()
                        {
                            City = "St. John's",
                            StreetAddress = "123 Street St.",
                            Province = "NL",
                            PostalCode = "A1A 2B2"
                        }
                    }
                },
                new PetOwner()
                {
                    Pet = new Pet()
                    {
                        Name = "Ruby",
                        Brithday = new DateTime(2012,6, 26),
                        Weight = 18.2F,
                        Species = new Species()
                        {
                            Type = "Dog",
                            Breed = "Cavalier King Charles Spaniel"
                        },
                        Histories = new List<History>()
                        {
                            new History
                            {
                                DateOfVisit = new DateTime(2013,3,14),
                                ReasonOfVisit = "Hysterectomy.",
                                Veterinarian = new Veterinarian(){ FirstName = "Jane", LastName = "Thompson"}
                            },
                            new History
                            {
                                DateOfVisit = new DateTime(2018,6,23),
                                ReasonOfVisit = "Tick prevention treatment.",
                                Veterinarian = new Veterinarian(){ FirstName = "Jane", LastName = "Thompson"}
                            }
                        }
                    },
                    Owner = new Owner()
                    {
                        FirstName = "Ian",
                        LastName = "Collins",
                        PhoneNumber = "709-123-1234",
                        Address = new Address()
                        {
                            City = "St. John's",
                            StreetAddress = "123 Street St.",
                            Province = "NL",
                            PostalCode = "A1A 2B2"
                        }
                    }
                },
                new PetOwner()
                {
                    Pet = new Pet()
                    {
                        Name = "Charlie",
                        Brithday = new DateTime(2018,9,12),
                        Weight = 15.6F,
                        Species = new Species()
                        {
                            Type = "Cat",
                            Breed = "Ragdoll"
                        },
                        Histories = new List<History>()
                        {
                            new History
                            {
                                DateOfVisit = new DateTime(2019,10,16),
                                ReasonOfVisit = "Tick prevention treatment.",
                                Veterinarian = new Veterinarian(){ FirstName = "John", LastName = "Smith"}
                            }
                        }
                    },
                    Owner = new Owner()
                    {
                        FirstName = "Jordon",
                        LastName = "Hoffman",
                        PhoneNumber = "709-456-6543",
                        Address = new Address()
                        {
                            City = "Mount Pearl",
                            StreetAddress = "78 Palace Pl.",
                            Province = "NL",
                            PostalCode = "C3C 4D4"
                        }
                    }
                }
            };
        }
    }
}
