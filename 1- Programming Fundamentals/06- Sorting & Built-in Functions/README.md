# Sorting & Built-in Functions

- Merge two sorted arrays in a new sorted array
    ```c++
    #include <iostream>
    using namespace std;
    
    void merge(int* A, int szA, int* B, int szB) { // O(szA + szB)
        int* C = new int [szA + szB];
        int idxA = 0, idxB = 0, idxC = 0;
    
        while (idxA < szA && idxB < szB) {
            C[idxC++] = (A[idxA] < B[idxB] ? A[idxA++] : B[idxB++]);
        }
    
        while (idxA < szA)
            C[idxC++] = A[idxA++];
    
        while (idxB < szB)
            C[idxC++] = B[idxB++];
    
        for (int i = 0; i < szA + szB; ++i) {
            cout << C[i] << ' ';
        }
    }
    
    int main() {
        int A[] = {5, 8, 9};
        int B[] = {1, 2, 4, 5, 6, 7, 8, 9, 10, 11};
        merge(A, 3, B, 10);
    
        return 0;
    }
    ```
---
- Merge Sort
  ```c++
  #include <iostream>
  using namespace std;
  
  const int N = 1e3 + 2;
  
  int n;
  int A[N];
  
  void merge(int* A, int szA, int* B, int szB) {
      int* C = new int [szA + szB];
      int idxA = 0, idxB = 0, idxC = 0;
  
      while (idxA < szA && idxB < szB) {
          C[idxC++] = (A[idxA] < B[idxB] ? A[idxA++] : B[idxB++]);
      }
  
      while (idxA < szA)
          C[idxC++] = A[idxA++];
  
      while (idxB < szB)
          C[idxC++] = B[idxB++];
  
      for (int i = 0; i < szA + szB; ++i) {
          A[i] = C[i];
      }
  
      delete [] C;
  }
  
  void mergeSort(int* A, int sz) { // O(n*log(n))
      if (sz < 2)
          return;
  
      int half = sz/2;
      mergeSort(A, half); // sorts first half
      mergeSort(A + half, sz - half); // sorts second half
      merge(A, half, A + half, sz - half); // combine the two sorted arrays into one
  }
  
  int main() {
      cin >> n;
      for (int i = 0; i < n; ++i) {
          cin >> A[i];
      }
  
      mergeSort(A, n);
  
      for (int i = 0; i < n; ++i) {
          cout << A[i] << " "[i==n-1];
      }
  
      return 0;
  }
  ```
---
- Built-in `sort()` Function
  ```c++
  #include <iostream>
  #include <algorithm>
  using namespace std;
  
  const int N = 1e3 + 2;
  
  int n;
  int A[N];
  
  int main() {
      cin >> n;
      for (int i = 0; i < n; ++i) {
          cin >> A[i];
      }
      
      sort(A, A + n);
      
      for (int i = 0; i < n; ++i) {
          cout << A[i] << " "[i==n-1];
      }
  
      return 0;
  }
  ```
---
- Pair Sum
  - Solution 1
    ```c++
    #include <iostream>
    #include <algorithm>
    using namespace std;
    
    const int N = 1e3 + 2;
    
    int n, target;
    int A[N];
    
    void solveN2() {
        bool found = false;
        for (int i = 0; i < n; ++i) { // O(n^2)
            for (int j = i + 1; j < n; ++j) {
                if (A[i] + A[j] == target)
                    found = true;
            }
        }
        cout << (found ? "YES" : "NO") << '\n';
    }
    
    int main() {
        cin >> n >> target;
        for (int i = 0; i < n; ++i) {
            cin >> A[i];
        }
    
        solveN2();
    
        return 0;
    }
    ```
  - Solution 2  
    ```c++
    #include <iostream>
    #include <algorithm>
    using namespace std;
    
    const int N = 1e3 + 2;
    
    int n, target;
    int A[N];
    
    // returns the index of 'value' in the array if exists or sz
    int find(int* A, int sz, int value) { // O(n)
        for (int i = 0; i < sz; ++i) {
            if (A[i] == value)
                return i;
        }
        return sz;
    }
    
    void solve() { // O(n*log(n))
        bool found = false;
        sort(A, A + n); // O(n*log(n))
        for (int i = 0; i < n; ++i) {
            int rem = target - A[i];
            // int sz = n - i - 1;
            // does the array have the value 'rem'?
            if (binary_search(A + i + 1, A + n, rem)) { // O(log(n))
                found = true;
            }
            // if (find(A + i + 1, sz, rem) != sz) {
            //     found = true;
            // }
        }
        cout << (found ? "YES" : "NO") << '\n';
    }
   
    int main() {
        cin >> n >> target;
        for (int i = 0; i < n; ++i) {
            cin >> A[i];
        }
    
        solve();
    
        return 0;
    }
    ```
  - Count of pairs
    ```c++
    #include <iostream>
    #include <algorithm>
    using namespace std;
    
    const int N = 1e3 + 2;
    
    int n, target;
    int A[N];
    
    void solveCount() {
        int found = 0;
        sort(A, A + n); // O(n*log(n))
        for (int i = 0; i < n; ++i) {
            int rem = target - A[i];
            if (binary_search(A + i + 1, A + n, rem)) { // O(log(n))
                int cnt = upper_bound(A + i + 1, A + n, rem) - lower_bound(A + i + 1, A + n, rem);
                found += cnt;
            }
        }
        cout << found << '\n';
    }
    
    int main() {
        cin >> n >> target;
        for (int i = 0; i < n; ++i) {
            cin >> A[i];
        }
    
        solveCount();
    
        return 0;
    }
    ```
