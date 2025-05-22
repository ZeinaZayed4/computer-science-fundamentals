# Division and Modulus

## Division: Integer and fraction parts

- 6 / 2 = 3.
- 12 / 2 = (6 + 6) / 2 = 6 / 2 + 6 / 2 = 3 + 3 = 6.
- 20 / 2 = (12 + 8) / 2 = 6 + 4 = 10.
- 21 / 2 = (20 + 1) / 2 = 10 + 0.5 = 10.5 (integer part = 10, fraction part = 0.5).
- 25 / 5 = 5.
- 26 / 5 = 25 / 5 + 1 / 5 = 5.2

## Division in C++

- If both numbers are integers, only integer part is result.
  - Fraction is ignored.
  - E.g. 27 / 5 = 5.4 => **5**.
- If any numbers in double style, then normal math.
  - 27 / 5 => **5.4**

## Division by 10

- Dividing by 10 removes last digit.
- Dividing by 100 remove last 2 digits and so on.
- **Notice** num / 1000 is same as num / 10 / 10 / 10.
- Ex:
  ```C++
      int num = 12345;
      cout << num / 10; // 5
  ```

## Even and odd

- Even number is divisible by 2.
  - E.g. 2, 4, 6, 8, 10, 12, ...
  - 8 / 2 => 4 => Even.
  - So always number.0
- Odd number is not divisible by 2.
  - E.g. 1, 3, 5, 7, 9, 11, ...
  - Let's divide them by 2.
  - 1 / 2 = 0.5.
  - 3 / 2 = 1.5.
  - So 0.5 1.5 2.5 3.5 4.5 5.5
  - Like 0.5 + (1, 2, 3, 4, 5, ...).
  - So always number.5

## Conversions

- We can convert double to integer.
  - The fraction part will be removed.
- Notice also chars converted to integer.
  - Every letter has a number.
  - E.g. small 'a' is 97.
  - Notice why 'A' is smaller than 'a'.
- To convert using (int) something.
- Ex:

  ```C++
       #include <iostream>
       using namespace std;

       int main() {
           double num = 8 / 3.0;
           cout << num << endl; // 2.66667

           int res = (int) num;
           cout << res << endl; // 2

           char ch = 'a';
           int ch_value = (int) ch;
           cout << ch_value << endl; // 97

           cout << (int) 'a' << ' ' << (int) 'z' << endl; // 97 122
           cout << (int) 'A' << ' ' << (int) 'Z' << endl; // 65 90

           return 0;
       }
  ```

## Modulus operation

- Let's use 12-hour clock cycle
- if it's 9 now, what time:
  - after 12h? Still 9.
  - after 4h? 1.
  - after 16 (4 + 12)h? 1.
  - after 17 (5 + 12)h? 2.
  - after 29 (5 + 2 \* 12)h? 2.
  - before 24 (2 \* 12)h? 9.
  - before 25 (1 + 2 \* 12)h? 8.
- **Every multiple of 12 is useless**.
- a modulus n = a % n = finds the reminder after division by n:
  - let a = 27, n = 12, then r = a % n?
  - 27 / 12 = (2 \* 12 + 3) / 12 = 2 + 3 / 12 = 2.25
    - 2 = Integer division part = called the **quotient**.
      - Means we have maximum 2 multiples of 12 (2 \* 12 = 24 <= 27).
    - 0.25 = fractional part.
    - 3 (reminder) of division = 27 - 24.
  - 27 % 12 = 3 => Reminder of division (must be < 12).

## Modulo % 2 and % 10

- Observations
  - Number % 2
    - 0 if number is even.
      - Even number is divisible by 2.
    - 1 for odd.
  - Number % 10 = last 1 digit.
  - Number % 100 = last 2 digits.
  - and so on...

## Summary

- Num % 2 => can tell us if number is even or odd.
- Num % 10 => **gives** us the last digit of num.
- Num / 10 => **removes** the last digit of num (integer division).
- r = n % k [r must be < n].
- We can convert double and char to integer.
