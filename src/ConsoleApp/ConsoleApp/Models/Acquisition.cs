using ConsoleApp.Interfaces;

namespace ConsoleApp.Models
{
    // Interfaces tell classes what methods they must implement, but they do not
    // provide implementations themselves or care about it. in thie case, the Sale class
    // and the Acquisition class implements the ISave interface, enforcing them to have a Save functionality
    // but with how are the implemented is irrelevant for the contract.
    public class Acquisition : ISave
    {
        public void Save()
        {
            // This method implements the ISave interface's Save method for the Acquisition class.
            Console.WriteLine("Acquisition data saved.");
        }
    }
}
