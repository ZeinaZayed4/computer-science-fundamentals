# Stack

## What is Stack?
- A type of array (fixed size).
- LIFO (Last In First Out).

## Stack Functions
1. push.
   - if the stack is empty, **top** = -1.
   - after pushing element, top++.
   - if the stack is full, top = (size of stack - 1).
2. pop.
   - if the stack is full, pop element, top--.
   - if the stack is empty, top = -1.
3. display.
   - displays elements from top to bottom.
4. peek.
   - returns the value the top points to.

## Stack Usage
- Reverse elements.
- Undo/Redo.

## Stack Implementation using Array
```c++
#include <iostream>
using namespace std;

#define size 5
int stack[size], top = -1;

void push(int value);
int pop();
int peek();
void display();

int main() {
    push(5);
    push(10);
    push(15);
    push(20);
    push(25);
    push(30); // stack overflow
    display(); // 25 20 15 10 5

    cout << pop() << '\n'; // 25
    display(); // 20 15 10 5

    pop();
    pop();
    cout << peek() << '\n'; // 10

    pop();
    pop();
    cout << peek() << '\n'; // stack underflow

    return 0;
}

void push(int value) {
    if (top == size - 1) {
        cout << "stack overflow\n";
    } else {
        top++;
        stack[top] = value;
    }
}

int pop() {
    if (top == -1) {
        cout << "stack underflow\n";
    } else {
        return stack[top--];
    }
}

int peek() {
    if (top == -1) {
        cout << "stack underflow\n";
    } else {
        return stack[top];
    }
}

void display() {
    if (top == -1) {
        cout << "stack underflow\n";
    } else {
        for (int i = top; i >= 0; --i) {
            cout << stack[i] << ' ';
        }
        cout << '\n';
    }
}
```

## Stack Implementation using Linked List
```c++
#include <iostream>
using namespace std;

struct node {
    int data;
    node* next;
};

node* top = nullptr;

void push(int value);
int pop();
void display();
int peek();

int main() {
    push(5);
    push(10);
    push(15);
    display();

    pop();
    display();

    cout << "top = " << peek();

    return 0;
}

void push(int value) {
    node* new_node = new node;
    new_node->data = value;
    new_node->next = top;
    top = new_node;
}

int pop() {
    if (top == nullptr) {
        cout << "stack underflow\n";
        return -1;
    } else {
        node* first_node = top;
        top = first_node->next;
        int value = first_node->data;
        delete(first_node);
        return value;
    }
}

void display() {
    if (top == nullptr) {
        cout << "stack underflow\n";
    } else {
        node* current = top;
        while (current != nullptr) {
            cout << current->data << ' ';
            current = current->next;
        }
    }
    cout << '\n';
}

int peek() {
    if (top == nullptr) {
        cout << "stack underflow\n";
        return -1;
    } else {
        return top->data;
    }
}
```
