using _03.BarracksFactory.Contracts;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace _03.BarracksFactory.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandSuffix = "Command";

        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix;

            var commandType = Assembly.
                GetExecutingAssembly().
                GetTypes().
                FirstOrDefault(t => t.Name == commandCompleteName);

            var commandParams = new object[]
            {
                data,
                this.repository,
                this.unitFactory
            };

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            return (IExecutable)Activator.CreateInstance(commandType, commandParams);
        }
    }
}
