# Compiler Error: Missing semicolon

# << Not:

- <<<
- <<<<
- < <
- ">>"

# Compiler Error: Missing double quote char

# Compiler Error: Missing the braces { }

# Compiler Error: Missing #include <iostream>

# Compiler Error: Where the main function?

- C++ is character sensitive.
- It must be **main** NOT:
  - MAIN.
  - Or Main.

# Compiler Error: Never print outside:

- You must print (and many other operations) _inside_ a function (main here).
- Later, a few things allowed outside.

# Compiler Warning: Where is return?

- Nothing stops the compiler to build the exe.
- However, better to solve the warnings.

# Compiler Warning: Maximum for int is 2147483647:

- **Overflow** warning.
- Maximum value for integer is 2147483647.
- More => Fails.

# Run Time Error:

- Compiler thinks it is ok:
  - No errors.
  - No warnings.
- Let's run:
  - Divide by zero!
  - Program crashes in the middle.
