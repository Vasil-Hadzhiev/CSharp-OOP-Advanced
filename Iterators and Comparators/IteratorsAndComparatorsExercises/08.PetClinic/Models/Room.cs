using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PetClinic.Models
{
    public class Room
    {
        public Room()
        {
            this.Pets = new List<Pet>();
        }

        public List<Pet> Pets { get; set; }
    }
}
