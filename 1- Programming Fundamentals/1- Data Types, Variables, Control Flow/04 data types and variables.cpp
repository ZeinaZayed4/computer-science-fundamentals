#include <iostream>
using namespace std;

int main()
{
    // Define 2 variables: age and weight
    int age = 22;
    cout << age << endl;

    double weight = 60;
    cout << "My weight is " << weight << endl;

    // ** Declare, Assign, Get **

    // 1- Declare variable in memory, garbage vlaue
    int number1;
    int number2;

    // 2- Assign values (in memory)
    number1 = 30;
    number2 = 10;

    // 3- Get values
    cout << number1 + number2 << endl;
    cout << number1 - number2 << endl;

    // 4- Reassign value
    number1 = 50;
    cout << "2n + 1 = " << number1 * 2 + 1 << endl;

    // Other important data types
    char group = 'd';

    bool is_female = true;
    bool like_handball = false;

    string name = "Zeina";

    cout << "I am " << age << " years old\n";
    cout << "My weight is " << weight << endl;

    cout << "My name is " << name << " and my group is " << group << endl
    << is_female << " " << like_handball << endl;

    // Reading an integer
    int num;

    cout << "Enter your lucky number: " << endl;

    cin >> num;

    cout << 2 * num + 1 << endl;

    // Reading multiple numbers
    int a, b;

    cout << "Enter 2 numbers\n";

    cin >> a >> b;

    cout << a * b << " " << a + b << endl;

    // Reading different data types
    int your_age;
    cout << "Enter age\n";
    cin >> your_age;

    double your_weight;
    cout << "Enter your weight\n";
    cin >> your_weight;

    char your_group;
    cout << "Enter your group\n";
    cin >> your_group;

    string your_name;
    cout << "Enter your name\n";
    cin >> your_name;

    cout << "I am " << your_name << " belongs to group " << your_group << endl;
    cout << "My weight is " << your_weight << " and age is " << age << endl;

    // Assignment operator +
    int n1 = 20;
    int n2 = n1 + 5;

    cout << "n2 = " << n2 << endl; // n2 = 25

    n1 = n1 + 1;
    cout << "n1 = " << n1 << endl; // n1 = 21

    n2 += 1; // same as n2 = n2 + 1;
    cout << "n2 = " << n2 << endl; // n2 = 26

    n2++; // same as n2 = n2 + 1;
    cout << "n2 = " << n2 << endl; // n2 = 27

    --n2; // same as n2 = n2 - 1;
    cout << "n2 = " << n2 << endl; // n2 = 26

    n1 *= 2; // same as n1 = n1 * 2;
    cout << "n1 = " << n1 << endl; // n1 = 42

    cout << n1 + n2 << endl; // 68

    n2 = n1 - 2;
    cout << "n2 = " << n2 << endl; // n2 = 40

    n2 = n1 - (-2);
    cout << "n2 = " << n2 << endl; // n2 = 44

    return 0;
}
