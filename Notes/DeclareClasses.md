## Way to Declare Classes in C#

### 1. Inheritance with Primary Constructor and Interface

This is a concise way to declare a class with a constructor and inheritance.

```csharp
class SaleWithTax(decimal total): Sale(total), ISale {}
```

### 2. Traditional Constructor

Traditional way of declaring a class with a constructor. The constructor is
explicitly defined within the class body.

```csharp
public Sale(decimal total) {}
```

### 3. Abstract Classes

Abstract classes are used as base classes and cannot be instantiated directly.
They are designed to be inherited by other classes.

```csharp
abstract class SaleBase {}
```

### 4. Interfaces

Interfaces define a contract that classes can implement. They cannot contain
implementation details, only method signatures.

```csharp
interface ISale {}
```

### 5. Static Classes

Static classes cannot be instantiated and are used to group related methods or
properties that do not require an instance.

```csharp
static class SaleUtils {}
```

### 6. Sealed Classes

Sealed classes cannot be inherited from. They are used to prevent further
inheritance and ensure that the class cannot be extended.

```csharp
sealed class SaleFinal {}
```

### 7. Partial Classes

Partial classes allow splitting the definition of a class across multiple files.

```csharp
partial class SalePartial {}
```

### 8. Generic Classes

Generic classes allow defining classes with type parameters for flexibility and
reusability.

```csharp
class Sale<T> {
  public T Total { get; set; }
}
```

### 9. Nested Classes

Nested classes are defined within another class and can access the outer class's
members.

```csharp
class SaleOuter {
  class SaleInner {}
}
```
