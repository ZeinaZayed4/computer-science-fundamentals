# Static & Dynamic Memory Allocation - Part 2

- **new**
  - a keyword used to allocate memory in the **heap**.

## Stack Part
- i (int) ⇒ takes 4 bytes.
- ptr (float) ⇒ takes 8 bytes.
  - Contains the address of the array.

## Dynamic Memory Allocation
- The Size of the variable isn't known in the **compile time**, it depends on something in the **run time**.
  - E.g., I need to an array, but don't know its size, I'll take it from the user.
- Storage will be taken from the **heap**.
- Problem & Solution:
  - The main function can't directly access memory in the heap.
  - So, we have the **pointer;** pointer is a variable that contains the address of another variable.
  - The main function now can access the array in the heap using the pointer in the stack.
- **Note**:
  - After you finish using the storage in the heap, you must delete this storage to avoid memory leaks.

- Code:
  ```c++
     #include <iostream>
     using namespace std;

     int main() {
         int i;
         float *ptr;
  
         cout << "Enter array size: \n";
         cin >> i;

         ptr = new float[i]; // dynamically allocate array in heap
         delete[] ptr; // deallocate memory

         return 0;
    }
  ```
