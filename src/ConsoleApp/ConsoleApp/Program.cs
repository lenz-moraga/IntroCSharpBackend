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