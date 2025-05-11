# Why Learn Programming?

- Improve problem-solving skills.
- Building later real-life applications.
- Better understanding for technologies.
- It has a great learning potential (highest salaries) / strong demands.
- Much fun for a lot of us.
- Participating in programming competitions (e.g. IOI):
  - Build a lot of connections / travel.
- You may work in giant companies such as Google and Microsoft.

# Math? Who could learn? How hard?

- Programming doesn't need math background/skills, although useful for mind.
- ANYONE can learn programmings:
  - Kids now abroad learn programming.
- Learning programming is like learning a new different human language:
  - Say you are learning Chinese.
  - It is so different from Arabic/English/German.
  - The beginning is a bit annoying. After sometime, just works well.
  - Don't run away! Don't tell yourself not for me! I am stupid! And such negative things.

# Simple Calculator

- Program is a set of instructions:
  - Read number 1.
  - Read operations.
  - Read number 2.
  - Execute operation.
  - E.g. 3 + 5 = 8.
- Processing:
  - **CPU** process operations.
- Programming language:
  - A way to talk to the computer (source code) - such as C++, Java, C#, Python.

# Writing a program

- A compute program is:
  - Sequence of commands given to the computer.
    - Read number.
    - Write 2 * number + 1.
  - They must writen in specific format (syntax rules).
  - The **rules** depend on the programming language.
- Programming language:
  - Set of rules to describe the syntax.
- Language compiler:
  - Takes the code we write and convert to executable:
    - The CPU knows how to run the executable.
  - Compiler gives **errors** if rules are not followed.

# C++ Program Life Cycle

1) Write the code (computer program).
2) Compile it (lots of _internal_ steps).
   3) Generates a program (e.g. code.exe file on windows).
4) Run the executable.

# Your first program

- Write a program to **print on the screen** the following statement:
  - My First Program. Helllllo.
  - [code](01%20intro.cpp).

# Back to the code

- 'cout << "My First Program. Helllllo.";', it says:
  - cout <<:
    - This is a command to print (cout == Console output).
  - "My First Program. Helllllo.":
    - This is what to print.
    - Notice the double quotes "".
  - ;
    - This is an end of line, like full stop for human.
- Line 1: iostream header. Io for input/output.
  - It says how to read and write.
  - It defines **cout**.
- Other lines:
  - Just write them as they are for now.

# Back to the code: **Optional**

- #include
  - We have several things ready for you to use.
  - Let's say you want to calculate √25, which is 5.
  - #include<cmath> => sqrt(25).
  - Ok, I want to read and write from the disk?
  - #include<iostream> handles that for you (e.g. cout).
- Using namespace std;
  - It contains all standard names used in C++.
  - More later in some advanced C++.
- int main()
  - This is called the main function.
  - A C++ program must have it.
  - return 0;
    - Function is done successfully.
    - return means: finish and make the caller resumes.
  - ()
    - Called brackets.
    - You can put numbers: e.g. sqrt(25).
- {}
  - We write code body between them.
  - More later.

# IDE: Integrated Development Environment

- We could write the code in a **notepad** file
  - then go to compiler to compile and generate exe to run.
- What about something gathers all in simple way?
- IDE = tools integrate staff for you.
- Many ones: CodeBlocks, Eclipse
  - CodeBlocks is an easier start.
  - Eclipse is very popular, but maybe confusing to install.
  - I (Zeina) use **CLion**.
