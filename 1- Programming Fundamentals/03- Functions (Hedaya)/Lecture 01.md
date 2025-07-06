# Functions Lecture 1

## What is Function?
- A box (block of code) that contains logic, takes input, and gives an output(not always).

## Components of C++
- Function is a main component in C++.

## Function Types
1. User-defined.
2. Built-in:
   - Example: `getline()` a global function.

## How to Create a User-defined Function
- Syntax: 
  - `return_type function_name(parameter list/input) { // code }`
- Example:
  ```c++
  #include <iostream>
  using namespace std;
  bool is_alpha(char c);

  int main() {
      cout << is_alpha('n');
      return 0;
  }

  bool is_alpha(char c) {
      if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) {
          return true;
      }
      return false;
  }
  ```

## Memory
- Text (.exe file).
- Initialized variables (global).
- Uninitialized variables.
- Heap (dynamic allocation).
- Stack.
  - Any function is stored in the stack.
    - Name (is_alpha).
    - Local variables (c).
    - Return address.
- Command line arguments.


  ```c++
  #include <iostream>
  using namespace std;
  void f1(int x);
  void f2(int x);
  void f3(int x);
  
  int x = 100;
  
  int main() {
      int x = 20;
      f1(4); // f1 x = 100
      f2(8);
      f3(12);
  
      cout << x << '\n';
  
      return 0;
  }
  
  void f1(int x) {
      cout << "f1 x = " << ::x << '\n';
  }
  
  void f2(int x) {
      cout << "f2 x = " << x << '\n';
  }
  
  void f3(int x) {
      cout << "f3 x = " << x << '\n';
  }
  ```

## Function Return Type
1. Void.
    ```c++
    #include <iostream>
    using namespace std;
    
    void printMenu();
    
    int main() {
        printMenu();
        return 0;
    }
    
    void printMenu() {
        cout << "1. Cheese\n";
        cout << "2. Burger\n";
        cout << "3. Potato\n";
        cout << "4. Chicken\n";
    }
    ```
2. Non-void.
    ```c++
    #include <iostream>
    using namespace std;
    
    int maximum(int x, int y, int z);
    
    int main() {
        cout << "Maximum number = " << maximum(2, 8, 4);
        return 0;
    }
    
    int maximum(int x, int y, int z) {
        int mx = x;
        if (mx < y)
            mx = y;
        if (mx < z)
            mx = z;
        return mx;
    }
    ```

## Function Signature
1. Name.
2. Types & orders of parameters.

## Function Header
- `return_type function_name(parameter list)`

## Function Definition
- Function header.
- Function body.

## Function Declaration/Prototype
- What I made in all the previous codes :).
- It doesn't matter the order of the functions.
- Also, there's no need to rewrite the name of parameters in the function definition.
- Compiler checks for prototype:
  1. Name.
  2. Number of parameters.
  3. Types of parameters.
  4. Order of parameters.
  5. Return type.
  ```c++
  #include <iostream>
  using namespace std;

  int f1();
  int f2();

  int main() {
      cout << f1(); // 5
      return 0;
  }

  int f1() {
      return f2();
  }

  int f2() {
      return 5;
  }
  ```

## Argument Forcing
- Force the given argument to convert to the type of the parameter.
  ```c++
  #include <iostream>
  using namespace std;
  
  void f1(int x);
  
  int main() {
      f1(4.2); // 4
      return 0;
  }
  
  void f1(int x) {
      cout << x;
  }
  ```

## Argument Promotion Rules
- From high to low.
  - long double.
  - double.
  - float.
  - unsigned long long.
  - long long.
  - unsigned int.
  - int.
  - unsigned short.
  - short.
  - unsigned char.
  - char.
  - bool.

## Storage Class (lifetime)
- The period of time the variable will last in the memory.
1. Static.
   - Exists when the program executes until the end of the execution.
   1. `static`.
       ```c++
       #include <iostream>
       using namespace std;
       
       void f1();
       
       int main() {
           for (int i = 0; i < 3; ++i) {
               f1(); // 5 6 7
           }
           return 0;
       }
    
       void f1() {
           static int x = 4;
           x++;
           cout << x << ' ';
       }
       ```
   2. `extern`.
2. Automatic.
   - The variable is deleted when its scope ends.
   1. `auto`.
   2. `register`.

## Scope:
- The area where the variable can be accessed.
