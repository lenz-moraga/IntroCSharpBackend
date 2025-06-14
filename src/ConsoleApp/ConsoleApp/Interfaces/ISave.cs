using System;
// Imports basic types and utilities (e.g., Console, DateTime).
using System.Collections.Generic;
// Provides access to generic collections like List<T>, Dictionary<TKey, TValue>.
using System.Linq;
// Enables LINQ queries for collections.
using System.Text;
// Used for text manipulation (e.g., StringBuilder).
using System.Threading.Tasks;
// Supports asynchronous programming with Task and related types.


namespace ConsoleApp.Interfaces
{
    public interface ISave // This is another interface definition in C#.
    {
        // This interface defines a contract for saving data.
        public void Save(); // This method defines a contract for the Save method.
    }
}
