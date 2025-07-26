# Time & Memory Complexity Analysis 1

## What is Time Complexity?
- How does the running time change as the size of input change.

## Cases Your Code May Face
1. Best case.
2. Average case.
3. Worst case.

## Notations to Represent Your Code's Complexity
1. O notation → the upper bound of the time.
2. Omega notation → the lower bound of the time.
3. Theta notation → the bound itself.

## Rules
1. Running time is the sum of running times of all consecutive blocks.
2. Nested loops are multiplied.
   - In general, → nested repetitive blocks are multiplied.
3. In conditional statements, pick the "Worst case" one.
4. Drop constants (addition, subtraction, multiplication, or division).
5. Drop all lower order terms.

## Examples
1. 
   ```c++
   int n;
   cin >> n;
      
   for (int i = 0; i < n; ++i) {
      
   } // O(n) -- linear
      
   for (int i = 0; i < n; ++i) { // O(n) -- linear
       for (int j = 0; j < n; ++j) { // O(n) -- linear
           cout << "Hello!";
       }
   } // O(n^2)
      
   // O(n + n^2) => O(n^2)
   ```
2.
   ```c++
   int n;
   cin >> n;
   
   if (n % 2 == 0) {
       for (int i = 0; i < n; ++i) { // O(n) -- linear
   
       }
   } else {
       for (int i = 0; i < n; ++i) { // O(n) -- linear
           for (int j = 0; j < n; ++j) { // O(n) -- linear
               cout << "Hello!";
           }
       } // O(n^2)
   }
   
   // O(n^2)
   ```
3. However, input changes, the no. of operations don't change.
   ```c++
   int calcSum(int a, int b) { // O(1)
       int sum = a + b;
       return sum;
   }
   ```
4. 
   ```c++
   double calcAverage(int a, int b) { // O(1)
       double avg = (a + b) / 2.0;
       return avg;
   }
   ```
5. 
   ```c++
   bool isAlphabet(char x) { // O(1)
       return (x >= 'A' && x <= 'Z' || x >= 'a' && x <= 'z');
   }
   ```
6.
   ```c++
   double sumHarmonicSeries(int n) { // O(n) -- linear
       double sum = 0;
   
       for (int i = 1; i <= n; ++i) {
           sum += (1.0 / i);
       }
       return sum;
   }
   ```
7. 
   ```c++
   long long calcSumSegment(int a, int b) { // O(b-a)
       long long sum = 0;
   
       for (int i = a; i <= b; ++i) {
           sum += i;
       }
       return sum;
   }
   ```
8. 
   ```c++
   int stepper(int n, int s) { // O(n/s)
       int ret = 0;
   
       for (int i = 1; i <= n; i += s) {
           ret += i;
       }
       return ret;
   }
   ```
9. 
   ```c++
   void merge(int* A, int szA, int* B, int szB, int* C) { // O(szA+szB) -- linear
       int idxA = 0, idxB = 0, idxC = 0;
   
       while (idxA < szA && idxB < szB) {
           if (A[idxA] < B[idxB]) C[idxC++] = A[idxA++];
           else C[idxC++] = B[idxB++];
       }
       while (idxA < szA) C[idxC++] = A[idxA++];
       while (idxB < szB) C[idxC++] = B[idxB++];
   }
   ```
10.
   ```c++
   int calcLog(int n) { // O(log(n))
       int ret = 0;
   
       while (n > 1) {
           ++ret;
           n /= 2;
       }
       return ret;
   }
   ```
11.
   ```c++
   bool binarySearch(int val, int n) { // O(log(n))
       int lo = 0, hi = n;
       while (hi - lo > 0) {
           int mid = (lo + hi) / 2;
           if (A[mid] == val) return true;
           if (A[mid] < val) lo = mid + 1;
           else hi = mid - 1;
       }
       return false;
   }
   ```
12.
   ```c++
   int fact(int n) { // O(n)
       if (!n || n == 1) return 1;
       return n * fact(n - 1);
   }
   ```
13.
   ```c++
   int power1(int base, int power) { // O(power)
       if (!power) return 1;
       return base * power1(base, power - 1);
   }
   ```
14.
   ```c++
   void printPowerOfTwoTill(int n) { // O(log(n))
       for (int p = 1; p <= n; p *= 2)
           printf("%d\n", p);
   }
   ```
15.
   ```c++
   int power2(int base, int power) { // O(log(n))
       if (! power) return 1;
       int sub = power2(base, power >> 1);
       return (power & 1 ? sub * sub * base : sub * base);
   }
   ```
16.
   ```c++
   int fib(int n) { // O(2^n)
       if (!n || n == 1) return n;
       return fib(n - 1) + fib(n - 2);
   }
   ```
17. ((n * (n + 1)) / 2)
   ```c++
   int n;
   cin >> n;
   
   for (int i = 1; i <= n; ++i) {
       for (int j = i; j <= n; ++j) {
       }
   } // O(n^2)
   ```
18.
   ```c++
   void searchArray() { // O(n*log(n))
       for (int i = 0; i < n; ++i) {
           if (binarySearch(B[i]))
               puts("Found");
           else
               puts("Not found");
       }
   }
   ```
19.
   ```c++
   void something(int n) { // O(n*log(n))
       for (int i = 1; i <= n; ++i) {
           for (int j = i; j <= n; j +=i) {
               //
           }
       }
   }
   ```

## Some Useful Observations
| Big O       | Name        | Max n                                        |
|-------------|-------------|----------------------------------------------|
| 0(1)        | Constant    | 1e18 → Math, observation.                    |
| O(Log(n))   | Logarithmic | 1e18 → Binary search (lower, upper, bound).  |
| O(n)        | Linear      | 1e8 → One loop.                              |
| O(n*Log(n)) | LogLinear   | 4e5 → Sorting, loop + binary search.         |
| O(n^2)      | Quadratic   | 1e4 → Nested loop.                           |
| O(2^n)      | Exponential | 25 → Bitmasks, finding all possible answers. |
| O(n!)       | Factorial   | 11 → Finding all permutations.               |
