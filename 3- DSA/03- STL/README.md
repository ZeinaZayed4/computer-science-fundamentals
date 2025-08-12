# Standard Template Library (STL)

- Sort 2D points using `struct`:
    ```c++
    #include <iostream>
    #include <algorithm>
    
    using namespace std;
    
    struct Point {
        int x;
        int y;
    };
    
    bool cmp(Point a, Point b) {
        return (a.x == b.x) ? (a.y < b.y) : (a.x < b.x);
    }
    
    const int N = 1e5;
    
    int n;
    Point A[N];
    
    int main() {
        cin >> n;
    
        for (int i = 0; i < n; ++i) {
            cin >> A[i].x >> A[i].y;
        }
    
        sort(A, A + n, cmp);
    
        for (int i = 0; i < n; ++i) {
            cout << A[i].x << ' ' << A[i].y << '\n';
        }
    
        return 0;
    }
    ```
---
- Sort 2D points using `pair`:
    ```c++
    #include <iostream>
    #include <algorithm>
    
    using namespace std;
    
    const int N = 1e5;
    
    int n;
    pair<int, int> A[N];
    
    int main() {
        cin >> n;
    
        for (int i = 0; i < n; ++i) {
            cin >> A[i].first >> A[i].second;
        }
    
        sort(A, A + n);
    
        for (int i = 0; i < n; ++i) {
            cout << A[i].first << ' ' << A[i].second << '\n';
        }
    
        return 0;
    }
    ```
---
- Sort 3D points using `pair`:
    ```c++
    #include <iostream>
    #include <algorithm>
    
    using namespace std;
    
    const int N = 1e5;
    
    int n;
    pair<int, pair<int, int>> A[N];
    
    int main() {
        cin >> n;
    
        for (int i = 0; i < n; ++i) {
            cin >> A[i].first >> A[i].second.first >> A[i].second.second;
        }
    
        sort(A, A + n);
    
        for (int i = 0; i < n; ++i) {
            cout << A[i].first << ' ' << A[i].second.first << ' ' << A[i].second.second << '\n';
        }
    
        return 0;
    }
    ```
---
- `vector`:
    ```c++
    #include <iostream>
    #include <algorithm>
    #include <vector>
    
    using namespace std;
    
    const int N = 1e5;
    
    int n, x;
    vector<int> v;
    
    int main() {
        cin >> n;
    
        for (int i = 0; i < n; ++i) {
            cin >> x;
            v.push_back(x);
        }
    
        sort(v.begin(), v.end());
        for (int i : v) {
            cout << i << ' ';
        } // 1 2 3 4 5 6
        cout << '\n';
    
        // 1 2 3 {-1} 4 5 6
        v.insert(v.begin() + 3, -1);
        for (int i : v) {
            cout << i << ' ';
        } // 1 2 3 -1 4 5 6
        cout << '\n';
    
        v.erase(v.begin() + 3);
        for (int i : v) {
            cout << i << ' ';
        } // 1 2 3 4 5 6
    
        return 0;
    }
    ```
