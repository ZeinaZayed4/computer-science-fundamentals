# Selection - Homework

## Homework 1
- Read 2 integers A, B and print based on following cases:
    - if both are odd, print their product A * B.
    - if both are even, print their division A / B.
    - if the first is odd and the second is even, then find their sum A + B.
    - if the first is even and the second is odd, then find their subtraction A - B.
- Inputs => Outputs.
    - 5 7  => 35.
    - 12 2 => 6.
    - 5 6  => 11.
    - 12 3 => 9.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int A, B;
            cin >> A >> B;

            int first_even = (A % 2 == 0);
            int first_odd = 1 - first_even;
            int second_even = (B % 2 == 0);
            int second_odd = 1 - second_even;

            if (first_odd && second_odd)
                cout << A * B;
            else if (first_even && second_even)
                cout << A / B;
            else if (first_odd && second_even)
                cout << A + B;
            else
                cout << A - B;
  
            return 0;
        }
  ```

## Homework 2: Sort 3 numbers
- Given 3 integers, sort (order) them in ascending order and print them.
- Inputs:
    - 1 2 3 => 1 2 3.
    - 1 3 2 => 1 2 3.
    - 2 1 3 => 1 2 3.
    - 2 3 1 => 1 2 3.
    - 3 1 2 => 1 2 3.
    - 3 2 1 => 1 2 3.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y, z, tmp;
            cin >> x >> y >> z;

            int last = x;
            if (last > y)
                last = y;
            if (last > z)
                last = z;

            int first = x;
            if (first < y)
                first = y;
            if (first < z)
                first = z;

            int middle = x + y + z - first - last;

            cout << last << ' ' << middle << ' ' << first;
  
            return 0;
        }
  ```
- Another solution:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y, z, tmp;
            cin >> x >> y >> z;

            if (y < x) {
                tmp = x;
                x = y;
                y = tmp;
            }
    
            if (z < y) {
                tmp = y;
                y = z;
                z = tmp;
    
                if (y < x) {
                    tmp = x;
                    x = y;
                    y = tmp;
                }
            }
    
            cout << x << ' ' << y << ' ' << z;
  
            return 0;
        }
  ```

## Homework 3: Maximum but constrained
- Given 3 integers, you have to find the biggest on of them which is < 100.
    - Print -1 if no such number.
- Inputs:
    - 22 90 115 => 90
        - Here (20, 90) are only < 100. Maximum (20, 90) = 90
    - 200 300 400 => -1
        - All of them are > 100, so no answer.
    - 50 100 150 => 50
        - Only 50 is < 100.
    - 10 30 20 => 30
        - The 3 numbers < 100, so their max is 30
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int x, y, z;
            cin >> x >> y >> z;

            int result = -1;

            if (x < 100 && x > result)
                result = x;

            if (y < 100 && y > result)
                result = y;

            if (z < 100 && z > result)
                result = z;

            cout << result;
  
            return 0;
        }
  ```  

## Homework 4: Conditional Count
- Write a program that reads number X, then other 5 numbers.
- Print 2 values:
    - How many numbers <= X.
    - How many numbers > X.
    - Any relation between these 2 outputs.
- Inputs:
    - 10   300 1 5 100 200
    - Output: 2 3
    - Explanation:
        - 2 numbers (1, 5) are <= 10.
        - 3 numbers (300, 100, 200) are > 10.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int X, a, b, c, d, e;
            cin >> X >> a >> b >> c >> d >> e;

            int less_or_equal = 0;

            less_or_equal += (a <= X);
            less_or_equal += (b <= X);
            less_or_equal += (c <= X);
            less_or_equal += (d <= X);
            less_or_equal += (e <= X);

            cout << less_or_equal << ' ' << 5 - less_or_equal;
  
            return 0;
        }
  ```

## Homework 5: Find Maximum of 10
- Read 10 integers, find which of them has the biggest value and print it.
- Inputs:
    - 1 67 -9 88 -45 129 90 65 77 34 => 129
- Restriction: In your whole code, there should be 2 integer variables defined ONLY.
    - If hard constraint, code in whatever easier way for you.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int result, num;

            cin >> result;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cin >> num;
            if (result < num)
                result = num;

            cout << result;           
  
            return 0;
        }
  ```

## Homework 6: Find Maximum up to 10
- Read an integer N (2 <= N <= 10).
- Then read N integers, find which of them has the biggest value and print it.
- Inputs:
    - 5  1 3 2 4 2 => 4
        - 5 means read 5 integers.
        - Then we read them [1 3 2 4 2]. Their maximum is 4.
    - 10 1 67 -9 88 -45 129 90 65 77 34 => 129
        - Same as last homework.
        - This time we are given the first N (10).
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int cnt, result, num;
            cin >> cnt;

            cin >> result;
            cnt -= 1;

            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }
            if (cnt > 0) { cnt -= 1; cin >> num; if (result < num) result = num; }

            cout << result;         
  
            return 0;
        }
  ```

## Homework 7: Intervals
- Read number X then read 6 numbers s1, e1, s2, e2, s3, e3.
    - These 6 numbers are for 3 intervals.
    - Each interval is a range [start, end].
    - Number X in a range if start <= X <= end.
    - E.g. 7 in range [5, 12] but not in range [10, 20].
- Print how many digits X is part of it.
- Inputs:
    - 7   1 10  5 6  4 40 => 2.
        - Number 7 exists in 2 intervals [1, 10] and [4, 40].
    - 10  5 15  6 100  3 30 => 3.
        - 10 exists in the 3 intervals [5, 15], [6, 100] and [3, 30].
    - 10  100 200  100 101  120 170 => 0.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int X, s1, e1, s2, e2, s3, e3, cnt = 0;
            cin >> X >> s1 >> e1 >> s2 >> e2 >> s3 >> e3;

            if (X >= s1 && X <= e1)
                cnt++;

            if (X >= s2 && X <= e2)
                cnt++;

            if (X >= s3 && X <= e3)
                cnt++;

            cout << cnt;     
  
            return 0;
        }
  ```

## Homework 8: Two Intervals Intersection
- Read 4 numbers representing 2 intervals and print their intersection interval.
- If they don't intersect, print -1.
- Inputs:
    - 1 6  3 8 => 3 6.
        - Interval [1 6] and [3 8] only intersects at [3 6].
        - Why: interval [1 6] has numbers: {1, 2, **3, 4, 5, 6**}.
        - And: interval [3 8] has numbers: {**3, 4, 5, 6**, 7, 8}.
        - So, the intersection is {3, 4, 5, 6} = [3, 6].
    - 1 15  20 30 => -1.
- Code:
  ```c++
        #include <iostream>
        using namespace std;

        int main() {
            int s1, e1, s2, e2;
            cin >> s1 >> e1 >> s2 >> e2;

            if (e1 < s2 || e2 < s1)
                cout << -1;
            else {
                if (s1 < s2)
                    s1 = s2;
                if (e1 > e2)
                    e1 = e2;

                cout << s1 << ' ' << e1;
            }     
  
            return 0;
        }
  ```
