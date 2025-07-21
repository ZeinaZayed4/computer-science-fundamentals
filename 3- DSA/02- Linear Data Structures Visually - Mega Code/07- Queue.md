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
3. **Priority Queue**:
   - Elements are assigned priorities, and the element with the highest priority is dequeued first. regardless of insertion order.
   - Can be implemented using heaps, arrays, or linked lists.
4. **Deque (Double Ended Queue)**:
   - Allows insertion and deletion at both ends.
   - Elements can be added or removed from either front or rear, making it more flexible than standard queues.

