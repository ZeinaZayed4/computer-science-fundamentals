# Queue

- FIFO (First In First Out).
  - Elements are added at one end(rear) and removed from the other end(front).

## Queue Functions
- Enqueue.
- Dequeue.
- Front/Peek.
- IsEmpty.
- Size.

## Queue Types
1. **Normal/Simple Queue**:
   - The basic queue implementation where elements are added at the rear and removed from the front.
   - Once queued, the space can't be reused, which can lead to **memory wastage**.
      ```c++
      #include <iostream>
      using namespace std;
      
      #define SIZE 5
      
      int queue[SIZE];
      int front = -1, rear = -1;
      
      void enqueue(int value);
      void dequeue();
      int peek();
      void display();
      
      int main() {
          enqueue(5);
          enqueue(10);
          enqueue(15);
          display(); // 5 10 15
      
          dequeue();
          display(); // 10 15
      
          cout << "Peek = " << peek() << '\n'; // 10
      
          return 0;
      }
      
      void enqueue(int value) {
          if (rear != SIZE - 1) {
              if (front == -1 && rear == -1) {
                  front++;
                  queue[++rear] = value;
              } else {
                  queue[++rear] = value;
              }
          } else {
              cout << "Queue is full.\n";
          }
      }
      
      void dequeue() {
          if (front != -1 && rear != -1 && front <= rear) {
              front++;
          } else {
              cout << "Queue is empty.\n";
          }
      }
      
      int peek() {
          if (front != -1 && rear != -1 && front <= rear) {
              return queue[front];
          } else {
              cout << "Queue is empty.\n";
              return -1;
          }
      }
      
      void display() {
          if (front != -1 && rear != -1 && front <= rear) {
              for (int i = front; i <= rear; ++i) {
                  cout << queue[i] << ' ';
              }
              cout << '\n';
          } else {
              cout << "Queue is empty.\n";
          }
      }
      ```
2. **Circular Queue**:
   - Address the limitation of simple queues by connecting the rear back to the front when it reaches the end of the array.
   - This allows efficient use of memory by reusing freed spaces.
   - Queue empty: `front = rear = 1-`.
   - Queue full:
     - `front = 0 & rear = SIZE - 1`.
     - `front = rear + 1`.
     ```c++
     #include <iostream>
     using namespace std;
    
     #define SIZE 5
    
     int queue[SIZE];
     int front = -1, rear = -1;
    
     bool isEmpty();
     bool isFull();
     void enqueue(int value);
     void dequeue();
     int peek();
     void display();
    
     int main() {
         enqueue(1);
         enqueue(2);
         enqueue(3);
         enqueue(4);
         enqueue(5);
         display();
    
         enqueue(6);
    
         dequeue();
         display();
    
         enqueue(6);
         display();
    
         cout << "peek = " << peek() << '\n';
    
         return 0;
     }
    
     bool isEmpty() {
         if (front == -1 && rear == -1)
             return true;
         else
             return false;
     }
    
     bool isFull() {
         if (front == 0 && rear == SIZE - 1)
             return true;
         else if (rear == front - 1)
             return true;
         else
             return false;
     }
    
     void enqueue(int value) {
         if (isFull())
             cout << "Queue is full.\n";
         else {
             if (isEmpty()) {
                 front = rear = 0;
                 queue[rear] = value;
             } else if (rear == SIZE - 1) {
                 rear = 0;
                 queue[rear] = value;
             } else {
                 queue[++rear] = value;
             }
         }
     }
    
     void dequeue() {
         if (isEmpty())
             cout << "Queue is empty.\n";
         else {
             if (front == rear)
                 front = rear = -1;
             else if (front == SIZE - 1)
                 front = 0;
             else
                 front++;
         }
     }
    
     int peek() {
         if (isEmpty()) {
             cout << "Queue is empty.\n";
             return -1;
         } else {
             return queue[front];
         }
     }
    
     void display() {
         if (isEmpty())
             cout << "Queue is empty.\n";
         else {
             if (front <= rear) {
                 for (int i = front; i <= rear; ++i) {
                     cout << queue[i] << ' ';
                 }
                 cout << '\n';
             } else {
                 for (int i = front; i < SIZE; ++i) {
                     cout << queue[i] << ' ';
                 }
                 for (int i = 0; i <= rear; ++i) {
                     cout << queue[i] << ' ';
                 }
                 cout << '\n';
             }
         }
     }
     ```
3. **Priority Queue**:
   - Elements are assigned priorities, and the element with the highest priority is dequeued first. regardless of insertion order.
   - Can be implemented using heaps, arrays, or linked lists.
4. **Deque (Double Ended Queue)**:
   - Allows insertion and deletion at both ends.
   - Elements can be added or removed from either front or rear, making it more flexible than standard queues.

## Queue Using Linked-List
```c++
#include <iostream>
using namespace std;

struct Node {
    int data;
    Node* next;
};

Node* front = nullptr;
Node* rear = nullptr;

void enqueue(int value);
void dequeue();
int peek();
void display();

int main() {
    enqueue(1);
    enqueue(2);
    enqueue(3);
    enqueue(4);
    enqueue(5);
    display(); // 1 2 3 4 5

    dequeue();
    display(); // 2 3 4 5

    cout << "peek = " << peek() << '\n'; // peek = 2

    enqueue(6);
    display(); // 2 3 4 5 6

    return 0;
}

void enqueue(int value) {
    Node* new_node = new Node;
    new_node->data = value;
    new_node->next = nullptr;

    if (front == nullptr)
        front = rear = new_node;
    else {
        rear->next = new_node;
        rear = new_node;
    }
}

void dequeue() {
    if (rear == nullptr)
        cout << "Queue is empty.\n";
    else if (front == rear) {
        Node* ptr = front;
        front = rear = nullptr;
        delete(ptr);
    } else {
        Node* ptr = front;
        front = front->next;
        delete(ptr);
    }
}

int peek() {
    if (front == nullptr) {
        cout << "Queue is empty.\n";
        return -1;
    } else {
        return front->data;
    }
}

void display() {
    if (front == nullptr)
        cout << "Queue is empty.\n";
    else {
        Node* current = front;
        while (current != nullptr) {
            cout << current->data << ' ';
            current = current->next;
        }
        cout << '\n';
    }
}
```
