## Pure Functions

- Always returns the same output for the same input.
- No side effects(do not modify external states,files, databases, etc.).

### Use cases

- Calculations: Math operations, data transformations, string manipulations.
- Validation: Checking if the inputs meets certain criteria.
- MappingL Converting one data structure to another(e.g., DTOs).

#### When to use

- When you want predictable, testable and reusable code.
- in multi-threated or parallel code (no shared state issues).
- for logic that should not affect or depend on the outside world.

#### When no to use

- When you need to interact with external systems (files, databases, ui, etc.)
- When you must update or read shared state.

## Impure functions

- May return different outputs for the same input.
- Have side effects (modify state, perform I/O, etc.).

### Use cases

- I/O Operations: Reading/writting files, databases, network calls.
- State Changes: Modifying objects, updating UI, logging.
- Randomness/Time: Generating random numbers, getting current time.

#### When to use

- When your code must interact with the outside world or change state.
- For operations that inherently require side effects.

#### When no to use

- For logic that should be deterministic and easily testable.
- When you want to avoid hidden dependencies or bugs from state changes.
