using _11.InfernoInfinity.Factories;
using _11.InfernoInfinity.IO;
using System;
using System.Linq;

namespace _11.InfernoInfinity.Controllers
{
    public class Engine
    {
        private WeaponManager manager;
        private GemFactory gemFactory;
        private InputReader reader;
        private OutputWriter writer;

        public Engine()
        {
            this.manager = new WeaponManager();
            this.gemFactory = new GemFactory();
            this.reader = new InputReader();
            this.writer = new OutputWriter();
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var tokens = input.Split(';');

                var command = tokens[0];

                switch (command)
                {
                    case "Create":
                        this.CreateWeaponCommand(tokens.Skip(1).ToArray());
                        break;
                    case "Add":
                        this.AddGemCommand(tokens.Skip(1).ToArray());
                        break;
                    case "Remove":
                        this.RemoveGemCommand(tokens.Skip(1).ToArray());
                        break;
                    case "Print":
                        this.PrintWeaponCommand(tokens.Skip(1).ToArray());
                        break;
                    default:
                        break;
                }
            }
        }

        private void PrintWeaponCommand(string[] tokenArgs)
        {
            var weaponName = tokenArgs[0];

            Console.WriteLine(this.manager.Print(weaponName));
        }

        private void RemoveGemCommand(string[] tokenArgs)
        {
            var weaponName = tokenArgs[0];
            var socketIndex = int.Parse(tokenArgs[1]);

            this.manager.RemoveGemFromWeapon(weaponName, socketIndex);
        }

        private void AddGemCommand(string[] tokenArgs)
        {
            var weaponName = tokenArgs[0];
            var socketIndex = int.Parse(tokenArgs[1]);
            var gemInfo = tokenArgs[2].Split();
            var gemClarity = gemInfo[0];
            var gemType = gemInfo[1];

            var gem = this.gemFactory.CreateGem(gemType, gemClarity);

            this.manager.AddGemToWeapon(weaponName, socketIndex, gem);
        }

        private void CreateWeaponCommand(string[] tokenArgs)
        {
            var weaponInfo = tokenArgs[0].Split();
            var weaponRarity = weaponInfo[0];
            var weaponType= weaponInfo[1];
            var weaponName = tokenArgs[1];

            this.manager.CreateWeapon(weaponType, weaponName, weaponRarity);
        }
    }
}
