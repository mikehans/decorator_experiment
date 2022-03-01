namespace CoffeeCalculator;
public class Beverage
{
    public string Description { get; set; }
    
    public Beverage()
    {
        Description = "A bevvie!";
    }

    public virtual decimal Cost(){
        return 1;
    }
}

public class DarkRoast: Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast";
    }

    public override decimal Cost()
    {
        return 2;
    }
}

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf (why?)";
    }

    public override decimal Cost()
    {
        return 1.5M;
    }
}
