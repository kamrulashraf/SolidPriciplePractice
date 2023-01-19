// See https://aka.ms/new-console-template for more information
using Liskov_substitution_principle.Dontaskinstancetype;
using Liskov_substitution_principle.Example;
using System.ComponentModel;

Console.WriteLine("Hello, World!");


List<Vehicle> list = new List<Vehicle>();
list.Add(new Car());
list.Add(new RacingCar());


foreach (var l in list)
{
    Console.WriteLine(l.GetInterioWidth());
}




// don't ask for instance type

List<Product> products = new List<Product>();
products.Add(new Product());
products.Add(new InHouseProduct());

foreach (var product in products) {
    double discount = 0;
    if (product.GetType() == typeof(InHouseProduct)) {
        discount = (product as InHouseProduct).GetExtraDiscount();
    }
    discount += product.GetDiscount();

    Console.WriteLine(discount);
}


// instead of tell the isntant type

foreach(var product in products)
{
    double discount = 0;
    discount = product.GetDiscount(); // add extra discount in the GetDiscount method
    Console.WriteLine(discount);
}