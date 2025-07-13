# Functions Lecture 2

## Scope Resolution Operator
- `::x`
    ```c++
    #include <iostream>
    using namespace std;
    
    int x = 8;
    
    int main() {
        int x = 4;
    
        cout << ::x; // 8
    
        return 0;
    }
    ```

## Storage Classes vs. Scope
- Storage class affects lifetime and storage location.
- Scope affects visibility and accessibility.

## Scopes
1. Function scope
    - goto
    - ```c++
      #include <iostream>
      using namespace std;

      int main() {
         for (int i = 0; i < 100; ++i) {
             for (int j = 0; j < i; ++j) {
                 int z = i;
                 while (z < 100) {
                     if (z % 2)
                         goto zeina;
                     z++;
                 }
             }
         }
        
         zeina:
      
         return 0;
      }
      ```
2. Global namespace scope
    - Accessed in the whole file.
3. Local scope
    - Defined within a block.
4. Function prototype scope
    - Variables defined in prototype function.
    - `void f(int x, int y);`

## Inline Functions
- functions called many times in your code.
- ignore overhead to save in runtime, but increased time for processing.
    ```c++
    #include <iostream>
    using namespace std;
    
    inline int sum(int x, int y) {
        return x + y;
    }
    
    int main() {
        int x, y;
        cin >> x >> y;
    
        cout << sum(x, y);
    
        return 0;
    }
    ```

## References (Aliases)
- `&`
    ```c++
    #include <iostream>
    using namespace std;
    
    int main() {
        int z = 8;
        int &y = z; // alias
        
        cout << &z << ' ' << z << '\n';
        cout << &y << ' ' << y;
    
        return 0;
    }
    ```

## Reference Parameter
- Passing parameters to functions.
1. Pass by copy/value.
   - ```c++
     #include <iostream>
     using namespace std;

     void f(int x, int y) {
        x += 2;
        y += 4;
     }

     int main() {
        int a = 4;
        int b = 8;

         f(a, b);
         cout << a << ' ' << b; // 4 8

         return 0;
     }
     ```
2. Pass by reference.
    - ```c++
      #include <iostream>
      using namespace std;

      void f(int &x, int &y) {
         x += 2;
         y += 4;
      }

      int main() {
          int a = 4;
          int b = 8;

          f(a, b);
          cout << a << ' ' << b; // 6 12

          return 0;
      }
      ```

## Default Parameters
```c++
#include <iostream>
using namespace std;

void f(int x, int y = 6, int z = 2) {
    cout << x << ' ' << y << ' ' << z << '\n';
}

int main() {
    f(4); // 4 6 2
    f(4, 8); // 4 8 2
    f(4, 8, 10); // 4 8 10

    return 0;
}
```

## Function Overloading
- We differentiate between functions overloading through **signature (name, parameters)**.
- return type doesn't differentiate if the functions have the same signature.

## Problems
1. https://leetcode.com/problems/power-of-two/
    ```c++
    bool isPowerOfTwo(int n) {
        if (n < 0)
            return false;
        int cntOnes = __builtin_popcount(n);
        return (cntOnes == 1);
    }
   ```
2. https://leetcode.com/problems/move-zeroes/description/
    ```c++
    void moveZeroes(vector<int>& nums) {
        int last = 0;
        int n = int(nums.size());
        for (int i = 0; i < n; ++i) {
            if (nums[i] != 0) {
                nums[last] = nums[i];
                last++;
            }
        }
    
        for (int i = last; i < n; ++i) {
            nums[i] = 0;
        }
    
        for (int i = 0; i < n; ++i) {
            cout << nums[i] << " \n"[i == n-1];
        }
    }
    ```
3. https://atcoder.jp/contests/abc198/tasks/abc198_b
    ```c++
    #include <algorithm>
    #include <iostream>
    using namespace std;
    
    string s;
    
    bool check_palindrome(string t) {
        string rev = t;
        reverse(rev.begin(), rev.end());
        return (rev == t);
    }
    
    int main() {
        cin >> s;
    
        if (check_palindrome(s)) {
            return cout << "Yes\n", 0;
        }
    
        int idx = (int) s.size() - 1;
        while (s[idx] == '0')
            idx--;
    
        string newString;
        for (int i = 0; i <= idx; ++i) {
            newString += s[i];
        }
    
        if (check_palindrome(newString))
            cout << "Yes\n";
        else
            cout << "No\n";
        return 0;
    }
    ```
