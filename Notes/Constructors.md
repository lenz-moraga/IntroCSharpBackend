# Constructors

## Primary Constructor
- Declared directly in the class definition.
- Simplifies class declaration and initialization by combining the constructor and property/field initialization into a single line.
- Automatically initializes properties or fields based on the parameters provided.
- Commonly used for concise class definitions, especially for simple data models.

**Advantages**: Reduces boilerplate, improves readability, automatically integrates with inheritance, and allows for more straightforward initialization of class members.

**Limitations**: Cannot include complex logic in the constructor, it is less flexible for advanced scenarios requiring custom inicialization logic.

## Traditional Constructor
- This is the standard way of defining a constructor in C#.
- Declared within the class body, allowing for more complex initialization logic.
- Requires explicit property or field initialization within the constructor body.

**Advantages**: Provides full control over the initialization process,, can include validation, calculations, or other operations during object creation.

**Limitations**: More verbose, requires more boilerplate code, and can lead to longer class definitions because requires manual property/field initialization.

## When to use each:

#### Use Primary Constructor when:
- Use when the class is simple and requires minimal initialization logic.
- Ideal for data models or classes with straightforward inheritance.

#### Use Traditional Constructor when:
- Use when the class requires complex initialization logic, validation, or calculations.
- Suitable for scenarios where flexibility and control over the initialization process are needed.
