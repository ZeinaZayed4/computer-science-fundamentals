# Chapter 1 - Database and Database Users

## 1.1 Introduction

### - A database is 
  - a collection of _related data_.
  - Data mean:
    - _Known facts_ that can be recorded and that have implicit meaning.
    - Ex:
      - Names.
      - Telephone numbers.
      - Addresses.

### - A database has the following implicit properties:
  1. represents some aspects of the real world.
     - sometimes called _miniworld_ or the _universe of discourse (UoD)_.
     - changes to the miniworld are reflected in the database.
  2. is a logically coherent collection of data with some inherent meaning.
     - a random assortment of daa can't correctly be referred to as a database.
  3. is designed, built, and populated with data for a specific purpose.

### - Types of databases:
  - _Traditional database applications_:
    - Store textual or numeric information.
  - _Multimedia databases_:
    - Store images, audio clips, and streams digitally.
  - _Geographic information systems (GIS)_:
    - Store and analyze maps, weather data, and satellite images.
  - _Data warehouse and online analytical processing (OLAP)_:
    - Extract and analyze useful business information from very large databases.
    - Support decision-making.

### - Database Management System (DBMS):
  - is a collection of _programs_ that enables users to create and maintain a database.
  - is a _general-purpose software system_ that facilitates the processes of defining, constructing, manipulating, and sharing databases among various users and applications.
    - **Defining a database**:
      - involves specifying the _data types, structures, and constraints_ of the data to be stored in the database.
      - the database definition or descriptive information is also stored by **DBMS** in the form os a database catalog or dictionary, it is called **meta-data**.
    - **Constructing the database**:
      - is the process of storing the data on some storage medium that is controlled by the DBMS.
    - **Manipulating a database**:
      - includes functions such as querying the database to retrieve specific data, updating the database to reflect changes in the miniworld, and generating reports from the data.
    - **Sharing a database**:
      - allows multiple users and programs to access the database simultaneously.

### - An application program:
  - accesses the database by sending queries or requests for data to the DBMS.
    - The term **query**, originally meaning a question or an inquiry, is sometimes loosely used for all types of
      interactions with databases, including modifying the data.

### - Transaction:
  - may cause some data to be read and some data to be written into the database.

- Other important functions provided by the DBMS include _protecting_ the database and _maintaining_ it over a long period of time.
  - **Protection** includes 
    - _system protection_ against hardware or software malfunction (or crashes), and 
    - _security protection_ against unauthorized or malicious access.

---

## 1.2 An example:
  - UNIVERSITY database:
    - information concerning students, courses, and grades in a university environment.
    - Data records:
      - STUDENT.
      - COURSE.
      - SECTION.
      - GRADE_REPORT.
      - PREREQUISITE.
    1. Specific structure of records of each file by specifying **data type** for each **data element**:
      - String for alphabetic characters,
      - Integer,
      - etc..
    2. Construct UNIVERSITY database:
      - Store data to represent each student, course, section, grade, report, and prerequisite as a record in appropriate file.
    3. Relationships among the records.
    4. Manipulation involves querying and updating.
    - Examples of queries:
      - Retrieve the transcript.
      - List the names of students who took the section of "Database" course offered in fall 2008 and their grades in that section.
      - List the prerequisites of the "Database" course.
    - Examples of updates:
      - Change the class of "Smith" to sophomore.
      - Create a new section for the "Database" course for this semester.
      - Enter a grade of "A" for "Smith" in "Database" section of last semester.
    - [Database schema](1.png).

- [A simplified database system environment](2.png).


