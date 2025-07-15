# Chapter 5 - The Relational Data Model and Relational Database Constraints

## Relational Model Concepts
- The relational model of data is based on the concept of **relation**:
  - The strength of the relational approach to data management comes from the formal foundation provided by the theory of relations.
- A relation is a mathematical concept based on the ideas of sets.

### Informal Definitions
- Informally, a **relation** looks like a **table** of values.
- A relation typically contains a **set of rows**.
- The data elements in each **row** represent certain facts that correspond to a real-world **entity** or **relationship**.
  - In the formal model, rows are called **tuples**.
- Each **column** has a column header that gives an indication of the meaning of the data items in that column.
  - In the formal model, the column header is called an **attribute name** (or just **attribute**).
- Key of a relation:
  - Each row has a value of a data item (or set of items) that uniquely identifies that row in the table
    - called the _key_.
  - In the STUDENT table, SSN is the key.
  - Sometimes row-ids or sequential numbers are assigned as keys to identify the rows in a table.
    - called _artificial key_ or _surrogate key_.

### Formal Definitions - Schema
- The schema (or description) of a relation:
  - donated by R(A1, A2, ...An).
  - R is the name of the relation.
  - the attributes of the relation are A1, A2, ...An.
- Example:
  - CUSTOMER (customer_id, customer_name, address, phone)
    - CUSTOMER is the relation name.
    - defined over the four attributes: customer_id, customer_name, address, phone.
- Each attribute has a **domain** or a set of valid values.
  - example: the domain of customer_id is 6-digit numbers.

### Formal Definitions - Tuple
- A tuple is an ordered set of values (enclosed in '<...>').
- Each value is derived from an appropriate _domain_.
- A row in the CUSTOMER relation is a 4-tuple and would consist of four values, for example:
  - <632895, "John Smith", "101 Main St.Atlanta, GA 30332", "(404) 894-2000">
  - this is called a 4-tuple as it has four values.
  - a tuple (row) in the CUSTOMER relation.
- A relation is a set of such tuples (rows).

### Formal Definitions - Domain
- A domain has a logical definition:
  - Example: "USA_phone_numbers" are the set of 10-digit phone numbers valid in the US.
- A domain also has a data-type or a format defined for it.
  - The USA_phone_numbers may have a format (ddd)ddd-dddd where each d is a decimal digit.
  - Dates have various formats such as year, month, date formatted as yyyy-mm-dd, or as dd mm,yyyy etc.
- The attribute name designates the role played by a domain in a relation:
  - Used to interpret the meaning of the date elements corresponding to that attribute.
  - Example: The domain Date may be used to define two attributes named "Invoice-date" and "Payment-date" with different meanings.

### Formal Definitions - State
- The relation state is a subset of the Cartesian product of the domains of its attributes
  - each domain contains the set of all possible values the attribute can take.
- Example: attribute customer-name is defined over the domain of character strings of maximum length 25
  - dom(customer-name) is varchar(25).
- The role these strings play in the CUSTOMER relation is that of the _name of a customer_.


### Formal Definitions - Summary
- Formally,
  - Given R(A1, A2, ........., An).
  - r(R) ⊆ dom (A1) X dom (A2) X ....X dom(An).
- R(A1, A2, ..., An) is the **schema** of the relation.
- R is the **name** of the relation.
- A1, A2, ..., An are the **attributes** of the relation.
- r(R): a specific **state** (or "value" or "population") of relation R – this is a set of _tuples_ (rows)
  - r(R) = {t1, t2, ..., tn} where each ti is an n-tuple.
  - ti = <v1, v2, ..., vn> where each vj element-of dom(Aj).

### Formal Definitions - Example
- Let R(A1, A2) be a relation schema:
  - Let dom(A1) = {0, 1}
  - Let dom(A2) = {a, b, c}
- Then: dom(A1) X dom(A2) is all possible combinations:
  - {<0, a>, <0, b>, <0, c>, <1, a>, <1, b>, <1, c>}
- The relation state r(R) ⊆ dom(A1) X dom(A2)
- For example, r(R) could be {<0, a>, <0, b>, <1, c>}
  - this is one possible state (or "population" or "extension") r of the relation R, defined over A1 and A2.
  - it has three 2-tuples: <0, a>, <0, b>, <1, c>

### Definition Summary
| Informal Terms             | Formal Terms          |
|----------------------------|-----------------------|
| Table                      | Relation              |
| Column Header              | Attribute             |
| All possible Column Values | Domain                |
| Row                        | Tuple                 |
| Table Definition           | Schema of a Relation  |
| Populated Table            | State of the Relation |

## Characteristics of Relations
- Ordering of tuples in a relation r(R):
  - The tuples are _not considered to be ordered_, even though they appear to be in the tabular form.
- Ordering of attributes in a relation schema R (and of values within each tuple):
  - We will consider the attributes in R(A1, A2, ..., An) and the values in t=<v1, v2, ..., vn> to be ordered.
    - (However, a more general alternative definition of relation does not require this ordering).
- Values in a tuple:
  - All values are considered atomic (indivisible).
  - Each value in a tuple must be from the domain of the attribute for that column.
    - If tuple t = <v1, v2, ..., vn> is a tuple (row) in the relation state r of R(A1, A2, ..., An).
    - Then each vi must be a value from dom(Ai).
  - A special **null** value is used to represent values that are unknown or inapplicable to certain tuples.
- Notation:
  - We refer to component values of a tuple t by:
    - t[Ai] or t.Ai
    - This is the value vi of attribute Ai for tuple t.
  - Similarly, t[Au, Av, ..., Aw] refers to the sub-tuple of t containing the values of attributes Au, Av, ..., Aw, respectively in t.

## Relational Integrity Constraints
- Constraints are conditions that must hold on all valid relation states.
- There are _three main types of constraints_ in the relational model: 
  - **Key** constraints.
  - **Entity integrity** constraints.
  - **Referential integrity** constraints.
- Another implicit constraint is the **domain** constraint
  - Every value in a tuple must be from the _domain of its attribute_ (or it could be **null**, if allowed for that attribute).

### Key Constraints
- **Superkey** of R:
  - Is a set of attributes SK of R with the following condition:
    - no two tuples in any valid relation state r(R) will have the same value for SK.
    - that is, for any distinct tuples t1 and t2 in r(R), t1[SK] != t2[SK].
    - this condition must hold in _any valid state_ r(R).
- **Key** of R:
  - A "minimal" superkey.
  - that is, a key is a superkey K such that removal of any attribute from K results in a set of attributes that is not a superkey (doesn't possess the superkey uniqueness property).
- Example:
  - CAR (state, reg#, serialNo, make, model, year).
  - The CAR has two keys:
    - key1 = {state, reg#}.
    - key2 = {serialNo}
  - Both are also superkeys of CAR.
  - {serialNo, make} is a superkey but _not_ a key.
- In general:
  - Any _key_ is a _superkey_ (but not vice verse).
  - Any set of attributes that _includes a key_ is a _superkey_.
  - A _minimal_ superkey is also a key.
- If a relation has several **candidate keys**, one is chosen arbitrarily to be the **primary key**.
  - The primary key attributes are underlined.
- Example: Consider the CAR relation schema:
  - CAR (state, reg#, serialNo, make, model, year)
  - We chose serialNo as the primary key.
- The primary key value is used to _uniquely identify_ each tuple in a relation
  - Provides the tuple identity.
- Also used to _reference_ the tuple from another tuple.
  - General rule: Choose as a primary key the smallest of the candidate keys (in terms of size).
  - Not always applicable – choice is sometimes subjective.

### Entity Integrity
- The _primary key attributes_ PK of each relation schema R in S can't have null values in any tuple of r(R).
  - This is because primary key values are used to _identify_ the individual tuples.
  - t[PK] != null for any tuple t in r(R).
  - If PK has several attributes, null is not allowed in any of these attributes.
- Note:
  - Other attributes of R may be constrained to disallow null values, even though they aren't members of the primary key.

### Referential Integrity
- A constraint involving **two** relations:
  - The previous constraints involve a single relation.
- Used to specify a **relationship** among tuples in two relations:
  - The **referencing relation** and the **referenced relation**.
- Tuples in the **referencing relation** R1 have attributes FK (called **foreign key** attributes) thar reference the primary key attributes PK of the **referenced relation** R2.
  - A tuple t1 in R1 is said to **reference** a tuple t2 in R2 if t1[FK] = t2[PK].
- A referential integrity constraint can be displayed in a relational database schema as a directed arc from R1.FK to R2.
- Statement of the constraint
  - The value in the foreign key column (or columns) FK of the referencing relation R1 can be either:
    1. A value of an existing primary key value of a corresponding primary key PK in the referenced relation R2, or
    2. a null.
- In case (2), the FK in R1 shouldn't be part of its own primary key.

### Other Types of Constraints
- Semantic Integrity Constraints:
    - based on application semantics and can't be expressed by the model per se.
    - Example: "the max no. of hours per employee for all projects he or she works on is 56 hrs per week."
- A **constraint specification** language may have to be used to express these.
- SQL-99 allows triggers and ASSERTIONS to express for some of these.

## Relational Database Schema
- A set S of relation schemas that belong to the same database.
- S is the name of the whole **database schema**.
- S = {R1, R2, ..., Rn}
- R1, R2, ..., Rn are the names of the individual **relation schemas** within the database S.

## Displaying a Relational Database Schema and its Constraints
- Each relation schema can be displayed as a row of attribute names.
- The name of the relation is written above the attribute names.
- The primary key attribute (or attributes) will be underlined.
- A foreign key (referential integrity) constraints are displayed as a directed arc (arrow) from the foreign key attributes to the referenced table.
  - Can also point the primary key of the referenced relation for clarity.

## Populated Database State
- Each _relation_ will have may tuples in its current relation state.
- The _relational database state_ is a union of all the individual relation states.
- Whenever the database is changed, a new state arises.
- Basic operations for changing the database:
  - INSERT a new tuple in a relation.
  - DELETE an existing tuple from a relation.
  - MODIFY an attribute of an existing tuple.

## UPDATE Operations on Relations
- INSERT a tuple.
- DELETE a tuple.
- MODIFY a tuple.
- Integrity constraints shouldn't be violated by the update operations.
- Several update operations may have to be grouped together.
- Updates may **propagate** to cause other updates automatically. This may be necessary to maintain integrity constraints.
- In case of integrity violation, several actions can be taken:
  - Cancel the operation that causes the violations (RESTRICT or REJECT option).
  - Perform the operation but inform the user of the violation.
  - Trigger additional updates so the violation is corrected (CASCADE option, SET NULL option).
  - Execute a user-specified error-correction routine.

## Possible Violations for each Operation
- INSERT may violate any of the constraints:
  - Domain constraint:
    - if one of the attribute values provided for the new tuple is not of the specified attribute domain.
  - Key constraint:
    - if the value of a key attribute in the new tuple already exists in another tuple in the relation.
  - Referential integrity:
    - if a foreign key value in the new tuple references a primary key value that doesn't exist in the referenced relation.
  - Entity integrity:
    - if the primary key value is null in the new tuple.
- DELETE may violate only referential integrity:
  - if the primary key value of the tuple being deleted is referenced from other tuples in the database
    - can be remedied by several actions: RESTRICT, CASCADE, SET NULL.
      - RESTRICT option: reject the deletion.
      - CASCADE option: propagate the new primary key value into the foreign keys of the referencing tuples.
      - SET NULL option: set the foreign keys of the referencing tuples to NULL.
  - One of the above options must be specified during database design for each foreign key constrain.
- UPDATE may violate domain constraint and NOT NULL constraint on an attribute being modified.
  - Any of the other constraints may also be violated, depending on the attribute being updated:
    - Updating the primary key (PK):
      - similar to DELETE followed by an INSERT.
      - need to specify similar options to DELETE.
    - Updating a foreign key (FK):
      - may violate referential integrity.
    - Updating an ordinary attribute (neither PK nor FK):
      - can only violate domain constraints.
