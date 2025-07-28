## What is LINQ?

**LINQ** (Language Integrated Query) is a feature in C# that allows you to write queries directly in your code to work with data collections (like arrays, lists, databases, XML, etc.) in a consistent way.

### What is it used for?

- **Querying collections:** Easily filter, sort, group, and transform data in arrays, lists, dictionaries, and more.
- **Database access:** Write queries in C# that are translated to SQL for databases (with LINQ to SQL or Entity Framework).
- **Working with XML:** Query and manipulate XML data using the same syntax.
- **Readable code:** Makes data manipulation code more concise and easier to read.

### Example:

```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList(); // {2, 4}
```
