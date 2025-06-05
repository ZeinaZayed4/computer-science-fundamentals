# Pointer in C++

- A variable that stores an address of another variable.
- Code:
  ```c++
    int x = 20;
    cout << x << " address: " << &x << '\n';

    int *ptr = &x;
    cout << *ptr << " address: " << ptr << '\n';

    *ptr = 4;
    cout << x << " address: " << &x << '\n';
    cout << *ptr << " address: " << ptr << '\n';

    cout << "------------------------\n";

    int *p = new int(8);
    cout << *p << " address: " << p << '\n'; 
  
    return 0;
  ```
