using CoffeeCalculator;

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