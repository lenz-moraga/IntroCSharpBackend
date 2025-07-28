# Operators and Expressions

## Logical operators

Logical operators in C# include `&&` (and), `||` (or), and `!` (not). These operators are used to combine or negate conditions in conditional statements.

- `&&` (and) checks if both conditions are true.
- `||` (or) checks if at least one of the conditions is true.
- `!` (not) negates a condition.

````csharp
// && (and) example
if (sale.Total > 50.0m && sale.Total < 200.0m)
{
    Console.WriteLine("Sale is between 50.0 and 200.0");
}

// || (or) example
if (sale.Total < 50.0m || sale.Total > 200.0m)
{
    Console.WriteLine("Sale is either less than 50.0 or greater than 200.0");
}
else
{
    Console.WriteLine("Sale is exactly 50.0 or 200.0");
}

// ! (not) example
if (!(sale.Total < 50.0m))
{
    Console.WriteLine("Sale is not less than 50.0");
}

## Relational Operators

Relational operators in C# are used to compare two values. The result of a relational operation is a boolean value (`true` or `false`).

- `==` (equal to): Checks if two values are equal.
- `!=` (not equal to): Checks if two values are not equal.
- `>` (greater than): Checks if the left value is greater than the right value.
- `<` (less than): Checks if the left value is less than the right value.
- `>=` (greater than or equal to): Checks if the left value is greater than or equal to the right value.
- `<=` (less than or equal to): Checks if the left value is less than or equal to the right value.

```csharp
// == (equal to) example
if (sale.Total == 100.0m)
{
    Console.WriteLine("Sale is exactly 100.0");
}

// != (not equal to) example
if (sale.Total != 100.0m)
{
    Console.WriteLine("Sale is not 100.0");
}

// > (greater than) example
if (sale.Total > 150.0m)
{
    Console.WriteLine("Sale is greater than 150.0");
}

// < (less than) example
if (sale.Total < 20.0m)
{
    Console.WriteLine("Sale is less than 20.0");
}

// >= (greater than or equal to) example
if (sale.Total >= 200.0m)
{
    Console.WriteLine("Sale is at least 200.0");
}

// <= (less than or equal to) example
if (sale.Total <= 10.0m)
{
    Console.WriteLine("Sale is at most 10.0");
}
````

## Assignment and incremental/decremental operators

Assignment operators are used to assign values to variables. The most common is `=`, but there are compound assignment operators like `+=`, `-=`, `*=`, `/=`, and `%=`.

Increment (`++`) and decrement (`--`) operators are used to increase or decrease a variable's value by 1.

```csharp
// Assignment operator
int count = 10;

// Compound assignment operators
count += 5; // Equivalent to: count = count + 5;
count -= 2; // Equivalent to: count = count - 2;
count *= 3; // Equivalent to: count = count * 3;
count /= 2; // Equivalent to: count = count / 2;
count %= 4; // Equivalent to: count = count % 4;

// Increment and decrement operators
int index = 0;
index++; // index is now 1
index--; // index is now 0

// Prefix and postfix usage
int a = 5;
int b = ++a; // a is incremented to 6, then b is assigned 6
int c = a++; // c is assigned 6, then a is incremented to 7
```

---

# Control Structures

## Conditionals

Conditional statements in C# can be done using `if`, `else if`, `else`, and `switch` statements.

- `if` is used to check a condition and execute code if the condition is true.
- `else if` and `else` provide alternative branches.
- `switch` is used for multiple conditions based on a single variable's value.

```csharp
// if-else if-else example
if (sale.Total > 50.0m)
{
    Console.WriteLine("Sale is greater than 50.0");
}
else if (sale.Total == 50.0m)
{
    Console.WriteLine("Sale is equal to 50.0");
}
else
{
    Console.WriteLine("Sale is less than 50.0");
}

// switch statement example
switch (sale.Total)
{
    case 50.0m:
        Console.WriteLine("Sale is exactly 50.0");
        break;
    case 100.0m:
        Console.WriteLine("Sale is exactly 100.0");
        break;
    default:
        Console.WriteLine("Sale is neither 50.0 nor 100.0");
        break;
}
```

> [!NOTE]
> A shorthand for an `if-else` statement is the ternary/conditional operator.

```csharp
int number = 10;
string result = (number > 5) ? "Greater than 5" : "5 or less";
Console.WriteLine(result); // Output: Greater than 5
```

---

## Loops

Loops in C# can be done using `for`, `while`, `do-while`, and `foreach` loops.

- `for` is used for iterating a specific number of times or through a range of values.
- `while` iterates as long as a condition is true.
- `do-while` guarantees at least one iteration.
- `foreach` is used to iterate over collections like arrays, lists, and dictionaries.

```csharp
// for loop example
Console.WriteLine("For loop example:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteration {i}");
}

// while loop example
int index = 0;
Console.WriteLine("While loop over numbers array:");
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
    index++;
}

// do-while loop example
index = 0;
Console.WriteLine("Do-while loop over numbers array:");
do
{
    Console.WriteLine(numbers[index]);
    index++;
} while (index < numbers.Length);

// foreach loop example
Console.WriteLine("Foreach loop over numbers array:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
```

---

## Flow Control

Control flow in C# can be managed using `return`, `break`, and `continue` keywords.

- `return` is used to exit a method and optionally return a value.
- `break` is used to exit a loop or switch statement prematurely.
- `continue` is used to skip the current iteration of a loop and move to the next iteration.

```csharp
// return example
if (sale.Total > 200.0m)
{
    Console.WriteLine("Sale is too high, exiting method.");
    return;
}

// break example
for (int i = 0; i < 5; i++)
{
    if (i == 3)
    {
        Console.WriteLine("Breaking the loop at iteration 3.");
        break;
    }
    Console.WriteLine($"Iteration {i}");
}

// continue example
for (int i = 0; i < 5; i++)
{
    if (i == 2)
    {
        Console.WriteLine("Skipping iteration 2.");
        continue;
    }
    Console.WriteLine($"Iteration {i}");
}
```

---

## Exception Handling

`try-catch-finally` blocks are used for exception handling in C#.

- `try` contains code that might throw an exception.
- `catch` handles specific or general exceptions.
- `finally` always executes, regardless of whether an exception was thrown.

```csharp
int dividend = 10;
try
{
    Console.WriteLine("Trying to divide by zero...");
    int result = dividend / 0; // Throws DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Caught a divide by zero exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Caught an exception: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block executed.");
}
```
