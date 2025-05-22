# Logical Operators

- (> < >= <= == !=)
- Ex:

  ```C++
      #include <iostream>
      using namespace std;

      int main () {
          cout << (3 > 5) << endl; // 0
          cout << (3 < 5) << endl; // 1
          cout << (3 == 5) << endl; // 0
          cout << (3 != 5) << endl; // 1

          return 0;
      }
  ```

## We can also use variables.

- Ex:

  ```C++
      #include <iostream>
      using namespace std;

      int main () {
          int x, y;
          x = 3, y = 5;
          cout << (x > y) << endl; // 0
          cout << (x < y) << endl; // 1
          cout << (x == y) << endl; // 0
          cout << (x >= y) << endl; // 0

          return 0;
      }
  ```

## We can use bool variables.

- Ex:

  ```C++
        #include <iostream>
        using namespace std;

        int main () {
            int x, y;
            x = 3, y = 5;

            bool result = (x > y);
            cout << result << endl; // 0

            result = (x < y);
            cout << result << endl; // 1

            cout << !result << endl; // 0

            cout << !(x < y) << endl; // 0

            return 0;
        }
  ```

## Comparing strings

- Names are stored in **dictionary**.
- So comparison based on it.
- Upper case comes first from lower case.
  - Letter A smaller than a.
- Ex:

  ```C++
        #include <iostream>
        using namespace std;

        int main () {
            string name1 = "ali", name2 = "ali mostafa";
            string name3 = "ziad", name4 = "ali", name5 = "ALI";

            cout << (name1 < name2) << endl; // 1
            cout << (name1 > name3) << endl; // 0
            cout << (name1 != name4) << endl; // 0
            cout << (name1 == name4) << endl; // 1

            cout << (name1 == name5) << endl; // 0
            cout << (name1 > name5) << endl; // 1

            return 0;
        }
  ```

## AND Logical Operators

- Let say I am 30 years old, salary = 7000, and weight = 110 kg.
- Mostafa > 25 years and salary < 8000? True.
- Mostafa > 27 years and salary > 9000? False.
- Mostafa > 35 years and salary < 8500? False.
- Mostafa > 35 years and salary > 9000? False.
- Summary:
  - Only 1 case is True: when **both** conditions are True.
  - In discrete mathematics: p ^ q.

## OR Logical Operators

- Let say I am 30 years old, salary = 7000, and weight = 110 kg.
- Mostafa > 25 years and salary < 8000? True.
- Mostafa > 27 years and salary > 9000? True.
- Mostafa > 35 years and salary < 8500? True.
- Mostafa > 35 years and salary > 9000? False.
- Summary:
  - Only 1 case is False: when **both** conditions are False.
  - In discrete mathematics: p v q.

## Mixing Logical Operators

- Let say I am 30 years old, salary = 7000, and weight = 110 kg.
- Mostafa > 35 years or salary > 6000 or weight > 200kg? True.
- Mostafa > 35 years and salary > 6000 or weight > 200kg? True.
  - Reduce every subgroup of ANDs first.
  - F and T or F.
  - F or F => F.
- Mostafa > 20 years and salary > 10 and salary < 8000 or weight > 200kg?
  - T and T and T or F.
  - T or F => T.
- Precedence: Means what to apply first.
  - Here AND before OR.
  - What about 3 + 4 _ 5: is it 7 _ 5 or computed 3 + 20? _\* before +_

## C++ Operators

- && for and.
- || for or.
- Ex:

  ```C++
        #include <iostream>
        using namespace std;

        int main () {
            int age = 30, salary = 7000;

            bool result = (age > 25) && (salary < 8000); // T and T => T
            cout << result << endl; // 1

            cout << ((age > 25) && (salary > 9000)) << endl; // T and F => F (0)

            cout << ((age > 35) || (salary < 8500)) << endl; // F or T => T (1)

            cout << ((age > 35) || (salary > 9000)) << endl; // F or F => F (0)

            return 0;
        }
  ```

## Mixing Logical Operators in C++

```C++
      #include <iostream>
      using namespace std;

      int main () {
          int age = 30, salary = 7000, weight = 110;

          cout << ((age > 25) && (salary < 8000) && (weight < 150)) << endl; // T and T and T => T (1)
          cout << ((age > 25) && (salary < 8000) && (weight > 200)) << endl; // T and T and F => F (0)

          cout << ((age > 35) || (salary > 6000) || (weight > 200)) << endl; // F or T or F => T (1)

          cout << ((age > 35) && (salary > 6000) || (weight > 200)) << endl; // F and T or F => F or F => F (0)
          cout << ((age > 20) && (salary > 6000) || (weight > 200)) << endl; // T and T or F => T or F => T (1)

          return 0;
     }
```

## So far

- All conditions are ANDed.
  - True IFF **all** ANDed conditions are true.
- All conditions are ORed.
  - True if **any** condition is true.
  - False if all are false.
- Mixed ORs and ANDs.
  - Find each subgroup of ANDs and evaluate first.
  - Do normal ORing for the remaining.
- Advanced: What if I want to **force** specific priority?
  - Use ().
  - Every group of () is computed first.
  - Find the simplest and reduce first.
  - _Rarely used in practice_.

## () applied first

```C++
      #include <iostream>
      using namespace std;

      int main () {
          int age = 30, salary = 7000, weight = 110;

          // ANDs are evaluated
          cout << (age > 35 || salary > 6000 && weight > 200) << endl; // F or T and F => F or F => F (0)

          // () are evaluated FIRST even before some ANDs
          cout << ((age > 35 || salary > 6000) && weight > 200) << endl; // (F or T) and F => T and F => F (0)

          return 0;
      }
```

## Let's try simplifying

- Let's simplify this expression T && T && (F || (T && T)) || T.
- T && T && (F || (T && T)) || T => (T && T) is the simplest (). Its value is T.
- T && T && (F || T) || T => (F || T) is the simplest. Its value is T.
- T && T && T || T => No more (). Next is group ANDs.
- T && T && T || T => T && T && T is group of ANDs. Evaluate T.
- T || T. Now final expression is set of conditions ORed => T.

## Coding mistakes

- Writing < = NOT <= (extra space).
- Writing & NOT &&.
- Writing & & NOT && (extra space).
- Writing | NOT ||.
  - $ and | are called **bits operators**.
- Writing = NOT ==.
  - = is assignment.
  - == is for comparing.
- Writing ! result NOT !result (extra space).
- cout << x < 5 << "\n";
  - Compiler get confused.
  - Use () => cout << (x < 5) << "\n";
- Imbalanced expression: (T || (T && F) => (T || (T && F)).
