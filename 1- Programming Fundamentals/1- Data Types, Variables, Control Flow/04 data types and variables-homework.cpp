#include <iostream>
using namespace std;

int main()
{
    // [1] Math operations
    int x, y;

    cout << "Enter 2 numbers:\n";
    cin >> x >> y;

    cout << x << " + " << y << " = " << x + y << endl;
    cout << x << " - " << y << " = " << x - y << endl;
    cout << x << " / " << y << " = " << x / y << endl;
    cout << x << " * " << y << " = " << x * y << endl;

    cout << "------------------------\n";

    // [2] Students grades
    string s1_name, s2_name;
    int s1_id, s2_id;
    double s1_grade, s2_grade;

    cout << "What is student 1 name?\n";
    cin >> s1_name;
    cout << "His id?\n";
    cin >> s1_id;
    cout << "His math exam grade?\n";
    cin >> s1_grade;

    cout << "What is student 2 name?\n";
    cin >> s2_name;
    cout << "His id?\n";
    cin >> s2_id;
    cout << "His math exam grade?\n";
    cin >> s2_grade;

    cout << "Students grades in math:\n";
    cout << s1_name << " (with id " << s1_id << ") got grade: " << s1_grade << endl;
    cout << s2_name << " (with id " << s2_id << ") got grade: " << s2_grade << endl;
    cout << "Average grade is " << (s1_grade + s2_grade) / 2 << endl;

    cout << "------------------------\n";

    // [3] Even and Odd sum
    int n1, n2, n3, n4, n5, n6, n7, n8;

    cout << "Enter 8 numbers:\n";

    cin >> n1 >> n2 >> n3 >> n4 >> n5 >> n6 >> n7 >> n8;

    int even_sum = n2 + n4 + n6 + n8;
    int odd_sum = n1 + n3 + n5 + n7;

    cout << n2 << " + " <<  n4 << " + " << n6 << " + " << n8 << " = " << even_sum << endl;
    cout << n1 << " + " <<  n3 << " + " << n5 << " + " << n7 << " = " << odd_sum << endl;

    cout << "------------------------\n";

    // [4] Print Program output
    int num1, num2, num3;

    num1 = 0, num2 = 1, num3 = num1 + num2, cout << num3 << endl; // num3 = 1
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 1, num2 = 1, num3 = 2
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 1, num2 = 2, num3 = 3
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 2, num2 = 3, num3 = 5
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 3, num2 = 5, num3 = 8
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 5, num2 = 8, num3 = 13
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 8, num2 = 13, num3 = 21
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 13, num2 = 21, num3 = 34
    num1 = num2, num2 = num3, num3 = num1 + num2, cout << num3 << endl; // num1 = 21, num2 = 34, num3 = 55

    cout << "------------------------\n";

    // [5] Print Program Output
    int num = 0;

    ++num; // num = 1
    num *= 10; // num = 10
    num += 2; // num = 12
    num = num * 10; // num = 120
    num += 3; // num = 123
    num = num * 10 + 4; // num = 1234
    num = 5 + num * 10; // num = 12345
    num = (num * 10 + 6) * 10 + 7; // num = 1234567
    num = 5 * num * 2 * 1 + 5 + 2 + 1; // num = 12345678

    cout << num << endl;

    cout << "------------------------\n";

    // [6] Swapping 2 numbers!
    int a, b, swap;

    cout << "Enter 2 numbers:\n";

    cin >> a >> b;

    cout << "a = " << a << ", b = " << b << endl;

    swap = a;
    a = b;
    b = swap;

    cout << "a = " << a << ", b = " << b << endl;

    cout << "------------------------\n";

    // [7] Swapping 3 numbers!
    int c, d, e, swap1, swap2;

    cout << "Enter 3 numbers:\n";

    cin >> c >> d >> e;

    cout << "c = " << c << ", d = " << d << ", e = " << e << endl;

    swap1 = c;
    swap2 = d;
    d = e;
    e = swap1;
    c = swap2;

    cout << "c = " << c << ", d = " << d << ", e = " << e << endl;

    cout << "------------------------\n";

    // [8] Print Me
    int n, m;

    cin >> n >> m;

    int equ_is_1 = n * n;
    int equ_is_neg_1 = 2 * n + 1;

    int is_1 = (m + 1) / 2;
    int is_neg_1 = 1 - is_1;

    cout << is_1 * equ_is_1 + is_neg_1 * equ_is_neg_1 << endl;

    cout << "------------------------\n";

    // [9] Sum numbers from 1 to N
    int N;

    cin >> N;

    cout << N * (N + 1) / 2 << endl;

    return 0;
}
