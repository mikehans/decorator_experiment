using CoffeeCalculator;

namespace CoffeeCalculator.API;
public class CoffeeBuilder
{
    Beverage beverage;

    // coffeeBuilder.choose(DarkRoast).with(milk).with(mocha);
    public CoffeeBuilder choose(CoffeeBlend blend)
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

        return this;
    }

    public CoffeeBuilder with(Condiment condiment)
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

    public Beverage GetSpecification(){
        return beverage;
    }

}

public enum CoffeeBlend
{
    DarkRoast,
    Decaf
}

public enum Condiment
{
    Milk,
    Mocha
}