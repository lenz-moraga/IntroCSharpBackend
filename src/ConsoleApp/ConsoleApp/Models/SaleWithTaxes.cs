using ConsoleApp.Interfaces;

namespace ConsoleApp.Models
{
    // This is a class definition in C# with a primary constructor.
    class SaleWithTaxes(decimal total, decimal? additionalTaxes = null) : Sale(total), ISale
    // This line defines a class named SaleWithTaxes that inherits from the Sale class.
    // The primary constructor takes two parameters: total and additionalTaxes,
    // where additionalTaxes is optional and defaults to null.
    {
        public decimal Tax { get; set; } = total * 0.2m; // This property calculates the tax based on the total value.

        public string GetInfoWithTax()
        {
            return "Tax: " + Tax + additionalTaxes;
        }

        // by having two methods with the same name but different parameters,
        // we can overload methods in C#. 
        // Use cases for method overloading include providing different ways to get information
        // When you want to provide a method with both a simple and a more detailed version.
        // For example, logging with or without a timestamp.
        // When a method should accept different types of input(e.g., int, double, string) but perform similar logic.

        public string GetInfoWithTax(decimal? additionalTaxes = null)
        {
            // This method returns a string with information about the sale and tax.
            return "Total: " + Total + ", Tax: " + Tax + ", Additional Taxes: " + additionalTaxes;
        }

        // Overriding is about inheritance and polymorphism.
        // It allows a derived class to provide a specific implementation of a method
        // that is already defined in its base class.
        // Overloading is about method signatures within the same scope.
        // It allows multiple methods with the same name but different parameters to coexist.
        public override string MethodThatCanBeOverridden()
        {
            // This method overrides a base class method (if any) and returns a string.
            return "This is an overridden method in the Sale class.";
        }
    }
}
