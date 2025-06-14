using ConsoleApp.Interfaces;

namespace ConsoleApp.Services
{
    public static class TransactionalService
    // This class provides a static method to save transactions.
    {
        // This method takes any parameter that satisfies the ISave interface and calls its Save method.
        // That is why it can accept both Sale and Acquisition instances.
        public static void SaveTranx(ISave save)
        {
            save.Save();
        }
    }
    // Additional Notes:
    // - The TransactionalService class is designed
    // - to handle transactions in a generic way, allowing any class that implements the ISave interface to be processed.
    // - This promotes code reusability and separation of concerns, as the TransactionalService does not need to know the
    // details of how each transaction is saved.
}
