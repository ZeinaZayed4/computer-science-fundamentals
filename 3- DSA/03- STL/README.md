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
---
- `Deque`:
    ```c++
    #include <iostream>
    #include <deque>
  
    using namespace std;
  
    int q, n;
    string command;
    bool isReversed;
    deque<int> dq;
  
    int main () {
        cin >> q;
  
        while (q--) { // O(q)
            cin >> command;
  
            if (command == "back") { // O(1)
                if (dq.empty()) {
                    cout << "No job fo Ada?\n";
                } else {
                    if (isReversed) {
                        cout << dq.front() << '\n';
                        dq.pop_front();
                    } else {
                        cout << dq.back() << '\n';
                        dq.pop_back();
                    }
                }
            } else if (command == "front") { // O(1)
                if (dq.empty()) {
                    cout << "No job fo Ada?\n";
                } else {
                    if (isReversed) {
                        cout << dq.back() << '\n';
                        dq.pop_back();
                    } else {
                        cout << dq.front() << '\n';
                        dq.pop_front();
                    }
                }
            } else if (command == "reverse") { // O(1)
                isReversed = !isReversed;
            } else if (command == "push_back") { // O(1)
                cin >> n;
  
                if (isReversed) {
                    dq.push_front(n);
                } else {
                    dq.push_back(n);
                }
            } else { // O(1)
                cin >> n;
  
                if (isReversed) {
                    dq.push_back(n);
                } else {
                    dq.push_front(n);
                }
            }
        }
  
        return 0;
    }
    ```
---
- `queue`:  
    ```c++
    #include <iostream>
    #include <queue>
  
    using namespace std;
  
    queue<int> q;
  
    int main () {
        q.push(1);
        q.push(2);
        q.push(3);
  
        while (! q.empty()) {
            cout << q.front() << '\n';
            q.pop();
        }
  
        return 0;
    }
    ```
---
- `stack`:  
    ```c++
    #include <iostream>
    #include <stack>
  
    using namespace std;
  
    stack<int> s;
  
    int main () {
        s.push(1);
        s.push(2);
        s.push(3);
  
        while (! s.empty()) {
            cout << s.top() << '\n';
            s.pop();
        }
  
        return 0;
    }
    ```
---
- **Problem:**
    ```c++
    #include <iostream>
    #include <stack>
    #include <queue>
    
    using namespace std;
    
    int n, x;
    
    int main () {
        while (cin >> n, n) {
            queue<int> q;
            for (int i = 0; i < n; ++i) {
                cin >> x;
                q.push(x);
            }
    
            stack<int> s;
            int next = 1;
    
            while (! q.empty() || (! s.empty() && s.top() == next)) {
                if (! q.empty() && q.front() == next) {
                    q.pop();
                    next++;
                } else if (! s.empty() && s.top() == next) {
                    s.pop();
                    next++;
                } else if (! q.empty()) {
                    s.push(q.front());
                    q.pop();
                }
            }
    
            if (next == n + 1) {
                cout << "yes\n";
            } else {
                cout << "no\n";
            }
        }
    
        return 0;
    }
    ```
---
- **Problem:**
    ```c++
    #include <iostream>
    #include <stack>
    
    using namespace std;
    
    string s;
    stack<char> st;
    
    int main () {
        cin >> s;
    
        for (char c : s) {
            if (c == '(' || c == '[') {
                st.push(c);
            } else if (c == ']') {
                if (! st.empty() && st.top() == '[') {
                    st.pop();
                } else {
                    cout << "NO\n";
                    return 0;
                }
            } else if (c == ')') {
                if (! st.empty() && st.top() == '(') {
                    st.pop();
                } else {
                    cout << "NO\n";
                    return 0;
                }
            }
        }
    
        if (st.empty()) {
            cout << "YES\n";
        } else {
            cout << "NO\n";
        }
    
        return 0;
    }
    ```
---
- **Parentheses Balance**
    ```c++
    #include <iostream>
    #include <stack>
    
    using namespace std;
    
    int n;
    string s;
    
    int main() {
        cin >> n;
        cin.ignore();
    
        for (int i = 0; i < n; ++i) {
            getline(cin, s);
            stack<char> st;
            bool valid = true;
    
            for (char c: s) {
                if (c == '[' || c == '(') {
                    st.push(c);
                } else if (!st.empty() && ((st.top() == '[' && c == ']') || (st.top() == '(' && c == ')'))) {
                    st.pop();
                } else {
                    valid = false;
                    break;
                }
            }
    
            if (valid && st.empty()) {
                cout << "Yes\n";
            } else {
                cout << "No\n";
            }
        }
    
        return 0;
    }
    ```
---
- **Monotonic Queue**
    ```c++
    #include <iostream>
    #include <queue>
    
    using namespace std;
    
    queue<int> q;
    deque<int> dq;
    
    void push(int x) { // O(n) => amortized O(1)
        q.push(x);
    
        while (!dq.empty() && dq.back() < x) {
            dq.pop_back();
        }
        dq.push_back(x);
    }
    
    void pop() { // O(1)
        if (dq.front() == q.front()) {
            dq.pop_front();
        }
        q.pop();
    }
    
    int front() { // O(1)
        return q.front();
    }
    
    int getMax() { // O(1)
        return dq.front();
    }
    
    int t, x;
    string command;
    
    int main() {
        cin >> t;
        while (t--) {
            cin >> command;
    
            if (command == "push") {
                cin >> x;
                push(x);
            } else if (command == "pop") {
                pop();
            } else if (command == "front") {
                cout << front() << '\n';
            } else if (command == "max") {
                cout << getMax() << '\n';
            }
        }
    
        return 0;
    }
    ```
---

