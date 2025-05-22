# Logical Operators - Homework

## Homework 1: Guess the output

```C++
      #include <iostream>
      using namespace std;

      int main () {
          int a = 10, b = 20, c = 30, d = 40;

          cout << (a + b == c) << endl; // 30 == 30 => (1)
          cout << (a + b + c >= 2 * d) << endl; // 60 >= 80 => (0)

          cout << (a > 5 || d < 30) << endl; // T or F => T (1)
          cout << (a > 5 && d < 30) << endl; // T and F => F (0)
          cout << (a <= b && b <= c) << endl; // T and T => T (1)

          cout << (a > 5 && d < 30 || c - b == 10) << endl; // T and F or T => F or T => T (1)
          cout << (a <= b && b <= c && c <= d) << endl; // T and T and T => T (1)

          cout << (a > 5 && d < 30 || c > d || d % 2 == 0) << endl; // T and F or F or T => F or F or T => T (1)
          cout << (a > 5 && d < 30 || c > d && d % 2 == 0) << endl; // T and F or F and T => F or F => F (0)

          cout << (a == 10 || b != 20 && c != 30 || d != 40) << endl; // T or F and F or F => T or F or F => T (1)
          cout << ((a == 10 || b != 20) && c != 30 || d != 40) << endl; // (T or F) and F or F => T and F or F => F or F => F (0)

          return 0;
      }
```

## Homework 2: Create logic!

- Problem:
  - Write a program that reads 3 integers about the classroom.
    - Number of boys (nb), number of girls (ng), number of teachers (nt).
  - Prepare and print a boolean variable for these cases:
    1. nb greater than 25.
    2. ng less than or equal to 30.
    3. nb > 20 and nt > 2 or ng > 30 and nt > 4.
    4. Either nb < 60 or ng < 70.
    5. Neither nb >= 60 nor ng >= 70.
    6. nb is 10 more students than ng.
    7. Difference between nb and ng is more than 10 or nt > 5.
    8. Either nb is 10 more students than ng or ng is 15 more students than nb.
- Solution:

  ```C++
        #include <iostream>
        using namespace std;

        int main () {
            int nb, ng, nt;
            cout << "Enter number of boys, number of girls and number of teachers: ";
            cin >> nb >> ng >> nt;

            // 1. nb greater than 25.
            int result = (nb > 25);
            cout << result << endl;

            // 2. ng less than or equal to 30.
            result = (ng <= 30);
            cout << result << endl;

            // 3. nb > 20 and nt > 2 or ng > 30 and nt > 4.
            result = (nb > 20 && nt > 2 || ng > 30 && nt > 4);
            cout << result << endl;

            // 4. Either nb < 60 or ng < 70.
            result = (nb < 60 || ng < 70);
            cout << result << endl;

            // 5. Neither nb >= 60 nor ng >= 70.
            result = (!(nb >= 60) && !(ng >= 70));
            cout << result << endl;

            // 6. nb is 10 more students than ng.
            result = (nb == ng + 10);
            cout << result << endl;

            // 7. Difference between nb and ng is more than 10 or nt > 5.
            result = (nb - ng > 10 || nt > 5);
            cout << result << endl;

            // 8. Either nb is 10 more students than ng or ng is 15 more students than nb.
            result = (nb == ng + 10 || ng == nb + 15);
            cout << result << endl;

            return 0;
        }
  ```

## Homework 3 (optional): Simplify expressions

- For each expression:
  - Write a line of code that evaluate it to see its final value.
  - Simplify it step by step to finally be a T or F.

1. T && T && F && T.

- Solution:
  - **F**.

2. T && T && F && T || T && T.

- Solution:
  - F || T.
  - **T**.

3. T && T && T && T || T && (T || F).

- Solution:
  - T && T && T && T || T && T.
  - T || T.
  - **T**.

4. T && T && T || T && (F || (T && (T && T))).

- Solution:
  - T && T && T || T && (F || (T && T)).
  - T && T && T || T && (F || T).
  - T && T && T || T && T.
  - T || T.
  - **T**.

5. T && T || T && F && T || T && T && F || (T && (T || F)).

- Solution:
  - T && T || T && F && T || T && T && F || (T && T).
  - T && T || T && F && T || T && T && F || T.
  - T || F || F || T.
  - **T**.

6. T && T || T && F && T || (T && T && F || (T && (T || F))).
   - Solution:
     - T && T || T && F && T || (T && T && F || (T && T)).
     - T && T || T && F && T || (T && T && F || T).
     - T && T || T && F && T || T.
     - T || F || T.
     - **T**.
7. (T && T || T && F && T || T) && T && F || (T && (T || F)).
   - Solution:
     - (T || F || T) && T && F || (T && T).
     - T && T && F || T.
     - F || T.
     - **T**.
8. T && T || T && (F && T || T && T) && F || (T && (T || F)).
   - Solution:
     - T && T || T && (F || T) && F || (T && T).
     - T && T || T && T && F || T.
     - T || F || T.
     - **T**.
