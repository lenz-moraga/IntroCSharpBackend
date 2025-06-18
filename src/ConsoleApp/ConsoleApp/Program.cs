// See https://aka.ms/new-console-template for more information
using ConsoleApp.Models;

Console.WriteLine("Hello, World!");

// Ways of declaring variables in C#:
// 1. Explicitly typed variable
//    (e.g., int myNumber = 5;)
// 2. Implicitly typed variable using var
//    (e.g., var myNumber = 5;)
// 3. Dynamic variable using dynamic keyword
//    (e.g., dynamic myNumber = 5;)
// 4. Constants using const keyword
//    (e.g., const int myNumber = 5;)

// ways of instanciate classes in C#:
// 1. Traditional constructor syntax
Sale sale = new Sale(100.0m);

// 2. Implicitly typed variable using var
var sale2 = new Sale(100.0m);

// 3. Primary constructor syntax
Sale sale3 = new(100.0m);

// 4. Object initializer syntax
//    (e.g., Sale sale4 = new Sale { Total = 100.0m };)
Sale sale4 = new Sale { Total = 100.0m };


// var in c# is a keyword used to declare variables with implicit typing.
// It allows the compiler to infer the type of the variable based on the assigned value.
// This is useful when the type is obvious from the context or when working with anonymous types.
// vs var in javascript, where var is used to declare variables with dynamic typing,
// meaning the type can change at runtime.

// example of using generic classes in C#:
// here we create a generic class MyList<T> that can hold a list of items of type T
// and has a limit on the number of items it can hold.
// Generics allow you to create classes that work with any data type (T), increasing code reusability.
var myList = new MyList<string>(5);

myList.Add("Item 1");
myList.Add("Item 2");
myList.Add("Item 3");
myList.Add("Item 4");
myList.Add("Item 5");
myList.Add("Item 6"); // This will not be added because the limit is 5.

Console.WriteLine("List content: " + myList.GetContent());
// myList = 6; // This is not valid in C# as myList is of type MyList<string> and cannot be assigned an integer.

int[] numbers = { 1, 2, 3 }; // old syntax for array initialization
int[] moreNumbers = [4, 5, 6]; // new and recommended syntax for array initialization after C# 12

Console.WriteLine(numbers); // This will print the type name of the array, not its content.
Console.WriteLine(moreNumbers); // array name System.Int32[]

// To print the content of an array, you can use string.Join or a loop.
Console.WriteLine("Numbers: " + string.Join(", ", numbers)); // Prints: Numbers: 1, 2, 3

// Linq

// origin
var names = new List<string>()
{
    "Luis",
    "Bob",
    "Alice",
    "Charlie"
};

// query
var nameResult = from n in names
                 where n.Length > 3 && n.Length < 5
                 orderby n descending
                 select n;
// you can use .ToList() to convert the result to a list, but it's not necessary
// here since we're just printing the names.
// converting to a list is useful if you want to store the result for later use.
// but it is dangerous to use .ToList() if the original list is modified later,
// as it will not reflect the changes made to the original list.
// and could cause performance issues if the list is large.

var nameResult2 = names
    .Where(n => n.Length > 3 && n.Length < 5)
    .OrderByDescending(n => n)
    .Select(d => d);

// execution
Console.WriteLine("Names with length > 3 and < 5, ordered by descending: ");
foreach (var name in nameResult)
{
    Console.WriteLine(name); // Prints the names in alphabetical order
}

Console.WriteLine("Names with length > 3 and < 5, ordered by descending (using method syntax): ");
foreach (var name in nameResult2)
{
    Console.WriteLine(name); // Prints the names in alphabetical order
}