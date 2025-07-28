# Collections

Collections are objects that store groups of related items. They are essential for managing and manipulating data in memory.

**Main Types of Collections**

- Arrays:

```csharp
int[] numbers = { 1, 2, 3 };
```

- Generic Collections

  - List<T>: Dynamic Array
  - Dictionary<TKey, TValue>: Key-Value pairs.
  - Queue<T>: FIFO (First-in, First-out)
  - Stack<T>: LIFO (Last-in, First-out)
  - HashSet<T>: Unique items, no duplicates

```csharp
var numbers = new List<int> { 1, 2, 3 };
numbers.Add(4);
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3, 4
```

- Non-Generic Collections

  - Olders, less type-safe(e.g, ArrayList, HashTable).

## Why Use Collections?

- To store, retrieve, and manipulate groups of objects efficiently.
- Collections provide methods for adding, removing, searching, and sorting items.

## When to use collections

- Use List<T> for dynamically growing collections.
- Use Dictionary<K, V> when you need fast access by key.

> [!NOTE]
> Collections are fundamental in C# for handling multiple data items, and you’ll use them in almost every real-world application. For most scenarios, prefer generic collections for type safety and performance.

## Methods that can be used with collections

- List<T>

    - Remove(item) - Removes the first occurrencce of an item.
    - RemoveAt(index) - Removes the item at a specific position.
    - Insert(index, item)
    - Contains(item)
    - IndexOf(item)
    - Clear() - removes all items from the list
    - Count ()
    - Find(predicate) - finds the first item matching a condition.
    - ForEach(action) - Performs an action on each item.

- Dictionary<TKey, TValue>

    - Remove(key) - Remove the entry with the specified key
    - ContainsKey(key) - checks if a key exists
    - ContainsValue(value) - checks if a value exists
    - TryGetValue(key, out value) - safely gets a value by key
    - Keys/Values - Gets collections of all keys or values
    - Clear() - remove all entries

- Queue<T> and Stack<T> 

    - Enqueue(item) / Push(item) - Add items
    - Dequeue() / Pop() - remove and return items
    - Peek() - returns the first item of the stack without removing it
    - Contains(item)
    - Clear()
