using CoffeeCalculator;

namespace CoffeeCalculator.API;
public class CoffeeBuilder2
{
    Beverage beverage;

    public CoffeeBuilder2(CoffeeBlend blend)
    {
        switch (blend)
        {
            case CoffeeBlend.DarkRoast:
                beverage = new DarkRoast();
                break;
            case CoffeeBlend.Decaf:
                beverage = new Decaf();
                break;
            default: throw new ArgumentException("Invalid selection");
        }
    }

    public CoffeeBuilder2 With(Condiment condiment)
    {
        switch (condiment)
        {
            case Condiment.Milk:
                beverage = new Milk(beverage);
                break;
            case Condiment.Mocha:
                beverage = new Mocha(beverage);
                break;
            default: throw new ArgumentException("Condiment doesn't exist");
        }
        return this;
    }

    public Beverage Make()
    {
        return beverage;
    }

}

