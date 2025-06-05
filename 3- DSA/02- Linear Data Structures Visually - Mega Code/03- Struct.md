# Structure

- A user-defined data type.
- Code:
  ```c++
    #include <iostream>
    using namespace std;

    struct book {
    string name;
    string author;
    int pages;
    double price;
    };

    int main() {
        book b1;

        // book b1 = {
        //     "Book 1",
        //     "Author 1",
        //     300,
        //     99.99
        // };

        cout << "Enter book details {name, author, pages, price}: ";
        cin >> b1.name >> b1.author >> b1.pages >> b1.price;

        cout << "Book name: " << b1.name << '\n';
        cout << "Book author: " << b1.author << '\n';
        cout << "Book pages: " << b1.pages << '\n';
        cout << "Book price: " << b1.price << '\n';

        return 0;
    }
  ```
