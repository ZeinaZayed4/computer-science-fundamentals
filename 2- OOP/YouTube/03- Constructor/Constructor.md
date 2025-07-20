# Constructor

- One of the major purposes to constructor is the initialization.
- Modeling:
  - Convert problem to class is anything that represents something.
- Validation must be in the class itself, not in the main program.
- Constructor Syntax:
  ```csharp
    // <AccessModifier> <TypeName>(<Parameter list>)
    // {
    //      statements
    // }
  ```
  
## Implicit Constructor
- Default constructor made with class.
- Has no parameters.
- Doesn't return anything.
- Ex:
  ```csharp
    public Date() {
    }
  ```
  
## readonly
- A keyword that makes the field unmodified except in the constructor.
 
## Constructor Overloading
- Use the same instructor with different number of parameters.
- Ex:
  ```csharp
    public Date(int day, int month, int year) {
    }
    
    public Date(int month, int year): this(01, month, year) {
    }
    
    public Date(int year): this(01, 01, year) {
    }
  ```

## Object Initializer
- Ex:
  ```csharp
    Employee e1 = new Employee {
        Id = 4,
        FName = "Zeina",
        LName = "Zayed"
    }
  ```
