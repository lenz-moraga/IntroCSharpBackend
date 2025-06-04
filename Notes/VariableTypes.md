# Types C# can handle:

## 1. string:

Represents a sequence of characters. Used for text data.

```
string name = "John Doe";
```

## 2. bool:

Represents a true/false value. Used for logical conditions.

```
bool isActive = true;
```

## 3. char:

Represents a single Unicode character. Used for individual characters.

```
char grade = 'A';
```

## 4. float:

Represents a single-precision floating-point number. Used for less precise
decimal values.

```
float temperature = 36.6f;
```

## 5. long:

Represents a 64-bit integer. Used for large whole numbers.

```
long population = 7800000000;
```

## 6. short:

Represents a 16-bit integer. Used for small whole numbers.

```
short age = 25;
```

## 7. byte:

Represents an 8-bit unsigned integer. Used for small positive numbers or binary
data.

```
byte level = 255;
```

## 8. sbyte:

Represents an 8-bit signed integer. Used for small numbers including negatives.

```
sbyte offset = -128;
```

## 9. uint:

Represents a 32-bit unsigned integer. Used for non-negative whole numbers.

```
uint count = 1000;
```

## 10. ulong:

Represents a 64-bit unsigned integer. Used for very large non-negative numbers.

```
ulong distance = 18446744073709551615;
```

## 11. ushort:

Represents a 16-bit unsigned integer. Used for small non-negative numbers.

```
ushort port = 65535;
```

## 12. object:

Represents the base type of all types in C#. Used for general-purpose data.

```
object data = "Hello";
```

## 13. dynamic:

Represents a type that bypasses compile-time type checking. Used for dynamic
scenarios.

```
dynamic value = 42;
```

## 14. DateTime:

Represents date and time values. Used for scheduling or time-related data.

```
DateTime now = DateTime.Now;
```

## 15. TimeSpan:

Represents a time interval. Used for durations.
`TimeSpan duration = TimeSpan.FromHours(2);`

## 16. Guid:

Represents a globally unique identifier. Used for unique keys or IDs.

```
Guid id = Guid.NewGuid();
```

## 17. Enum:

Represents a set of named constants. Used for predefined options.

```
enum Days { Sunday, Monday, Tuesday }
Days today = Days.Monday;
```

## 18. Nullable<T>:

Represents a value type that can also be null. Used for optional values.

```
int? nullableInt = null;
```

## 19. Tuple:

Represents a lightweight data structure for grouping multiple values. Used for
temporary data grouping.

```
var tuple = (1, "John", true);
```

## 20. Array:

Represents a collection of elements of the same type. Used for storing multiple
values.

```
int[] numbers = { 1, 2, 3 };
```

## 21. List<T>:

Represents a generic collection of elements. Used for dynamic collections.

```
List<string> names = new List<string> { "Alice", "Bob" };
```

## 22. Dictionary<TKey, TValue>:

Represents a collection of key-value pairs. Used for mapping data.

```
Dictionary<int, string> map = new Dictionary<int, string> { { 1, "One" }, { 2, "Two" } };
```

## 23. Struct:

Represents a value type that can contain multiple fields. Used for lightweight
objects.

```
struct Point { public int X; public int Y; }
Point p = new Point { X = 10, Y = 20 };
```

## 24. Class:

Represents a reference type that can contain methods, properties, and fields.
Used for complex objects.

```
class Person { public string Name; public int Age; }
Person person = new Person { Name = "John", Age = 30 };
```

## 25. Interface:

Represents a contract for classes to implement. Used for abstraction.

```
interface IAnimal { void Speak(); }
class Dog : IAnimal { public void Speak() => Console.WriteLine("Woof!"); }
```

## 26. int:

Represents a 32-bit integer. Used for whole numbers. `int score = 100;`

## 27. decimal:

Represents a 128-bit precise decimal number. Used for financial and monetary
calculations.

```
decimal price = 19.99m;
```

## 28. double:

Represents a double-precision floating-point number. Used for more precise
decimal values.

```
double pi = 3.14159;
```