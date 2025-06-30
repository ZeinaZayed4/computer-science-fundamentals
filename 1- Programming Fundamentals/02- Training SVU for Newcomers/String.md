# String

- String is a collection of characters written in double quotation.
- It may consist of alphabetic characters, digits, and special symbols.
- The library of the string is `#include <string>`
- Store a string as an array of characters.
- An array is a group of contentious memory locations that store the same type of data. So, the string declaration is the same as array declaration.

## String Initialization
- A string variable can be initialized with a string value as follows:
  ```c++
  string s = "Hello!";
  ```

## String Functions
1. `str.size() => O(1) / str.length()`
2. `str.push_back() => O(1)`
   - Adds a character at the end of the string.
     ```c++
     #include <iostream>
     #include <string>
     using namespace std;

     int main() {
       string s = "AO";
       s.push_back('T');
       cout << s << '\n'; // AOT
       return 0;
     }
     ```
3. `str.pop_back() => O(1)`
    - removes the last character from a string.
      ```c++
      #include <iostream>
      #include <string>
      using namespace std;

      int main() {
          string s = "Fool";
          s.pop_back();
          cout << s << '\n'; // Foo
          return 0;
      }
      ```
4. `str.erase() => O(str.size())`
   - removes a substring from a string.
   - This substring starts from index (pos), and the length of this substring is (len) 0 <= pos < str.size(), if (pos) doesn't satisfy this condition, you will get **runtime error**.
     ```c++
     #include <iostream>
     #include <string>
     using namespace std;

     int main() {
         string s = "Zeina Zayed";
         s.erase(0, 6);
         cout << s << '\n'; // Zeina
         return 0;
     }
     ```
5. `str.substr() => O(n)`
    - returns a substring from a string.
    - This substring starts from index (pos), and the length of this substring is (len) 0 <= pos < str.size(), if (pos) doesn't satisfy this condition, you will get **runtime error**.
      ```c++
      #include <iostream>
      #include <string>
      using namespace std;
 
      int main() {
          string s = "Zeina Zayed";
          cout << s.substr(0, 6) << '\n'
               << s.substr(6, s.size() - 1);
          // Zeina
          // Zayed
          return 0;
      }
      ```
6. `str.resize()`
    - changes the size of a string to (len).
      ```c++
      #include <iostream>
      #include <string>
      using namespace std;
 
      int main() {
          string a = "ACM";
          string b = "ACPC";
          a.resize(2);
          b.resize(7);
          cout << a << '\n' << b;
          // AC
          // ACPC   
          return 0;
      }
      ```
7. `str.insert() => O(str.size())`
    - inserts a string or a character to the original string.
       ```c++
       #include <iostream>
       #include <string>
       using namespace std;
  
       int main() {
           string s = "You see me";
           s.insert(4, "can ");
           cout << s; // You can see me
           return 0;
       }
       ```
8. `str.front()` `str.back()`
    - returns the first character of the string.
    - returns the last character of the string.
        ```c++
        #include <iostream>
        #include <string>
        using namespace std;
   
        int main() {
            string s = "ZeinA";
            cout << s.front() << " * " << s.back(); // Z * A
            return 0;
        }
        ```
9. `getline(str, cin)`
    - helps you to take all the lines in the string with the white spaces.
         ```c++
         #include <iostream>
         #include <string>
         using namespace std;
        
         int main() {
             string a;
             getline(cin, a);
             cout << a;
             return 0;
         }
         ```
        ```c++
        #include <iostream>
        #include <string>
        using namespace std;

        int main() {
            int x; cin >> x;
            string a;
            cin.ignore();
            getline(cin, a);
            cout << x << '\n' << a;
            return 0;
        }
        ```
