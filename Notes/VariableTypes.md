# Types C# can handle:

## 1. string

Represents a sequence of characters. Used for text data.

```csharp
string name = "John Doe";
```

**Use Cases:** 
- Storing names, messages, or any textual data.
- StringBuilder for bucle contatenations.
- string.Replace() for simple replacing.
- string.Split(), string.Substring() heavy/advanced manipulation.

---

## 2. bool

Represents a true/false value. Used for logical conditions.

```csharp
bool isActive = true;
```

**Use Cases:** Flags, conditions, and logical checks.

---

## 3. char

Represents a single Unicode character. Used for individual characters.

```csharp
char grade = 'A';
```

**Use Cases:** Storing single letters, symbols, or characters.

---

## 4. float

Represents a single-precision floating-point number. Used for less precise decimal values.

```csharp
float temperature = 36.6f;
```

**Use Cases:** Scientific calculations, graphics, or measurements.

---

## 5. long

Represents a 64-bit integer. Used for large whole numbers.

```csharp
long population = 7800000000;
```

**Use Cases:** Population counts, timestamps, or large counters.

---

## 6. short

Represents a 16-bit integer. Used for small whole numbers.

```csharp
short age = 25;
```

**Use Cases:** Age, small counters, or limited-range values.

---

## 7. byte

Represents an 8-bit unsigned integer. Used for small positive numbers or binary data.

```csharp
byte level = 255;
```

**Use Cases:** Color values, binary data, or small counters.

---

## 8. sbyte

Represents an 8-bit signed integer. Used for small numbers including negatives.

```csharp
sbyte offset = -128;
```

**Use Cases:** Offsets, small signed values, or binary protocols.

---

## 9. uint

Represents a 32-bit unsigned integer. Used for non-negative whole numbers.

```csharp
uint count = 1000;
```

**Use Cases:** Non-negative counters, indexes, or sizes.

---

## 10. ulong

Represents a 64-bit unsigned integer. Used for very large non-negative numbers.

```csharp
ulong distance = 18446744073709551615;
```

**Use Cases:** Large IDs, file sizes, or memory addresses.

---

## 11. ushort

Represents a 16-bit unsigned integer. Used for small non-negative numbers.

```csharp
ushort port = 65535;
```

**Use Cases:** Network ports, small counters, or flags.

---

## 12. object

Represents the base type of all types in C#. Used for general-purpose data.

```csharp
object data = "Hello";
```

**Use Cases:** Storing any type, generic collections, or reflection.

---

## 13. dynamic

Represents a type that bypasses compile-time type checking. Used for dynamic scenarios.

```csharp
dynamic value = 42;
```

**Use Cases:** Interoperability, dynamic APIs, or scripting.

---

## 14. DateTime

Represents date and time values. Used for scheduling or time-related data.

```csharp
DateTime now = DateTime.Now;
```

**Use Cases:** Timestamps, scheduling, or logging.

---

## 15. TimeSpan

Represents a time interval. Used for durations.

```csharp
TimeSpan duration = TimeSpan.FromHours(2);
```

**Use Cases:** Measuring elapsed time, delays, or intervals.

---

## 16. Guid

Represents a globally unique identifier. Used for unique keys or IDs.

```csharp
Guid id = Guid.NewGuid();
```

**Use Cases:** Unique identifiers for objects, database keys, or tokens.

---

## 17. Enum

Represents a set of named constants. Used for predefined options.

```csharp
enum Days { Sunday, Monday, Tuesday }
Days today = Days.Monday;
```

**Use Cases:** Status codes, modes, or option sets.

---

## 18. Nullable<T>

Represents a value type that can also be null. Used for optional values.

```csharp
int? nullableInt = null;
```

**Use Cases:** Optional fields, database values, or unset states.

---

## 19. Tuple

Represents a lightweight data structure for grouping multiple values. Used for temporary data grouping.

```csharp
var tuple = (1, "John", true);
```

**Use Cases:** Returning multiple values from a method, temporary groupings.

---

## 20. Array

Represents a collection of elements of the same type. Used for storing multiple values.

```csharp
int[] numbers = { 1, 2, 3 };
```

**Use Cases:** Lists of items, buffers, or fixed-size collections.

---

## 21. List<T>

Represents a generic collection of elements. Used for dynamic collections.

```csharp
List<string> names = new List<string> { "Alice", "Bob" };
```

**Use Cases:** Dynamic lists, collections, or queues.

---

## 22. Dictionary<TKey, TValue>

Represents a collection of key-value pairs. Used for mapping data.

```csharp
Dictionary<int, string> map = new Dictionary<int, string> { { 1, "One" }, { 2, "Two" } };
```

**Use Cases:** Lookup tables, mappings, or associative arrays.

---

## 23. Struct

Represents a value type that can contain multiple fields. Used for lightweight objects.

```csharp
struct Point { public int X; public int Y; }
Point p = new Point { X = 10, Y = 20 };
```

**Use Cases:** Coordinates, small data objects, or performance-critical types.

---

## 24. Class

Represents a reference type that can contain methods, properties, and fields. Used for complex objects.

```csharp
class Person { public string Name; public int Age; }
Person person = new Person { Name = "John", Age = 30 };
```

**Use Cases:** Business objects, models, or reusable components.

---

## 25. Interface

Represents a contract for classes to implement. Used for abstraction.

```csharp
interface IAnimal { void Speak(); }
class Dog : IAnimal { public void Speak() => Console.WriteLine("Woof!"); }
```

**Use Cases:** Abstraction, dependency injection, or polymorphism.

---

## 26. int

Represents a 32-bit integer. Used for whole numbers.

```csharp
int score = 100;
```

**Use Cases:** Scores, counters, or indexes.

---

## 27. decimal

Represents a 128-bit precise decimal number. Used for financial and monetary calculations.

```csharp
decimal price = 19.99m;
```

**Use Cases:** Financial calculations, currency, or precise values.

---

## 28. double

Represents a double-precision floating-point number. Used for more precise decimal values.

```csharp
double pi = 3.14159;
```

**Use Cases:** Scientific calculations, measurements, or graphics.

---

## 29. Action

The `Action` type in C# is a delegate that represents a method that does not return a value (`void`). It is part of the `System` namespace and is commonly used for encapsulating methods to be executed later, such as in event handling or callbacks.

- **No return value:** The method encapsulated by `Action` must return `void`.
- **Generic:** `Action` can take zero or more parameters (up to 16).

```csharp
// Action (no parameters)
Action greet = () => Console.WriteLine("Hello, World!");
greet(); // Outputs: Hello, World!

// Action<T> with one parameter
Action<string> printMessage = message => Console.WriteLine(message);
printMessage("Welcome to C#!"); // Outputs: Welcome to C#!

// Action<T1, T2> with two parameters
Action<int, int> addNumbers = (a, b) => Console.WriteLine(a + b);
addNumbers(5, 10); // Outputs: 15
```

**Use Cases:**

- Event handling: `Action` is often used for defining callbacks or event handlers.
- Functional programming: It simplifies passing methods as arguments to other methods.

---

## 30. Func

The `Func` type in C# is a delegate that represents a method that returns a value. It is part of the `System` namespace and is commonly used for encapsulating methods that return results, such as in functional programming or LINQ queries.

- **Return value:** The last generic parameter specifies the return type.
- **Generic:** `Func` can take zero or more input parameters (up to 16), with the last type parameter being the return type.

```csharp
// Func with no parameters, returns int
Func<int> getRandomNumber = () => new Random().Next(1, 100);
int number = getRandomNumber(); // Returns a random number

// Func<T, TResult> with one parameter
Func<string, int> getLength = s => s.Length;
int length = getLength("Hello"); // Returns 5

// Func<T1, T2, TResult> with two parameters
Func<int, int, int> add = (a, b) => a + b;
int sum = add(3, 4); // Returns 7
```

**Use Cases:**

- Returning values from callbacks or lambda expressions.
- LINQ queries and projections.
- Passing logic as parameters when a result is needed.

---

### Casting

```csharp
// Example of casting in C#:

double myDouble = 9.78;
int myInt = (int)myDouble; // Explicit casting: double to int

Console.WriteLine("Double value: " + myDouble); // Prints: Double value: 9.78
Console.WriteLine("Int value after casting: " + myInt); // Prints: Int value after casting: 9

// You can also use 'as' and 'is' for reference types:
object obj = "This is a string";
string str1 = obj as string; // 'as' returns null if the cast fails
if (obj is string str2)
{
    Console.WriteLine("obj is a string: " + str2);
}
```
---

```csharp
string numberString = "123";

// Using int.Parse (throws exception if invalid)
int number1 = int.Parse(numberString);

// Using int.TryParse (safe, returns false if invalid)
bool success = int.TryParse(numberString, out int number2);

Console.WriteLine(number1); // 123
Console.WriteLine(success ? number2.ToString() : "Invalid number");
```
