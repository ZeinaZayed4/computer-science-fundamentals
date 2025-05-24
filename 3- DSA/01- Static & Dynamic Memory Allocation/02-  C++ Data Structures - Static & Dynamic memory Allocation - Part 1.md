# Static & Dynamic Memory Allocation - Part 1

- Memory is divided into **three** parts:
  - Code => program instructions.
  - Stack.
  - Heap.
- CPU takes the code of the program from the disk to the **code** part in the memory.

## Static Memory Allocation:
- It's allocated in the **stack**.
- When there's a **primitive** data type, a known storage is already defined.
- Code 1:
  - n1, n2 (int) ⇒ 4 bytes are taken from the storage.
  - avg (float) ⇒ 8 bytes are taken from the storage.
  ```c++
     #include <iostream>
     using namespace std;
  
     int main() {
         int n1, n2;
         n1 = 5, n2= 10;
         float avg;
  
         avg = (n1 + n2) / 2;
  
         return 0;
     }
  ```
- Code 2:
  - **Code** part contains:
    - main function's code.
    - Avg function's code.
    - Sum function's code.
  - **Stack** part:
    - _Activation records_ (variable in the main function):
      - n1, n2, n3 (int) ⇒ each takes 4 bytes.
      - result (double) ⇒ takes 8 bytes.
    - _Activation records_ (variables in the Avg function):
      - x, y, z (int) ⇒ each takes 4 bytes.- 
    - _Activation records_ (variables in the Sum function):
      - A, B, C (int) ⇒ each takes 4 bytes.

  ```c++
     #include <iostream>
     using namespace std;
    
     int Sum(int A, int B, int C) {
         return (A + B + C);
     }
  
     float Avg(int x, int y, int z) {
           return Sum(x, y, z) / 3.0;
     }
    
     int main() 
     {
         int n1, n2, n3;
         n1 = 4, n2 = 8, n3 = 3;
         double result = Avg(n1, n2, n3);
    
         return 0;
     }
  ```
  
## Function Call Stack Behavior 
- After Sum function finishes execution and returns a value:
  - Its activation record is cleared.
- Then, the Avg function continues and returns a value.
  - Its activation record is also cleared.
- Finally, the main completes its execution using the returned result.
