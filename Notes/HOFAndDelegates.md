# Functional Programming in C#

This example demonstrates how to assign methods to variables, pass them as parameters, and use delegates (`Action<string>`) to enable flexible, reusable code patterns in C#. It’s a foundational concept for event handling, callbacks, and functional programming in C#.

---

## Simple Delegates

A delegate is a type that can reference methods with a specific signature. It's if a delegate is a remote control for a method. You can assign a method to a variable and then use the variable to call your method and its actions/functions

```csharp
public delegate void MyDelegate(string message);

  void SayHello(string msg) => Console.WriteLine(msg);

  MyDelegate remote = SayHello;
  remote("Hello!"); // Calls SayHello
```

## Generic Delegates

```csharp
Action<int> printNumber = n => Console.WriteLine(n);
printNumber(42); // Prints: 42

Func<int, int, int> add = (a, b) => a + b;
int sum = add(2, 3); // sum = 5
```

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

## Events and Subscriptions

### Events

Events are a way for a class to notify other classes or objects when something happens. They are based on delegates.

### Subscriptions

Other code can subscribe to an event using += and unsubscribe with -=.

```csharp
public event Action Doorbell;

// Someone subscribes:
Doorbell += () => Console.WriteLine("Someone rang the bell!");

// When the event happens:
Doorbell?.Invoke(); // Prints: Someone rang the bell!
```

### Summary of Delegates, Events and Subscriptions

Think of these concepts as:

- Delegate: A remote control for a method.
- Generic Delegate: A universal remote for any type of method.
- Event: A doorbell you can subscribe to.
- Subscription: Signing up to be notified when the doorbel rings.

**Example**

```csharp
// 1. Define a delegate type
public delegate void Notify(string message);

// 2. Define a class with an event based on the delegate
public class Process
{
    // Declare the event
    public event Notify ProcessCompleted;

    public void Start()
    {
        Console.WriteLine("Process started...");
        // Simulate some work
        System.Threading.Thread.Sleep(500);
        // Raise the event
        ProcessCompleted?.Invoke("Process finished!");
    }
}

class Program
{
    static void Main()
    {
        // 3. Create an instance of the class
        var process = new Process();

        // 4. Subscribe to the event with a method
        process.ProcessCompleted += ShowMessage;

        // 5. Start the process
        process.Start();
    }

    // Method that matches the delegate signature
    static void ShowMessage(string msg)
    {
        Console.WriteLine("EVENT: " + msg);
    }
}
```

#### Use cases

- **Notification Systems**: When somehting happens(like a process completes, a file finishes downloading, or a user clicks a button), you want to notify other parts of your program.

- **Plugin or Callback Mechanisms**: When you want to allow users ot other devs to "plug in" their own logic that runs at certain points in your code. Example: Passing a delegate to a method so it can call back with results.

- **Asynchronous Programming**: When a task runs in the background and you want to be notified when it's done(like a worker or a timer).

- **Decoupling Components**: When you want to keep different parts of your code independent. The part raising the event doesn't need to know who is listening.

**How are they useful in the backend?**

- Delegates: Useful for callbacks, custom sorting, filtering, or plugging in custom logic (e.g., passing a delegate to a service method).
- Events: Useful for implementing event-driven architectures, such as notifying other components when data changes, a process completes, or an error occurs.
- Subscriptions: Allow different parts of your backend to react to events without being tightly coupled.
  Examples in backend scenarios:
- Logging services that subscribe to error events.
- Background jobs that notify when they finish.
- Custom middleware or pipeline steps using delegates.
