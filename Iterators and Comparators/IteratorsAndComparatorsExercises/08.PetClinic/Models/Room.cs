namespace _08.PetClinic.Models
{
    public class Room
    {
        public Room()
        {            
        }

        public Pet Pet { get; set; }

        public override string ToString()
        {
            if (this.Pet == null)
            {
                return "Room empty";
            }

            return this.Pet.ToString();
        }
    }
}
