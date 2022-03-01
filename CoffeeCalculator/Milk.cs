namespace CoffeeCalculator
{
    public class Milk : Beverage, ICondiment
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = beverage.Description + " with milk";
        }

        public override decimal Cost()
        {
            return beverage.Cost() + 0.2M;
        }
    }

    public class Mocha: Beverage, ICondiment
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = beverage.Description + " with yummy mocha";
        }

        public override decimal Cost()
        {
            return beverage.Cost() + 0.3M;
        }
    }
}