namespace _08.PetClinic.Models
{
    using System;
    using System.Linq;

    public class Clinic
    {
        private readonly int enteringRoom;

        private string name;
        private int numberOfRooms;
        private Room[] rooms;

        public Clinic(string name, int numberOfRooms)
        {
            this.Name = name;
            this.NumberOfRooms = numberOfRooms;
            this.rooms = new Room[numberOfRooms];
            this.enteringRoom = ((int)Math.Ceiling(this.rooms.Length / (double)2)) - 1;

            for (int i = 0; i < this.rooms.Length; i++)
            {
                this.rooms[i] = new Room();
            }
        }

        public int NumberOfRooms
        {
            get { return this.numberOfRooms; }
            private set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                this.numberOfRooms = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public bool AddPet(Pet pet)
        {
            if (!this.HasEmptyRooms())
            {
                return false;
            }

            for (int i = 0; i <= this.enteringRoom; i++)
            {
                if (this.rooms[this.enteringRoom - i].Pet == null)
                {
                    this.rooms[this.enteringRoom - i].Pet = pet;
                    return true;
                }

                if (this.rooms[this.enteringRoom + i].Pet == null)
                {
                    this.rooms[this.enteringRoom + i].Pet = pet;
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            for (int i = this.enteringRoom; i < this.rooms.Length; i++)
            {
                if (this.rooms[i].Pet != null)
                {
                    this.rooms[i].Pet = null;
                    return true;
                }
            }

            for (int i = 0; i < this.enteringRoom; i++)
            {
                if (this.rooms[i].Pet != null)
                {
                    this.rooms[i].Pet = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.rooms.Any(r => r.Pet == null);
        }

        public void PrintAllRooms()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.rooms.ToList()));
        }

        public void PrintRoom(int roomID)
        {
            Console.WriteLine(this.rooms[roomID - 1].ToString());
        }
    }
}
