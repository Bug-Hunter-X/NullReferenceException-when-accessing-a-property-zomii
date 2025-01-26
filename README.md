# NullReferenceException in C# Property Access
This repository demonstrates a common C# error: a `NullReferenceException` that occurs when accessing a property that might be null. The `bug.cs` file contains the faulty code, and `bugSolution.cs` provides a corrected version.

## Problem
The `MyProperty` in `ExampleClass` could be null if it hasn't been initialized. Attempting to call `ToString()` on a null property throws a `NullReferenceException`.

## Solution
The corrected code uses the null-conditional operator (`?.`) to safely access the property. If `MyProperty` is null, the expression short-circuits, avoiding the exception. Alternatively, you could explicitly check for null before accessing the property.