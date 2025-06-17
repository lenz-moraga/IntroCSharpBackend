# Functional Programming in C#

This example demonstrates how to assign methods to variables, pass them as parameters, and use delegates (`Action<string>`) to enable flexible, reusable code patterns in C#. It’s a foundational concept for event handling, callbacks, and functional programming in C#.

---

## Assigning Methods to Delegates

You can assign a method to a delegate variable. Here, we assign the `Show` method to an `Action<string>` delegate:

```csharp
// Assign the Show method to an Action delegate
var show = Show;
```

---

## Passing Delegates as Parameters (Higher-Order Functions)

You can pass delegates as parameters to other methods, enabling higher-order functions:

```csharp
// Pass the Action delegate to the Some method
Some(show, "Hello from the Show method!");
```

---

## Example Using Action Delegate

The `Show` method takes a string parameter and returns void. The `Some` method is a higher-order function that takes an `Action<string>` and a message, then executes the delegate.

```csharp
void Show(string message)
{
    Console.WriteLine(message);
}

// Some is a higher-order function: it takes another function (Action<string>) as a parameter.
void Some(Action<string> fn, string message)
{
    Console.WriteLine("Executing Some method...");
    fn(message);
    Console.WriteLine("Finished executing Some method.");
}
```

---

**Key Concepts:**
- **Action delegate:** Represents a method that takes parameters and returns void.
- **Higher-order function:** A function that takes another function as a parameter.
- **Use Cases:** Event handling, callbacks, flexible and reusable code patterns.

---

## Example Using Func Delegate

You can also use the `Func` delegate to represent methods that return a value. Here’s how you can use `Func<string, int>` to pass a function that takes a string and returns an integer:

```csharp
// Assign the GetLength method to a Func delegate
Func<string, int> getLength = GetLength;

// Pass the Func delegate to the ProcessLength method
ProcessLength(getLength, "Hello, Func delegate!");
```

The `GetLength` method returns the length of a string, and `ProcessLength` is a higher-order function that takes a `Func<string, int>` and a message, then uses the delegate.

```csharp
int GetLength(string message)
{
    return message.Length;
}

// ProcessLength is a higher-order function: it takes a function (Func<string, int>) as a parameter.
void ProcessLength(Func<string, int> fn, string message)
{
    Console.WriteLine($"The length of the message is: {fn(message)}");
}
```

---

**Key Concepts:**
- **Func delegate:** Represents a method that takes parameters and returns a value.
- **Higher-order function:** A function that takes another function as a parameter.
- **Use Cases:** Data transformation, projections, calculations, and flexible code patterns.
