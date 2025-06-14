namespace ConsoleApp.Interfaces
{
    public interface ISale
    {
        // This is an interface definition in C#.
        // An interface defines a contract that classes can implement.
        // It can contain method signatures, properties, events, and indexers.
        // Classes that implement this interface must provide implementations for its members.
        decimal Total { get; set; } // This property defines a contract for the Total property.
        string GetInfo(); // This method defines a contract for the GetInfo method.
    }
}
