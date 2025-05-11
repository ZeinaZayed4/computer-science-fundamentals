#include <iostream>
using namespace std;

int main()
{

    // [1] => endl
    cout << "I am Zeina." << endl;
    cout << "I was born in Mansoura." << endl;
    cout << "I graduated from Mansoura university." << endl;

    cout << "-------------------------------" << endl;

    // [2] => \n
    cout << "I am Zeina.\n";
    cout << "I was born in Mansoura.\n";
    cout << "I graduated from Mansoura university.\n";

    cout << "-------------------------------" << endl;

    // More printings
    cout << "I am Zeina."
         << endl
         << "I was born in Mansoura."
         << endl
         << "I graduated from Mansoura university."
         << endl;

    cout << "-------------------------------" << endl;

    // More printings
    cout << "I am Zeina.\nI was born in Mansoura.\nI graduated from Mansoura university.\n";

    cout << "-------------------------------" << endl;

    // One line comment.

    /*
     * Multiple
     * line
     * comment.
     */

    // Numbers (int)
    cout << 4 << endl;
    cout << 4 << " is a number." << endl;
    cout << "4" << " is NOT a number." << endl;

    cout << "-------------------------------" << endl;

    // Numbers (double)
    cout << 4.8 << endl;
    cout << -2.4 << endl;

    cout << "-------------------------------" << endl;

    // Math on numbers
    cout << "2 + 4 = " << 2 + 4 << endl;
    cout << "7 / 2 = " << 7 / 2 << endl;                             // 3
    cout << "7.0 / 2.0 = " << 7.0 / 2.0 << endl;                     // 3.5
    cout << 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 << endl;      // 1000000000
    cout << 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 << endl; // 1410065408

    return 0;
}
