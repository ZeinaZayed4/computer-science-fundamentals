# Selection

## if conditions
- Write a program that reads an integer salary.
- Then if salary < 1000,
  - print you are poor.
- Otherwise, do nothing.
- End program with printing Salam.
- if (condition)
  - body
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int salary;
            cin >> salary;
  
            if (salary < 1000)        
                cout << "You are poor.\n";
  
            cout << "Salam..";
  
            return 0;
        }
  ```

## What if I want a big body?
- Use {} if you want to do more logic.
  - You can write whatever.
- Be careful, from scope.
  - What inside {} not visible outside it.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int num;
            cin >> num;
  
            if (num == 10) {
                int x = 3;       
                cout << "10 is lucky number.\n";
                cout << "also " << 2 * num + x << endl;
            }
  
            // cout << x; # not visible here
  
            return 0;
        }
  ```

## What if I need more conditions?
- Write a program that reads an integer salary then:
- If salary < 1000,
  - print you are poor.
- Else if salary >= 1000 and < 20000,
  - print good salary.
- Else if salary > 20000,
  - print you are rich.
- Now, how to command computer to do these if else?
- Good software engineer tests well his code. What are good test cases?
  - 0, 500, 1000, 10000, 200000, 1000000000.

## The if-else Chain
- if (cond)
  - Go to body ONLY if cond true.
- If previous condition is not correct, move to next.
- else if (cond)
  - Again true, get it in.
- If previous false, move to next.
- else
  - Get in if nothing previous worked.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int salary;
            cin >> salary;
  
            if (salary < 1000)        
                cout << "You are poor.\n";
            else if (salary >= 1000 && salary < 20000)
                cout << "Good salary.\n";
            else {
                cout << "You are rich.\n";
                cout << "lucky guy?\n";
            }
  
            return 0;
        }
  ```

## How many digits?
- Read an integer and print if it has
  - 1, 2, 3, 4 or 5+ digits.
- For example if inputs is 556,
  - Then print: 3 digits.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int num;
            cin >> num;

            if (num < 10)
                cout << "1 digit.\n";
            else if (num < 100)
                cout << "2 digits.\n";
            else if (num < 1000)
                cout << "3 digits.\n";
            else if (num < 10000)
                cout << "4 digits.\n";
            else
                cout << "5 or more digits.\n";

            return 0;
        }
  ```

## Nested if conditions
- Inside the body scope, we can do whatever.
- Even another if (nested if).
- Or if () { if () { if () } }
- So whatever code body.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int salary;
            cout << "Enter salary: ";
            cin >> salary;
  
            if (salary < 1000) {
                cout << "Enter age: ";
                int age;
                cin >> age;
  
                if (age < 22)
                    cout << "You are still young.\n";
            }
            else
                cout << "You are rich.\n";
  
            return 0;
        }
  ```

## Simple calculator
- Given two numbers and a sign between them which will indicate if the user want the addition, subtraction, division, or multiplication of these two numbers, find the value of the answer.
- Inputs => Outputs.
  - 7 + 55 => 62.
  - 7 * 10 => 70.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            double x, y, result;
            char op;
            cin >> x >> op >> y;

            if (op == '+') {
                result = x + y;
                cout << x << ' ' << op << ' ' << y << " = " << result;
            }
            else if (op == '-') {
                result = x - y;
                cout << x << ' ' << op << ' ' << y << " = " << result;
            }
            else if (op == '*') {
                result = x * y;
                cout << x << ' ' << op << ' ' << y << " = " << result;
            }
            else {
                result = x / y;
                cout << x << ' ' << op << ' ' << y << " = " << result;
            }
  
            return 0;
        }
  ```  

## Minimum of 2 numbers
- Read 2 integers and print the minimum one of them.
- Inputs => Outputs.
  - 10 20 => 10.
  - 70 5  => 5.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y;
            cin >> x >> y;

            if (x < y)
                cout << x;
            else
                cout << y;
  
            return 0;
        }
  ```

## Minimum of 3 numbers
- Read 3 integers and print the minimum one of them.
- Inputs => Outputs.
  - 10 20 30 => 10.
  - 70 5 15 => 5.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y, z;
            cin >> x >> y >> z;

            if (x < y && x < z)
                cout << x;
            else if (y < x && y < z)
                cout << y;
            else
                cout << z;
  
            return 0;
        }
  ```
- Another way of code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y, z;
            cin >> x >> y >> z;

            int answer = x;

            if (answer > y)
                answer = y;

            if (answer > z)
                answer = z;

            cout << answer;
  
            return 0;
        }
  ```

## Practice: Is even? Print digits
- Read an integer N, then do the following:
  - If the number is even, print last digit of it.
  - If the number is odd, do the following:
    - If number < 1000, print last 2 digits.
    - If number >= 1000 and number < 1000000, print last 4 digits.
    - Otherwise, print its negative value.
- Testing examples of good coverage:
  - 234 => even => 4.
  - 157 => 57.
  - 567169 => 7169.
  - 1000001 => -1000001.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int N;
            cin >> N;

            if (N % 2 == 0)
                cout << N % 10;
            else {
                if (N < 1000)
                    cout << N % 100;
                else if (N >= 1000 && N < 1000000)
                    cout << N % 10000;
                else
                    cout << -N;
            }
  
            return 0;
        }
  ```

## Practice: Last 3 digits
- Read an integer and do the following:
  - If number < 10000, say this is a small number.
  - Otherwise, Sum the last 3 digits of the number.
    - If the sum is odd, say this is a great number.
    - Otherwise, if sum is even:
      - If any digit of the last 3 is odd, say this is a good number.
      - Otherwise, say this is a bad number.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int N;
            cin >> N;

            if (N < 10000)
                cout << "This is a small number.";
            else {
                int digit1 = N % 10;
                N /= 10;
                int digit2 = N % 10;
                N /= 10;
                int digit3 = N % 10;
                N /= 10;
        
                int sum = digit1 + digit2 + digit3;

                if (sum % 2 == 1)
                    cout << "This is a great number.";
                else {
                    if (digit1 % 2 == 1 || digit2 % 2 == 1 || digit3 % 2 == 1)
                        cout << "This is a good number.";
                    else
                        cout << "This is a bad number.";
                }

            }
  
            return 0;
        }
  ```
