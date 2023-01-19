// See https://aka.ms/new-console-template for more information

// calculate insurance information

using Solid_Priciple;
using Solid_Priciple.AbstractClassEample;
using Solid_Priciple.Extension;
using Solid_Priciple.FunctionParameterExample;
using Solid_Priciple.InterfaceExample;

DiscountCalculator cal = new DiscountCalculator(new HealthInsuranceCustomerProfile());

Console.WriteLine(cal.GetDiscount());


Course course = new OnlineCourse();
course.Subscribe();


CalculateSalary calSalObje = new CalculateSalary();

Func<double, double> salFunc = (total) =>
{
    if(total > 1000)
    {
        return total * .2;
    }
    else
    {
        return total * .10;
    }
};

double sal = calSalObje.GetSalary(salFunc);
Console.WriteLine(sal);



string temp = "test";
Console.WriteLine(temp.RemoveFirstChar());


