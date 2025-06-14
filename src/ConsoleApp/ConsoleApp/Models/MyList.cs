namespace ConsoleApp.Models
{
    // Generics allow you to create classes that work with any data type (T), increasing code reusability.
    public class MyList<T>
    {
        private List<T> _list;
        private int _limit;
        public MyList(int limit)
        {
            this._limit = limit; // This sets the limit for the list.
            _list = new List<T>(); // This initializes the list with the specified limit.
        }
        public void Add(T item)
        {
            if (_list.Count < _limit)
            {
                _list.Add(item); // This adds the item to the list if the current count is less than the limit.
            }
        }

        public string GetContent()
        {
            return string.Join(", ", _list);
        }
    }
}
