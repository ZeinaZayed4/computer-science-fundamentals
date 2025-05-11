# Data Types:

- We call 1234 a number. 
  - C++ calls it **integer**.
- What about 10.7? This is a number too, but with fraction part.
    - C++ calls it **double** (or float).
- What is 'X'? This is a letter.
  - C++ calls it **character**.
- What is "Car"? This is a word.
  - C++ calls it sequence of characters or **strings**.
- Some things are of two types only.
  - E.g. a person is single or married.
  - C++ calls them **boolean**.
    - Their values are true or false.
    - E.g. coin is head or tail. We can think head is true and tail is false.
  - True also corresponds to 1, and false to 0.
  - Light can be on or off. Computers "understand" on and off.
- Summary: integer, double, character, string, boolean.

# The need of names!

- Let say we want to build a program for hospital:
  - We need to refer to patients.
  - One of them is called "Mostafa". He is 55 years old. He has 2 children.
  - We also have doctors who have name, salary, address, etc.
- How can we represent this information?
  - We need to put them in memory when the program starts.
  - We need to have names to refer to them?
  - E.g. I want to know Mostafa's age?

# Computer memory like streets:

- Each home has street address (location).
  - Name and number.
  - 127 Tahrir street.
  - 127 = location.
  - Tahrir = name.
- There are people in the home
  - People have types
    - Male, female, child.

# Computer Memory (RAM)

- Think of it as boxes.
- Each box has:
  - Address location.
  - Type (e.g. integer or double).
  - Name: E.g. age, name or salary.
- We call it **variable**
  - A box in the memory.

# Let's define 2 variables: age and weight

- How to define a variable in memory?
- **int age = 55;**
  - int: type of this variable.
  - age: name of variable (identifier).
  - = please assign value.
  - 55: please put in memory this value! (literal).
- Notice we can print the weight.
- Same for weight variable:
  - double weight = 92.5;

# Declare, Assign, Get:

- We can also declare variable and later put value.
- We can use them for operations.

# Identifier (variable name):

- Identifier: Variable name
  - int sum = 10; => sum is identifier.
- Identifier consist of: letter, digits, _
  - iNumber, status1, status2, mostafa_saad, _valid
- Can't start with digit
  - 7Core [wrong].
- Case sensitive: sum != SUM.
- Shouldn't use reserved keyword
  - int **return** = 6;
  - Reserved words: int, float, double, return, void, break, false, bool, and more.

# Other important data types:

- Notice the 0/1 values for the bool
  - So it's eventually a number.
- Also char is a number.
- **Look at the code at the end**.

# Datatypes have _min and max_ values to store:

- int: -2147483648 to 2147483647.
- char: -127 to 127.
- bool: 0 to 1.
- If you tried lower value => underflow.
- If you tried higher value => overflow.
  - int val = 2147483647 + 1;
    - We are adding 1 more than the max value!
    - Compiler msg: warning: integer overflow in expression.

# Reading variables:

- In previous times, we learned how to print:
  - We used cout <<.
  - Remember: C = Console - Out = Output.
- To read we use cin >>:
  - C = Console - in = Input.
- Steps:
  - Define a variable.
  - Read it:
    - Wait user enter input from the console.

# Reading multiple numbers:

- Remember we print multiple things.
- We can also read multiple things using a single command.

# Assignment operator +:

- = helps us to assign values.
- Value on the right side is put on left side.
  - Memory box updated.
- Keep in mind the last updated value in the memory for each variable.

# Code:
- [Code](04%20data%20types%20and%20variables.cpp).

# Homework:

- [Homework](04%20data%20types%20and%20variables-homework.cpp).
