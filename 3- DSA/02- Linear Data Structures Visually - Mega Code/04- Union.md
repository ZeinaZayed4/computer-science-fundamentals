# Union

- Same as the structure but with a difference:
  - union can store only one value.

## Structure
```c++
#include <iostream>
using namespace std;

struct numbers {
    int x;
    int y;
    int z;
};

int main() {
    numbers n;
    n.x = 10;
    n.y = 20;
    n.z = 30;

    cout << "x = " << n.x << '\n'; // 10
    cout << "y = " << n.y << '\n'; // 20
    cout << "z = " << n.z << '\n'; // 30

    return 0;
}
```

## Union
```c++
#include <iostream>
using namespace std;

union numbers {
    int x;
    int y;
    int z;
};

int main() {
    numbers n;
    n.x = 10;
    n.y = 20;
    n.z = 30;

    cout << "x = " << n.x << '\n'; // 30
    cout << "y = " << n.y << '\n'; // 30
    cout << "z = " << n.z << '\n'; // 30

    return 0;
}
```
