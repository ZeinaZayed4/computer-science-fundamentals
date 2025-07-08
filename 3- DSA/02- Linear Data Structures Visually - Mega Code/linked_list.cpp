#include <iostream>
using namespace std;

struct node {
    int data;
    node* next;
};

node* head = nullptr;

void insertNode(int value);
void display();
void deleteNode(int value);
void insertBeginning(int value);
void deleteBeginning();
void deleteEnd();

int main() {
    insertNode(5);
    insertNode(10);
    insertNode(15);
    insertNode(20);
    display();

    deleteNode(15);
    display();

    insertBeginning(0);
    display();

    deleteBeginning();
    display();

    deleteEnd();
    display();

    return 0;
}

void insertNode(int value) {
    node* new_node = new node;
    new_node->data = value;

    if (head == nullptr) {
        head = new_node;
        new_node->next = nullptr;
    } else {
        node* last = head;
        while (last->next != nullptr) {
            last = last->next;
        }
        last->next = new_node;
        new_node->next = nullptr;
    }
}

void display() {
    if (head == nullptr) {
        cout << "The linked list is empty.\n";
    } else {
        node* current_node = head;
        while (current_node != nullptr) {
            cout << current_node->data << '\t';
            current_node = current_node->next;
        }
    }
    cout << '\n';
}

void deleteNode(int value) {
    node* current = head, *previous = head;

    if (current->data == value) {
        current = current->next;
        free(current);
        return;
    }

    while (current->data != value) {
        previous = current;
        current = current->next;
    }
    previous->next = current->next;
    free(current);
}

void insertBeginning(int value) {
    node* new_node = new node;
    new_node->data = value;

    new_node->next = head;
    head = new_node;
}

void deleteBeginning() {
    if (head == nullptr) {
        cout << "The linked list is empty.\n";
    } else {
        node* first_node = head;
        head = first_node->next;
        delete(first_node);
    }
}

void deleteEnd() {
    if (head == nullptr) {
        cout << "The linked list is empty.\n";
    } else if (head->next == nullptr) {
        delete(head);
        head = nullptr;
    } else {
        node* ptr = head;
        while (ptr->next->next != nullptr) {
            ptr = ptr->next;
        }
        delete(ptr->next);
        ptr->next = nullptr;
    }
}
