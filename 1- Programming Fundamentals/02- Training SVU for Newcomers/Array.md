# Array

- If we want to take 10 integers from the user:
  - In normal, we will think to create 10 integer variables.
  - **But** If we want to take 1000 integers from the user, it looks so boring.
  - **So** in C++ there's something will help us in that called **Arrays**.
- It's a series of elements of the _same type_ placed in contiguous memory locations that can be individually referenced by adding an index to a unique identifier.

## Declaring Arrays:
- Like a regular variable, an array must be declared before it is used.
- A typical declaration of an array in C++ is:
  ```c++
  // DataType Name [Number of elements];
  int x[5];
  ```
- Initializing arrays:
  ```c++
  int x[5] = {1, 2, 3, 4, 5};
  // OR
  int y[] = {10, 20, 30, 40, 50}; // Size of array will be 5.
  ```

## Accessing the Values of an Array:
- Code:
  ```c++
  #include <iostream>
  using namespace std;

  int main() {
      int x[1000];

      x[0] = 4;
      x[1] = 8 + x[0];

      x[2] = x[0] * x[1];

      int y = x[0];

      cout << x[0] << '\n'; // 4
      cout << x[1] << '\n'; // 12
      cout << x[2] << '\n'; // 48
      cout << y << '\n';    // 4

      return 0;
  }
  ```

## Accessing the Values of an Array Using Loops:
- Code:
  ```c++
  int x[10];
  for (int i = 0; i < size(x); ++i) {
      cin >> x[i];
  }

  for (int i = 0; i < size(x); ++i) {
      cout << x[i] << ' ';
  }
  ```

## Problems
1) Write a program to take N numbers from the user and print the summation.
   - Solution:
     ```c++
     int n, sum = 0;
     cin >> n;
     int arr[n];
     for (int i = 0; i < n; ++i) {
         cin >> arr[i];
         sum += arr[i];
     }
     cout << "Summation = " << sum;
     ```
2) Write a program that takes an array of size N from user and number X, then check if X exists in the array or not.
   - Solution:
     ```c++
     int n, x;
     cin >> n;
     int arr[n];
     for (int i = 0; i < n; ++i) {
         cin >> arr[i];
     }

     cin >> x;
     bool exists = false;
     for (int i = 0; i < n; ++i) {
         if (arr[i] == x) {
            exists = true;
         break;
         }
     }
     string result = (exists) ? to_string(x) + " exists in the array." : to_string(x) + " doesn't exist in the array";
     cout << result;
     ```
3) Write a program that takes 10 numbers from user and print largest and smallest numbers.
    - Solution:
      ```c++
      int smallest = 2e9, largest = -2e9, arr[10];
      for (int i = 0; i < size(arr); ++i) {
          cin >> arr[i];
      }

      for (int i = 0; i < size(arr); ++i) {
          if (arr[i] > largest) {
              largest = arr[i];
          }
      
          if (arr[i] < smallest) {
             smallest = arr[i];
          }
      }

      cout << "Largest number = " << largest << '\n';
      cout << "Smallest number = " << smallest << '\n';
      ```
4) Write a program that takes an array of size N from user, then if number is even change its value to 0, otherwise to 1 then print the array.
   - Solution:
     ```c++
     int n;
     cin >> n;
     int arr[n];

     for (int i = 0; i < n; ++i) {
         cin >> arr[i];
         arr[i] = (arr[i] % 2 == 0) ? 0 : 1;
         cout << arr[i] << ' ';
     }
     ```

## Array of Char Declaring and Initializing
- Code:
  ```c++
  #include <iostream>
  using namespace std;

  int main() {
      char name1[4];
      name1[0] = 'H';
      name1[1] = 'i';
      name1[2] = '!';

      char name2[4] = {'H', 'i', '!'};
      // char name2[4] = {'H', 'i', '!', '\0'};
      char name3[4] = "Hi!";
      char name4[4];

      for (int i = 0; i < 3; ++i) {
          cin >> name4[i];
      }

      char name5[4];
      cin >> name5;

      cout << name1 << ' ' << name2 << ' ' << name3 << ' ' << name4 << ' ' << name5;

      return 0;
  }
  ```

## Problem
- Write a program that takes an array of chars of size N from user, then convert every char that is upper to lower and every char that is lower to upper.
   - Solution:
     ```c++
     #include <iostream>
     using namespace std;

     char txt[100005];

     int main() {
         int n;
         cin >> n;
    
         for (int i = 0; i < n; ++i) {
             cin >> txt[i];
             if (txt[i] >= 65 && txt[i] <= 90) {
                 cout << char(txt[i] + 32);
             } else if (txt[i] >= 97 && txt[i] <= 122) {
                 cout << char(txt[i] - 32);
             }
         }

         return 0;
     }
     ```

## 2D Array
- Multidimensional arrays can be described as "Arrays of arrays" and it's like matrix.
    ![2D Array](2D_Array.png)
- Code:
  ```c++
  #include <iostream>
  using namespace std;

  int a[2][3];

  int main() {
      int x[2][3] = {
          {1, 2, 3},
          {4 ,5, 6}
      };

      for (int i = 0; i < 2; ++i) {
          for (int j = 0; j < 3; ++j) {
              cout << x[i][j] << ' ';
          }
          cout << '\n';
      }

      return 0;
  }
  ```

## Problem
- Write a program that takes a 2d array from user and prints the largest and smallest number in each row.
  - Solution:
    ```c++
    #include <iostream>
    using namespace std;

    int a[100005][100005];

    int main() {
        int x, y;
        cin >> x >> y;

        for (int i = 0; i < x; ++i) {
            int smallest = 2e9, largest = -2e9;
            for (int j = 0; j < y; ++j) {
                cin >> a[i][j];
                if (a[i][j] > largest)
                    largest = a[i][j];
                if (a[i][j] < smallest)
                smallest = a[i][j];
            }
            cout << "Largest in row " << i << " = " << largest << '\n';
            cout << "Smallest in row " << i << " = " << smallest << '\n';
        }

        return 0;
    }
    ```
