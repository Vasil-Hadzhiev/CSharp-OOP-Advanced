namespace _08.MilitaryElite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Models;

    public class Engine
    {
        private List<ISoldier> army;

        public Engine()
        {
            this.army = new List<ISoldier>();
        }

        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var tokens = input.Split();

                var soldier = tokens[0];
                var id = tokens[1];
                var firstName = tokens[2];
                var lastName = tokens[3];
                var salary = 0d;
                var code = 0;
                var corps = string.Empty;

                switch (soldier)
                {
                    case "Private":
                        salary = double.Parse(tokens[4]);
                        var privatee = new Private(id, firstName, lastName, salary);
                        army.Add(privatee);
                        break;
                    case "Spy":
                        code = int.Parse(tokens[4]);
                        var spy = new Spy(id, firstName, lastName, code);
                        army.Add(spy);
                        break;
                    case "LeutenantGeneral":
                        salary = double.Parse(tokens[4]);
                        var privates = GetPrivate(tokens);
                        var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary, privates);
                        army.Add(leutenantGeneral);
                        break;
                    case "Engineer":
                        salary = double.Parse(tokens[4]);
                        corps = tokens[5];
                        if (corps != "Airforces" && corps != "Marines")
                        {
                            break;
                        }
                        var repairParts = GetRepairParts(tokens);
                        var engineer = new Engineer(id, firstName, lastName, salary, corps, repairParts);
                        army.Add(engineer);
                        break;
                    case "Commando":
                        salary = double.Parse(tokens[4]);
                        corps = tokens[5];
                        if (corps != "Airforces" && corps != "Marines")
                        {
                            break;
                        }
                        var missions = GetMissions(tokens);
                        var commando = new Commando(id, firstName, lastName, salary, corps, missions);
                        army.Add(commando);
                        break;
                }
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }

        private IList<IMission> GetMissions(string[] tokens)
        {
            var missions = new List<IMission>();

            for (int i = 6; i < tokens.Length - 1; i += 2)
            {
                var name = tokens[i];
                var state = tokens[i + 1];
                if (state != "Finished" && state != "inProgress")
                {
                    continue;
                }
                var mission = new Mission(name, state);

                missions.Add(mission);
            }

            return missions;
        }

        private IList<IRepair> GetRepairParts(string[] tokens)
        {
            var repairParts = new List<IRepair>();

            for (int i = 6; i < tokens.Length - 1; i += 2)
            {
                var part = tokens[i];
                var hours = int.Parse(tokens[i + 1]);
                var repair = new Repair(part, hours);

                repairParts.Add(repair);
            }

            return repairParts;
        }

        private IList<ISoldier> GetPrivate(string[] tokens)
        {
            var privates = new List<ISoldier>();

            for (int i = 5; i < tokens.Length; i++)
            {
                var currentPrivate = army.
                    First(p => p.ID == tokens[i]);

                privates.Add(currentPrivate);
            }

            return privates;
        }
    }
}