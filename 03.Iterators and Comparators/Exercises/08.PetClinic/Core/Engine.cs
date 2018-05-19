namespace _08.PetClinic.Core
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<Pet> pets;
        private List<Clinic> clinics;

        public Engine()
        {
            this.pets = new List<Pet>();
            this.clinics = new List<Clinic>();
        }

        public void Run()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];
                var name = string.Empty;
                Clinic clinic = null;
                Pet pet = null;


                switch (command)
                {
                    case "Create":
                        if (input.Length > 4)
                        {
                            pet = CreatePet(input);
                            this.pets.Add(pet);
                        }
                        else
                        {
                            clinic = CreateClinic(input);
                            this.clinics.Add(clinic);
                        }
                        break;
                    case "Add":
                        var petToAdd = this.pets.
                            First(p => p.Name == input[1]);

                        clinic = this.clinics.
                            First(c => c.Name == input[2]);

                        Console.WriteLine(clinic.AddPet(petToAdd));
                        break;
                    case "Release":
                        clinic = this.clinics.
                            First(c => c.Name == input[1]);

                        Console.WriteLine(clinic.Release());
                        break;
                    case "HasEmptyRooms":
                        clinic = this.clinics.
                            First(c => c.Name == input[1]);
                        Console.WriteLine(clinic.HasEmptyRooms());
                        break;
                    case "Print":
                        clinic = this.clinics.
                            First(c => c.Name == input[1]);                     

                        if (input.Length > 2)
                        {
                            var roomID = int.Parse(input[2]);
                            clinic.PrintRoom(roomID);
                        }                          
                        else
                        {
                            clinic.PrintAllRooms();                           
                        }
                        break;
                }
            }

        }

        private Clinic CreateClinic(string[] input)
        {
            var name = input[2];
            var numberOfRooms = int.Parse(input[3]);

            return new Clinic(name, numberOfRooms);
        }

        private Pet CreatePet(string[] input)
        {
            var name = input[2];
            var age = int.Parse(input[3]);
            var kind = input[4];

            return new Pet(name, age, kind);
        }
    }
}