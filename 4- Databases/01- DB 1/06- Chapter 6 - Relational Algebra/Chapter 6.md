# Relational Algebra and Calculus

## Relational Algebra Overview
- is the basic set of operations for the relational model.
- these operations enable a user to specify basic retrieval requests (or queries).
- the result of an operation is a _new relation_, which may have been formed from one or more input relations.
- The algebra operations thus produce new relations.
  - These can be further manipulated using operations of the same algebra.
- A sequence of relational algebra operations forms a relational algebra expression.
  - The result of a relational algebra expression is also a relation that represents the result of a retrieval query.
- Relational algebra consists of several groups of operations:
  - **Unary Relational Operations**:
    - SELECT (symbol: σ (sigma)).
    - PROJECT (symbol: π (pi)).
    - RENAME (symbol: ρ (rho)).
  - **Relational Algebra Operations From Set Theory**:
    - UNION (∪), INTERSECTION (∩), DIFFERENCE (or MINUS, -).
    - CARTESIAN PRODUCT (x).
  - **Binary Relational Operations**:
    - JOIN (several variations of JOIN exist).
    - DIVISION.
  - **Additional Relational Operations**:
    - OUTER JOINS, OUTER UNION.
    - AGGREGATE FUNCTIONS (these compute summaries of information):
      - For example, SUM, COUNT, AVG, MIN, MAX.

### Unary Relational Operations: SELECT
- The SELECT operation (donated by σ (sigma)) is used to select a _subset_ of the tuples from a relation based on a selection condition.
  - The selection condition acts as a filter.
  - Keeps only those tuples that satisfy the qualifying condition.
  - Tuples satisfying the condition are _selected_ whereas the other tuples are discarded (filtered out).
- Examples:
  - SELECT the EMPLOYEE tuples whose department number is 4:
    - σ<sub>DNO = 4</sub> (EMPLOYEE)
  - SELECT the EMPLOYEE tuples whose salary is greater than $30,000:
    - σ<sub>SALARY > 30,000</sub> (EMPLOYEE)
  - SELECT the EMPLOYEE tuples whose department number is 4 AND their salary is greater than $30,000:
    - σ<sub>DNO = 4 AND SALARY > 30,000</sub> (EMPLOYEE)

### Unary Relational Operations: PROJECT
- The PROJECT operation is donated by π (pi).
- This operation keeps certain _columns_ (attributes) from a relation and discards the other columns.
  - The PROJECT creates a vertical partitioning.
    - The list of specified columns (attributes) is kept in each tuple.
    - The other attributes in each tuple are discarded.
- Example:
  - To list each employee's first and last name and salary, the following is used:
    - π<sub>FNAME, LNAME, SALARY</sub> (EMPLOYEE)
  - For EMPLOYEEs working in department number: 5, list the FNAME, SSN, SALARY:
    - R1: σ<sub>DNO = 5</sub> (EMPLOYEE)
    - π<sub>FNAME, SSN, SALARY</sub> (R1)
- The PROJECT removes duplications.

### Relational Algebra Operations From Set Theory: UNION
- Binary operation, denoted by ∪.
- The result of R ∪ S is a relation that includes all tuples that are either in R or in S or in both R and S.
- Duplicate tuples are eliminated.
- The two operand relations R and S must be "type compatible" (or UNION compatible).
  - R and S must have the same number of attributes (columns).
  - Each pair of corresponding attributes must be type compatible (have the same of compatible domains).

### Relational Algebra Operations From Set Theory: INTERSECTION
- INTERSECTION is donated by ∩.
- The result of the operation R ∩ S is a relation that includes all tuples that are in both R and S.
  - The attribute names in the result will be the same as the attribute names in R.
- The two operand relations R and S must be "type compatible."

### Relational Algebra Operations From Set Theory: DIFFERENCE
- SET DIFFERENCE (also called MINUS or EXCEPT) is donated by -.
- The result of R - S is a relation that includes all tuples that are in R but not in S.
  - The attribute names in the result will be the same as the attribute names in R.
- The two operand relations R and S must be "type compatible."

### Relational Algebra Operations From Set Theory: CARTESIAN PRODUCT
- CARTESIAN (or CROSS) PRODUCT Operation:
  - This operation is used to combine tuples from two relations in a combinatorial fashion.
  - Donated by R(A1, A2, ..., An) x S(B1, B2, ..., Bm).
  - The result is a relation Q with degree n + m attributes.
    - Q(A1, A2, ..., An, B1, B2, ..., Bm) in that order.
  - The resulting relation state has one tuple for each combination of tuples—one from R and one from S.
  - Hence, if R has n<sub>R</sub> tuples (donated as |R| = n<sub>R</sub>), and S has n<sub>S</sub> tuples, then R x S will have n<sub>R</sub> * n<sub>S</sub> tuples.
  - The two operands do NOT have to be "type compatible."

### Binary Relational Operations: JOIN
- JOIN operation is donated by ⋈.
- The sequence of CARTESIAN PRODUCT followed by SELECT is used quite commonly to identify and select related tuples from two relations.
- A special operation, called JOIN, combines this sequence into a single operation.
- This operation is very important for any relational database with more than a single relation, because it allows us to _combine related tuples_ from various relations.
- The general form of a JOIN operation on two relations R(A1, A2, ..., An) and S(B1, B2, ..., Bm) is:
  - R ⋈<sub>join condition</sub> S
- Where R and S can be any relations that result from general _relational algebra expressions_.
- Example: Suppose that we want to retrieve the name of the manager of each department.
  - To get the manager's name, we need to combine each DEPARTMENT tuple with the EMPLOYEE tuple whose SSN value matches the MGR_SSN value in the department tuple.
  - We do this by using the join ⋈ operation.
  - DEPT_MGR <- DEPARTMENT ⋈ <sub>MGR_SSN = SSN</sub> EMPLOYEE

### Binary Relational Operations: NATURAL JOIN
- Another version of JOIN called NATURAL JOIN—donated by *- was created to get rid of the second (superfluous) attribute in an EQUIJOIN condition.
  - because one of each pair of attributes with identical values is superfluous.
- The standard definition of natural join requires that the two join attributes, or each pair of corresponding join attributes, _have the same name_ in both relations.
- If this is not the case, a renaming operation is applied first.
- Example: To apply a natural join on the DNUMBER attributes of DEPARTMENT and DEPT_LOCATIONS, it's sufficient to write:
  - DEPT_LOCS <- DEPARTMENT * DEPT_LOCATIONS
  - Only attribute with the same name is DNUMBER.
  - An implicit join condition is created based on this attribute:
    - DEPARTMENT.DNUMBER = DEPT_LOCATIONS.DNUMBER
- Another example: Q ← R(A, B, C, D) * S(C, D, E)
  - The implicit join condition includes each pair of attributes with the same name, "AND" ed together:
    - R.C = S.C AND R.D = S.D
  - Result:
    - Q(A, B, C, D, E).

### Binary Relational Operations: DIVISION
- The DIVISION operation is applied to two relations.
- R(Z) ÷ S(X), where X subset Z. Let Y = Z - X (and hence Z = X ∪ Y); that is, let Y be the set of attributes of R that are not attributes of S.
- The result of DIVISION is a relation T(Y) that includes a tuple (t) if tuples t<sub>R</sub> appear in R with t<sub>R</sub>[Y] = t, and with
  - t<sub>R</sub>[X] = t<sub>S</sub> for every t<sub>S</sub> in S.
- For a tuple (t) to appear in the result T of the DIVISION
- Examples:
  - Find a list of employees who worked on all projects.
    1. π (project Pno) -> Pnos.
    2. π (works_on) Essn, Pno -> SSN_PNOS.
    3. SSN_PNOS ÷ Pnos.
  - Retrieve the names of employees who work in all the projects that 'John Smith' works on.
    1. π<sub>FNAME='John', LNAME='Smith'</sub> (EMPLOYEE) -> SMITH.
    2. SMITH ⋈<sub>SSN=ESSN</sub> WORKS_ON -> SMITH_PROJECTS.
    3. π<sub>Pno</sub> (SMITH_PROJECTS) -> SMITH_PNOS.
    4. π<sub>Essn, Pno</sub> (WORKS_ON) -> EMP_PNOS.
    5. EMP_PNOS ÷ SMITH_PNOS.

### Additional Relational Operations: OUTER JOIN
- In NATURAL JOIN and EQUIJOIN, tuples without a matching (or related) tuple are eliminated from the join result.
  - Tuples with null in the join attributes are also eliminated.
  - This amounts to loss of information.
- A set of operations, called OUTER JOIN, can be used when we want to keep all the tuples in R, or all those in S, or all those in both relations in the result of the join, regardless of whether they have matching tuples in the other relation.
- Types:
  1. LEFT OUTER JOIN.
     - keeps every tuple in the first or left relation R in R ⟕ S;
     - if no matching tuple is found in S, then the attributes of S in the join result are filled or "padded" with null values.
  2. RIGHT OUTER JOIN.
     - keeps every tuple in the second or right relation S in the result of R ⟖ S.
  3. FULL OUTER JOIN.
     - donated by ⟗.
     - keeps all tuples in both the left and the right relations when no matching tuples are found, then padding them with null values as needed.

### Additional Relational Operations: AGGREGATE FUNCTIONS and GROUPING
- A type of request that can't be expressed in the basic relational algebra is to specify mathematical aggregate functions on collections of values from the database.
- Examples of such functions include retrieving the average or total salary of all employees or the total number of employee tuples.
  - These functions are used in simple statistical queries that summarize information from the database tuples.
- Common functions applied to collections of numeric values include:
  - SUM, AVERAGE, MAXIMUM, MINIMUM.
- The COUNT function is used for counting the number of values.
- Use of the aggregate functional operation f.
  - f<sub>MAX salary</sub> (EMPLOYEE) retrieves the maximum salary value from the EMPLOYEE relation.
  - f<sub>MIN salary</sub> (EMPLOYEE) retrieves the minimum salary value from the EMPLOYEE relation.
  - f<sub>SUM salary</sub> (EMPLOYEE) retrieves the sum of the salary from the EMPLOYEE relation.
  - f<sub>COUNT SSN, AVERAGE salary</sub> (EMPLOYEE) computes the count (number) of employees and their average salary.
- The previous examples all summarized one or more attributes for a set of tuples:
  - Maximum salary or count (number of) ssn.
- GROUPING can be combined with AGGREGATE functions.
- Example: For each department, retrieve the DNO, COUNT SSN, and AVERAGE SALARY.
- A variation of aggregate operation f allows this:
  - Grouping attribute placed to the left of symbol.
  - Aggregate functions to the right of symbol.
  - <sub>DNO</sub> f <sub>COUNT SSN, AVERAGE SALARY</sub> (EMPLOYEE).
