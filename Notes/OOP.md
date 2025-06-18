# Object oriented programming

### Classes

- Classes are the core building blocks of OOP, representing objects with properties and methods.

- Examples can be found in the `Sale`, `SaleWithTaxes` and `Acquisition` Models.

### Interfaces

- Interfaces define contracts that classes must implement, supporting abstraction and polymorphism.

- Examples are `ISale` and `ISave`

### Inheritance and its implementation

- Allow classes to reuse and extend the functionality of another classes. This enforces that these classes provide specific methods and properties.

- Example: `SaleWithTaxes` implement `ISale` interface and inherits the `Sale` properties and methods.

### Polymorphism

- Allows objects to be treated as instances of their interface or base class.

- This is achieved through interfaces and methods overriding like in the `SaleWithTaxes` overriding a method from its base class `Sale`

### Encapsulation

- Use access modifiers to control access to class members. (public, private, protected).

### Abstraction

- It lets you focus on what something does, not how it does it.

- For example, the interfaces `ISale` and `ISave`, the interfaces or contracts are satisfied if the classes have the methods they request.
