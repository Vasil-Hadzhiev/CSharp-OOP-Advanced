using _02.CoffeeMachine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CoffeeMachine
{
    public class CoffeeMachine
    {
        private IList<Coin> coins;
        private IList<CoffeeType> coffeesSold;

        public CoffeeMachine()
        {
            this.coins = new List<Coin>();
            this.coffeesSold = new List<CoffeeType>();
        }

        public IEnumerable<CoffeeType> CoffeesSold
        {
            get { return this.coffeesSold; }
        }

        public void BuyCoffee(string size, string type)
        {
            var coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
            var coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

            if (this.coins.Sum(c => (int)c) >= (int)coffeePrice)
            {
                this.coffeesSold.Add(coffeeType);

                this.coins.Clear();
            }
        }

        public void InsertCoin(string coin)
        {
            var currentCoin = (Coin)Enum.Parse(typeof(Coin), coin);
            this.coins.Add(currentCoin);
        }
    }
}
