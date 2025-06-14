using ConsoleApp.Interfaces;

namespace ConsoleApp.Models
{
    class Sale : ISale, ISave
    // classes can have several interfaces implemented. this tell us that the Sale class must implement the members of
    // both ISale and ISave interfaces. but the Sale class can also have its own members and methods.
    {
        public decimal Total { get; set; }
        // get; and set; are used to define properties in C#.
        // get; is used to retrieve the value of a property.
        // set; is used to assign a value to the property.

        // Accessors are used to control the visibility of properties and methods in a class.

        // public decimal Total { get; set; }
        private decimal _localTotal; // This is a private field, not a property.
                                     // field is a keyword in C# that is used to declare a variable that is part of a class or struct.
                                     // a field is different from a property in that it does not have accessors (get; and set;).
                                     // private properties are not accessible outside the class they are defined in.
                                     // for conventions, private and protected fields/properties are often prefixed with an underscore (_).
        protected decimal _otherTotal { get; set; }
        // This is a protected property, accessible within the class and derived classes.
        // protected properties are not accessible outside the class they are defined in, except in derived classes.

        // This is a Traditional constructor for the Sale class. 
        // It initializes the Total property to the total value passed within the constructor
        public Sale(decimal total)
        {
            Total = total;
            // Total = 0; // This line sets the Total property to 0.
            // when a new instance of Sale is created.
        }

        // Accessors can be used with methods as well.
        // After the accessor, we add the type of the value that the method returns.
        // This is a method that returns a string with information about the sale.
        public string GetInfo()
        {
            return "_localTotalocalTotal: " + _localTotal + ", _otherTotal: " + _otherTotal + ", Total: " + Total;
        }

        public virtual string MethodThatCanBeOverridden()
        {
            return "This method can be overridden in derived classes.";
        }

        public void Save()
        {
            // This method implements the ISave interface's Save method.
            Console.WriteLine("Sale data saved.");
        }
    }
}
