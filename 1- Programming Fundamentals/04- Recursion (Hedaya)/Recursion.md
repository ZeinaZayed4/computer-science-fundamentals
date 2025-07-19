# Recursion

1. State.
2. Transition.
3. Base case.

## Factorial example:
```c++
#include <iostream>
using namespace std;

int f1(int n) {
    return 1;
}

int f2(int n) {
    return n * f1(n - 1);
}

int f3(int n) {
    return n * f2(n - 1);
}

int f4(int n) {
    return n * f3(n - 1);
}

int main() {
    cout << f4(4);

    return 0;
}
```

```c++
#include <iostream>
using namespace std;

int f(int n) {
    if (n == 1)
        return 1;
    return n * f(n - 1);
}

int main() {
    cout << f(4);

    return 0;
}
```

## String Reverse
```c++
#include <iostream>
using namespace std;

string s;

void rev(int idx = 0) {
    if (idx == s.size())
        return;
    rev(idx + 1);
    cout << s[idx];
}

int main() {
    s = "abcdef";
    rev();

    return 0;
}
```

## Array Sum
```c++
#include <iostream>
using namespace std;

const int N = 1000;
int arr[N], n;

int sum(int idx = 0) {
    if (idx == n)
        return 0;
    return arr[idx] + sum(idx + 1);
}

int main() {
    cin >> n;
    for (int i = 0; i < n; ++i) {
        cin >> arr[i];
    }

    cout << sum(0);
    return 0;
}
```

## 3n1
```c++
#include <iostream>
using namespace std;

int get_3n1(int n) {
    if (n == 1)
        return 1;
    if (n % 2 == 0)
        return 1 + get_3n1(n / 2);
    return 1 + get_3n1(3 * n + 1);
}

int main() {
    int n;
    cin >> n;

    cout << get_3n1(n);
    return 0;
}
```

## Time Complexity for Recursion
- `No. of calls * O(each state)`.

## Power
```c++
#include <iostream>
using namespace std;

int power(int b, int p) {
    if (! p)
        return 1; // O(1)
    return b * power(b, p - 1);
}

int main() {
    int b, p;
    cin >> b >> p;

    cout << power(b, p); // p * O(1) = O(p)

    return 0;
}
```

```c++
#include <iostream>
using namespace std;

int power(int b, int p) {
    if (! p)
        return 1;
    int ret = power(b, p / 2);
    return (p & 1 ? ret * ret * b : ret * ret);
}

int main() {
    int b, p;
    cin >> b >> p;

    cout << power(b, p);

    return 0;
}
```

## Pascal's Triangle
```c++
#include <iostream>
using namespace std;

int pascal(int r, int c) {
    if (c == 0 || c == r)
        return 1;
    return pascal(r - 1, c) + pascal(r - 1, c - 1);
}

int main() {
    int r, c;
    cin >> r >> c;

    cout << pascal(r, c);
    return 0;
}
```
