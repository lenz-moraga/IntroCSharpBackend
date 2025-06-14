# Static

In C#, it is a keyword used to declare members(methods, properties, fields) or classes that belong to the type itself, not to any specific instance.

- If a Class is static, all its members must be static.
- Static method/property/field can be a accessed using the class name, without creating an object.
- For pure functions like the `MathService.Add` function, static methods are easy to test, However, static classes become harder to test when:
  - you want to use mocking,
  - when the static methods interacts with external systems
  - you want to add dependency injection.

### Static Class and methods Example

```csharp
public static class MathService
{
    public static int Add(int a, int b) => a + b;
    public static double SquareRoot(double value) => Math.Sqrt(value);
}
```

Usage:

```csharp
int sum = MathService.Add(2, 3); // Call the class name without
// creating a new instance of the class.
double root = MathService.SquareRoot(16);
```

### Non-Static Class and methods Example

Just as we have static methods we have non-static methods. Non-static methods maintain states or configurations, and use dependency injection. Some examples of these services are, database context, loggers, etc.

- If a class is non-static, it can have static methods.
- Non-static method/property/fields can be accessed after creating an instance of the containing class.
- Easier to test.

```csharp
public class EmailService
{
    private readonly ILogger _logger;

    public EmailService(ILogger logger)
    {
        _logger = logger;
    }

    public void SendEmail(string to, string subject, string body)
    {
        // Send email logic here...
        _logger.Log($"Email sent to {to} with subject '{subject}'");
    }
}
```

Usage:

```csharp
var logger = new ConsoleLogger();
var emailService = new EmailService(logger);
emailService.SendEmail("user@example.com", "Welcome", "Hello!");
```

---

## Unit test examples

### Unit test for a static class

```csharp
public static class MathService
{
    public static int Add(int a, int b) => a + b;
}
```

```csharp
using Xunit;

public class MathServiceTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        int result = MathService.Add(2, 3);
        Assert.Equal(5, result);
    }
}
```

### Unit test for a non-static class

```csharp
public interface ILogger
{
    void Log(string message);
}

public class EmailService
{
    private readonly ILogger _logger;

    public EmailService(ILogger logger)
    {
        _logger = logger;
    }

    public void SendEmail(string to)
    {
        // ... send email logic ...
        _logger.Log($"Email sent to {to}");
    }
}
```

```csharp
using Xunit;
using Moq;

public class EmailServiceTests
{
    [Fact]
    public void SendEmail_LogsMessage()
    {
        // Arrange
        var loggerMock = new Mock<ILogger>();
        var service = new EmailService(loggerMock.Object);

        // Act
        service.SendEmail("user@example.com");

        // Assert
        loggerMock.Verify(l => l.Log("Email sent to user@example.com"), Times.Once);
    }
}
```
