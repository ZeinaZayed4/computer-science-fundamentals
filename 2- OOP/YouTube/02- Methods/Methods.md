# Methods

## Notes:
  - Static and constants are stored in **high frequency heap**.
  - Instead of calling by instance name, We call static or constant using the class name.
  - **CONSTANT**: is a promise that can't be changed after it has been initialized.
  - **STATIC MEMBER**: is a shared variable that can be changed after it has been initialized.

## Method syntax (simple):
   - ```csharp
        // <AccessMoifier> <DataType>/void MethodName (<Parameter List>)
        // {
                // series of statements
        // }
     ```
- Instance method is called by object.
- Static method is called by typename.

## Notes:
- Argument is sent in caller.
- Parameter is in the definition of the class.
- Pass by value:
  - means you are making a copy in memory of the actual parameter's value that is passed in.

## ref vs. out
- ref:
  - The value must be initialized before being passed.
  - The method can read and modify the value.
  - Code:
    ```csharp
        void Add(ref int x) {
            x += 5;
        }
        
        int num = 10;
        Add(ref num);
        Console.WriteLine(num); // 15
    ```
- out:
  - The variable doesn't need to be initialized before being passed.
  - The method must assign a value to it before it returns.
  - Code:
    ```csharp
        void GetValues(out int a, out int b) {
            a = 5;
            b = 10;
        }
        
        int x, y;
        GetValues(out x, out y);
        Console.WriteLine(x);
        Console.WriteLine(y);
    ```

## Method Signature
- Name + parameter type + parameter order.
  ```csharp
      public void DoSomething(int x, double y) {}
      public void DoSomething(double x, int y) {} // This won't cause any error.
  ```

## Method Overloading
- A common way of implementing polymorphism.

## Expression Bodies Method
- Without "{}".
- With return value and single expression.
  ```csharp
      public bool IsEven(int number) => number % 2 == 0;
  ```

## Local Method
- A method included in another method, and only accessible by it.

## Static Method
- Accessed by class name.
- Only operates with other static members.
