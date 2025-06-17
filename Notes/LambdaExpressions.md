## Lambda Expressions in C#

**Lambda expressions** are a concise way to write anonymous methods (functions without a name) in C#. They use the `=>` syntax.

### Syntax Example:
```csharp
// Lambda that adds two numbers
Func<int, int, int> add = (a, b) => a + b;
int result = add(2, 3); // result is 5
```

---

## How are they used?

- Assigning logic to delegates (`Func`, `Action`)
- LINQ queries (e.g., `list.Where(x => x > 5)`)
- Event handling and callbacks

---

## Do they exist in JavaScript?

Yes. In JavaScript, **arrow functions** (`=>`) are similar to C# lambdas.

### JavaScript Example:
```js
const add = (a, b) => a + b;
let result = add(2, 3); // result is 5
```

---

## Differences between C# Lambdas and JS Arrow Functions

- **Type System:** C# is statically typed; JS is dynamically typed.
- **`this` Binding:** In JS, arrow functions do not have their own `this`; in C#, lambdas capture variables from their scope but do not change `this`.

### What does "`this` binding" mean?

- In JavaScript, the meaning of `this` inside a function depends on how the function is called. Regular functions can have a different `this` than you expect.
- Arrow functions in JavaScript always use the `this` from where they were created, not from how they are called.
- In C#, lambdas always use the `this` from their surrounding class or object, so you don't have to worry about it changing.

#### Example for Dummies

**JavaScript:**
```js
function Counter() {
    this.count = 0;
    setInterval(function() {
        this.count++; // 'this' is NOT the Counter! It's the global object or undefined.
        console.log(this.count); // Not what you expect!
    }, 1000);
}

function CounterArrow() {
    this.count = 0;
    setInterval(() => {
        this.count++; // 'this' IS the CounterArrow object!
        console.log(this.count); // Works as expected
    }, 1000);
}
```
- In the first example, `this` inside the regular function does not refer to the `Counter` object.
- In the second example, the arrow function keeps the `this` from `CounterArrow`, so it works.

**C#:**
```csharp
class Counter
{
    public int Count = 0;
    public void Start()
    {
        Timer timer = new Timer(_ =>
        {
            Count++; // 'this' always refers to the Counter object
            Console.WriteLine(Count);
        }, null, 0, 1000);
    }
}
```
- In C#, you don't have to worry—`this` inside the lambda always refers to the `Counter` object.

- **Usage Context:** C# lambdas are often used with delegates and LINQ; JS arrow functions are used for callbacks, array methods, etc.

---

---

## Use Cases

- Filtering or transforming collections (LINQ in C#; `map`, `filter` in JS)
- Passing logic as parameters (event handlers, callbacks)
- Short, inline functions without needing a named method

