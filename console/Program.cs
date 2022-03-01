using CoffeeCalculator;
using CoffeeCalculator.API;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var beverage = new Beverage();
System.Console.WriteLine(beverage.Description);

var darkRoast = new DarkRoast();
System.Console.WriteLine(darkRoast.Description);
System.Console.WriteLine(darkRoast.Cost());

var decaf = new Decaf();
System.Console.WriteLine(decaf.Description);
System.Console.WriteLine(decaf.Cost());

var milk = new Milk(darkRoast);
System.Console.WriteLine(milk.Description);
System.Console.WriteLine(milk.Cost());

Mocha mocha = new Mocha(darkRoast);
System.Console.WriteLine(mocha.Description);
System.Console.WriteLine(mocha.Cost());

Mocha mochaDarkRoastWithMilk = new Mocha(milk); 
System.Console.WriteLine(mochaDarkRoastWithMilk.Description);
System.Console.WriteLine(mochaDarkRoastWithMilk.Cost());


// Use the Fluent API
System.Console.WriteLine("Using the Fluent API");
CoffeeBuilder builder = new CoffeeBuilder();
builder.choose(CoffeeBlend.DarkRoast).with(Condiment.Milk);
Beverage builtBeverage = builder.GetSpecification();
System.Console.WriteLine(builtBeverage.Description);
System.Console.WriteLine(builtBeverage.Cost());

CoffeeBuilder builder2 = new CoffeeBuilder();
builder2.choose(CoffeeBlend.Decaf).with(Condiment.Milk).with(Condiment.Mocha);
Beverage builtBeverage2 = builder2.GetSpecification();
System.Console.WriteLine(builtBeverage2.Description);
System.Console.WriteLine(builtBeverage2.Cost());