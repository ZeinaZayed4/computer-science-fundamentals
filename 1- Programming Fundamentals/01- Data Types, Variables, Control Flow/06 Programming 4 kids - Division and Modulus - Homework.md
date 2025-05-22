# Division and Modulus - Homework

## Homework 1:

- Given a number, using only % 2 how to know if the number is even or odd?

  - Solution:

    - If the number is divisible by 2 (num % 2 == 0) => it's an even number.
    - else (num % 2 != 0) || (num % 2 == 1) => it's an odd number.

    ```C++
        int x;
        cin >> x;

        bool is_even = (x % 2 == 0);
        cout << is_even << endl;
    ```

- Given a number, using only % 10 how to know if the number is even or odd?

  - Solution:

    - if the last digit is equal to (0, 2, 4, 6, 8).

    ```C++
        int x;
        cin >> x;

        int last_digit = x % 10;

        bool is_even = (last_digit == 0) || (last_digit == 2) || (last_digit == 4) || (last_digit == 6) || (last_digit == 8);
        cout << is_even << endl;
    ```

- Given a number, using only / 2 how to know if the number is even or odd?

  - Solution:

    ```C++
        int x;
        cin >> x;

        double by2 = (double) x / 2.0;
        by2 = by2 - (int) by2;

        bool is_even = by2 == 0;
        cout << is_even << endl;
    ```

## Homework 2

- Write a program that reads 5 numbers and print the following:
  - A) Their average.
  - B) The sum of the first 3 numbers divided by the sum of the last 2 numbers.
  - C) The average of the first 3 numbers divided by the average of the last 2 numbers.
  - What is the math relation between B and C?
  - Any relation between A and C?
- Input 1 2 3 4 5
  - 3
  - 0.666667
  - 0.444444
- Solution:

  ```C++
        #include <iostream>
        using namespace std;

        int main() {
            double n1, n2, n3, n4, n5;
            cin >> n1 >> n2 >> n3 >> n4 >> n5;

            double avg = (n1 + n2 + n3 + n4 + n5) / 5.0;

            double sum = (n1 + n2 + n3) / (n4 + n5);

            double avg2 = ((n1 + n2 + n3) / 3.0) / ((n4 + n5) / 2.0);

            cout << avg << endl;
            cout << sum << endl;
            cout << avg2 << endl;

            cout << sum * 2 / 3 << endl; // C = 2 / 3 B

            return 0;
        }
  ```

## Homework 3:

- Write a program that reads an integer and print the sum of its last 3 digits
- Inputs
  - 15 => 6.
  - 125 => 8.
  - 1000 => 0.
  - 1001 => 1.
  - 1234 => 9.
  - 99999 => 27.
- Solution:

  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int num;
            cin >> num;

            int last1 = num % 10;
            num /= 10;

            int last2 = num % 10;
            num /= 10;

            int last3 = num % 10;
            num /= 10;

            int sum = last1 + last2 + last3;

            cout << sum;

            return 0;
        }
  ```

## Homework 4

- Write a program that reads an integer and print the 4th from the right side.
- If no such digit, print 0.
- Inputs:
  - 15 => 0.
  - 125 => 0.
  - 1000 => 1.
  - 5001 => 5.
  - 1234 => 1.
  - 654321 => 4.
  - 99999 => 9.
- Solution:

  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int num;
            cin >> num;

            int fourth_num = (num / 1000) % 10;

            cout << fourth_num;

            return 0;
       }
  ```

## Homework 5

- Write a program that reads 2 numbers a, b and divide them (a / b), but prints only the fraction part.
- E.g. for inputs 201 and 25, print 0.04
  - Notice: 201 / 25 = 8.04.
  - We only want the fraction part: 0.4
- Solution:

  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            double a, b;
            cin >> a >> b;

            int int_div = (int) a / b;
            double double_dev = a / b;

            double fraction = double_dev - int_div;

            cout << fraction;

            return 0;
       }
  ```

## Homework 6

- We know N % M computes the remainder of division.
- Write a program that reads 2 integers and print such a reminder without using the modulus operator %.
- E.g. for inputs 27 and 12 => output 3.
  - Remember in math 27 % 12 = 3.
- Solution:

  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y;
            cin >> x >> y;

            int div = x / y;

            int reminder = x - (y * div);

            cout << reminder;

            return 0;
       }
  ```

## Homework 7

- Write a program that reads an integer and print 100 if number is even or 7 if number is ood.
  - E.g. for input 8 => 100.
  - E.g. for input 133 => 7.
- Note: if you know conditions, don't use them.
- Solution:

  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x;
            cin >> x;

            int is_even = (x % 2 == 0);
            int is_odd = 1 - is_even;

            int even_or_odd = is_even * 100 + is_odd * 7;
            cout << even_or_odd;

            return 0;
       }
  ```

## Homework 8

- Assume a year has 12 months, but each month is 30 days.
  - That is a year has 12 \* 30 = 360 days.
- Read an integer: whole number of days of someone age, print 3 numbers.
  - Total years.
  - Total months.
  - Total days.
- Inputs => Outputs.
  - 360 => 1 0 0 each 360 days a year.
  - 30 => 0 1 0 each 30 days a month.
  - 10 => 0 0 10 just days infant.
  - 391 => 1 1 1 391 = 360 + 30 + 1 = 1 year, 1 month, 1 day.
  - 61 => 0 2 1 61 = 2 \* 30 + 1.
  - 200 => 0 6 20 200 = 30 \* 6 + 20.
  - 1000 => 2 9 10 1000 = 2 _ 360 + 9 _ 30 + 10.
  - 5000 => 13 10 20
- Solution:

  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int days;
            cin >> days;

            int years = days / 360;
            days -= (years * 360);

            int months = days / 30;
            days -= (months * 30);

            cout << years << ' ' << months << ' ' << days;

            return 0;
       }
  ```
