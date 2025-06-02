# Loop

## for loop
- The for loop is designed to iterate a number of times.
- Syntax:
  ```c++
    // for (initialization; condition; increase) {
          // statements
    // }
  ```
- A simple for loop code:
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        for (int i = 0; i < 100; i++) {
            cout << "Hello world!" << endl;
        }
        return 0;
    }
  ```

## while loop
- while loop has only a condition in its syntax "while the condition is true, go in the loop."
- Syntax:
  ```c++
    // while (condition) {
            // statements
    // }
  ```
- A simple while loop code:
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int i = 0;
        while (i < 100) {
            cout << "Hello world!" << endl;
            i++;
        }
        return 0;
    }
  ```

## do-while loop
- The do-while loop is a very similar loop.
- Syntax:
  ```c++
    // do {
            // statements
    // } while (condition);
  ```

## Problems
1. Write a program to print numbers from 1 to 10.
   ```c++
    #include <iostream>
    using namespace std;

    int main() {
        for (int i = 1; i <= 10; i++) {
            cout << i << " ";
        }
        return 0;
    }
   ```
2. Write a program to count numbers of odd and even between 1 and 10.
   ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int odd = 0, even = 0;
        for (int i = 1; i <= 10; ++i) {
            if (i % 2 == 0)
                ++even;
            else
                ++odd;
        }
        cout << "Even count: " << even << endl;
        cout << "Odd count: " << odd;
        // Another solution without a loop
        int n;
        cin >> n;
        int e = n / 2;
        int o = n - e;
        cout << "Even count: " << e << endl;
        cout << "Odd count: " << o;
        return 0;
    }
   ```
3. Write a program to take a number from user and print its factorial.
   ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int num;
        long long factorial = 1;
        cin >> num;
        for (int i = num; i > 0; --i) {
            factorial *= i;
        }
        cout << factorial;
        return 0;
    }
   ```
4. Write a program to take 10 numbers from user and print the largest one, smallest.
   ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int num, largest = -2e9, smallest = 2e9;
        for (int i = 1; i <= 10; ++i) {
            cin >> num;

            if (num > largest)
                largest = num;

            if (num < smallest)
                smallest = num;
        }
        cout << largest << " " << smallest;
        return 0;
    }
   ```

## break statement
- It terminates the loop.
- Ex:
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int sum = 0;
        for (int i = 0; i < 10; ++i) {
            int a;
            cin >> a;
            if (a % 2 == 0)
                break;
            sum += a;
        }
        cout << sum; // if the input is (1, 2, 3, 4, 5, 6, 7, 8, 9, 10) => output will be (1)
        return 0;
    }
   ```
## continue statement
- It escapes value(s) in the loop.
- Ex:
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int sum = 0;
        for (int i = 0; i < 10; ++i) {
            int a;
            cin >> a;
            if (a % 2 == 0)
                continue;
            sum += a;
        }
        cout << sum; // if the input is (1, 2, 3, 4, 5, 6, 7, 8, 9, 10) => output will be (1 + 3 + 5 + 7 + 9) = 25
        return 0;
    }
   ```

## Problems
- Write a program that takes numbers from user until enter 0.
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int num;
        while (cin >> num) {
            if (num == 0)
                break;
        }
        // Another solution
        while (cin >> num && num) {
        }
        return 0;
    }
   ```

## Nested Loops
- Loop inside loop.
- 2 loops inside loop, 3 loops, 4 loops.
- Ex:
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int cnt = 1;
        for (int i = 0; i < 10; ++i) {
            for (int j = 0; j < 10; ++j) {
                cout << cnt << "- Hello world! ";
                ++cnt;
            }
            cout << endl;
        }
        return 0;
    }
   ```

## Problems
- Write a program to print:
  #
  ##
  ###
- Code:
  ```c++
    #include <iostream>
    using namespace std;

    int main() {
        int n;
        cin >> n;
        for (int i = 0; i <= n; ++i) {
            for (int j = 0; j < i; ++j) {
                cout << '#';
            }
            cout << endl;
        }
        return 0;
    }
   ```

# Scopes (global, local)
- Ex:
  ```c++
    #include <iostream>
    using namespace std;
    int x = 4; // global scope

    int main() {
        for (int i = 0; i < 10; ++i) {
            cout << i << " "; // local scope
        }
        cout << x; // accessible
        cout << i; // error
        return 0;
    }
   ```
  
## Notes
- Test cases.
  ```c++
    #include <iostream>
    using namespace std;
    int x = 4; // global scope

    int main() {
        int t;
        cin >> t;
        int x, y;
        for (int i = 0; i < t; ++i) {
            cin >> x >> y;
            cout << x + y << endl;
        }
        // Another way
        while (t--) {
            cin >> x >> y;
            cout << x + y << endl;
        }
        return 0;
    }
   ```
- Infinity loops.
- break in nested loops.
- Loop counter can increase by 1 or more and decrease.
- fast code, '\n'.
- Code:
  ```c++
    #include <iostream>
    using namespace std;
    int x = 4; // global scope

    int main() {
        ios_base::sync_with_stdio(0);
        cin.tie(0);
        cout.tie(0);
        return 0;
    }
   ```


