# Intro & OS Overview

## What is OS?
- Master control **software** that:
  - runs other programs.
  - acts as an interface between (H/W) and the user applications (S/W).
- Its main part, the **kernel**, resides in **memory at all times**.
- Kernel:
  - is the main component of the OS.
  - has the main functionality of the OS.

## What makes Operating Systems Existing and Challenging?
- The more devices there are, the greater the need for an OS.

## Challenge: Complexity
- Applications consisting of ...
  - ... a variety of SW modules that ...
  - ... run on a variety of devices (machines) that
    - implement different HW architectures.
    - run competing applications.
    - fail in unexpected ways.
    - can be under a variety of attacks.
- Not feasible to test SW for all possible environments and combinations of components and devices.
- The question is NOT whether there are bugs but how serious are the bugs!
- *Updates in windows are:
  - new features.
  - or fixed bugs.
- **GOAL: Correctness by design.**

## Questions:
- Does the programmer need to write a single program that performs many independent activities?
  - No, the programmer 
    - DOESN'T write the code that lets the program access the keyboard or monitor or memory or printer, 
    - he only uses built-in functions, or Api.
  - Actually, the OS does.
- Does every program have to be alerted for every piece of HW?
  - No.
  - Ex:
    - When you change the hard desk of your computer, you DON'T change the code of the program,
    - the OS talks to the HW whatever it is.
- Does the fault program crash everything?
  - No.
- Does every program have access to all HW?
  - No.
- *So:
  - All the answers are NO.
  - **OS help the programmer write robust programs!**

## Why Studying OS?
- Use computer more **effectively**.
- Learn **system design issues**, can be applied elsewhere.
- Active area of **research**.
- **GOAL**:
  - Design an OS so that the machine is _convenient_ to use (an SW Eng. problem) and _efficient_ (a System and Engineering problem).

## Goal & Syllabus:
- KNOW HOW the OS do its Main Jobs?
- Solve competition on...
  - Memory.
    - Physical.
    - Virtual.
  - CPU.
    - Single.
    - Multi.
  - Shared resource.
    - Critical sections.
    - Deadlocks.

## Chapter 2 - Operating Systems Overview

### What is an Operating System?
- Illusionist:
  - Provide clean, easy-to-use _abstractions_ of physical resources:
    - Infinity memory.
    - Higher level objects: files, users, messages.
    - Making limitations, virtualization.
  - The program wants to use:
    - Processor => through Threads.
    - Memory => through Address spaces.
    - Storage / hard disk => through Files.
    - Networks => through Sockets.
  - So, the OS abstracts everything from the HW to do the same as in the code.
  - **Process**:
    - Execution environment with restricted rights provided by OS.
    - Every program has its own process.
    - It provides nicer interface than raw HW. 
  - There are **system libraries** that let you interact with the process.
- Governor:
  - Manage protection, isolation, and sharing of resources
    - Resources allocation and communication.
    - Taxes = overhead.
  - Resource Manager "memory, CPU, I/O devices":
    - manage these efficiently:
  - Resource Allocation & Protection:
    - Context switch:
      - Save CPU's registers of process 1.
      - Load CPU's registers of process 2.
      - TAX: Save/Load Overhead.
    - OS isolates processes from each other.
    - OS isolates itself from other processes.
- History Teacher:
  - Learning from past to predict the future,
  - i.e. OS design tradeoffs change with technology.

### Uni-programming:
- ~ Single App. System.
- Processor must wait until for I/O instruction to complete before proceeding.
- **Inefficient** use of resources.

### Multiprogramming:
- When one job needs to wait for I/O, the processor can switch to the other job.

### Multiprogramming vs. Multiprocessing:
- Multiprogramming:
  - Only one processor can execute at a time.
  - Meanwhile, all other processors are waiting for the processor.
- Multiprocessing:
  - More than one process can be running simultaneously, each on a different processor.
  - Works in parallel.

### OS Bottom Line: Run Programs:
- Write them and compile them:
  - Data,
  - and Instructions.
- Load instruction and data segments of executable file into memory.
- Create stack "for function calls" and heap "for dynamic allocation".
- Transfer control to program.
- Provide services to program.
- While protecting OS and program.

### Four Fundamental OS Concepts:
- **Threads: Execution Context**
  - Fully describes program state.
  - Program counter, registers, execution flags, stack.
- **Address space (with or w/o translation)**
  - Set of memory addresses accessible to program (for read or write).
  - May be distinct from memory space of the physical machine (in which case programs operate in a virtual address space).
- **Process: an instance of a running program**
  - Protected address space + one or more threads.
- **Dual mode operation / Protection**
  - Only the "system" has the ability to access certain resources.
  - Combined with translation, isolates programs from each other and the OS from programs.

### 1) Threads:
- Thread: Single unique execution context (CPU Snapshot).
- Threads are _virtual cores_.
- Each virtual core (thread) consists of:
  1. CPU Registers (IP, SP, Flags, Int & Float Regs).
  2. Stack.
- Multiple threads: Multiplex HW in time.
- Where is "it" (the thread)?
  - If Run: on the real (physical core / CPU).
  - Else: Saves in chunk of memory - called **Thread Control Block (TCB)**. 
- What happened to switch?
  1. OS Run [how?].
  2. Save PC, SP, ... in vCPU1's TCB (memory).
  3. Load PC, SP, ... from vCPU2's TCB to phys. CPU, jumped to PC.
- What triggered this switch?
  - Timer, voluntary yield, I/O, other things will discuss.
- Illusion:
  - Infinite number of processors.
- Reality:
  - Threads execute on limited number of physical CPUs with variable "speed".
    - Programs must be designed to work with any schedule.

### 2) Address Space:
- The set of accessible addresses + state associated with:
  - For 32-bit processor: 2^32 = 4 billion (10^9) addresses.
  - For 46-bit processor: 2^46 = 18 quintillion (10^18) addresses.
- OS has 5 principle responsibilities:
  1. Dynamic allocation and management.
  2. Process isolation.
  3. Support of modular programming.
  4. Protection and Sharing.
  5. Long-term storage (by file system module).
- ALL achieved by **Virtual Memory** concept.
  - allows programs to address memory from a _logical point of view_.
  - Without regard to the limits of RAM.
- Illusion:
  - Max address space for each process (e.g. 4GB / process).
- Reality:
  - Only active part of a process is loaded at a given period.

### 3) Process:
- Definition:
  - execution environment with restricted rights:
    - One or more threads executing in a (protected) address space.
    - Owns memory (address space), file descriptors, network connections, ...
- Instance of a running program
  - When you run an executable, it runs its own process.
  - Application: one or more processes working together.
- Why processes?
  - Protected from each other.
  - OS protected from them.
- In modern OS, anything that runs outside the kernel runs in a process.
- Fundamental tradeoff between protection and efficiency:
  - Communication _easier within a process_.
  - Communication _harder between processes_.
- What is the relationship between program EXE & process?
  1. 1-to-1.
  2. 1-to-N.✅
  3. N-to-1.
  4. N-to-M.
- Processes vs. Threads:
  - Single core:
    - Switch overhead:
      - Same process: low.
      - Different process: high.
    - Protection:
      - Same process: low.
      - Different process: high.
    - Sharing overhead:
      - Same process: low.
      - Different process: high.
    - Parallelism: no.
  - Multicore:
    - Switch overhead:
      - Same process: low.
      - Different process: high.
    - Protection:
      - Same process: low.
      - Different process: high.
    - Sharing overhead:
      - Same process: low.
      - Different process, simultaneous: medium.
      - Different process, offloaded core: high.
      - Parallelism: yes.

### 4) Dual Mode + Switching:
- Processes (i.e. programs you run) execute in user mode:
  - **Less privilege**.
  - To perform privileged actions, processes **request services** from the OS kernel via _System Calls_.
  - mode bit = 1.
- Kernel executes in kernel mode:
  - Performs **privileged actions** to support running processes.
  - ... and configures HW to properly protect them (e.eg. address translation).
  - mode bit = 0.
- Carefully **controlled transitions** between user mode and kernel mode via:
  1. System calls,
  2. interrupts,
  3. exceptions.
- When to switch?
  - | Mechanism      | Cause                                                     | Use                                             | Example                                                 |
    |:---------------|:----------------------------------------------------------|:------------------------------------------------|:--------------------------------------------------------|
    | Interrupt      | External to the execution of the current instruction.     | Reaction to any asynchronous external event.    | String is read from KB.<br/> Printer is ready to print. |
    | Trap/Exception | Associated with the execution of the current instruction. | Handling of an error or an exception condition. | Divide by zero. <br/> Page fault.                       |
    | System call    | Explicit request.                                         | Call to an OS function.                         | cprintf(). <br/> malloc() [new operator].               |
- [Dual Mode Operation](dual%20mode.png).
  - The program runs in the user mode -> exit -> kernel mode.
  - During running may happen:
    - System call -> kernel mode -> user mode.
    - Interrupt -> kernel mode -> HW -> user mode.
    - Exception/trap -> kernel mode.

### Test Yourself:
1) Which one of the following is NOT considered as main objective for the OS?
    1. Makes a computer more convenient to use.
    2. Use resources in an efficient manner.
    3. Ability to evolve.
    4. Check main I/O devices.✅
    5. NONE.
2) What is the objectives of multiprogramming?
    1. Have a process running at all time.
    2. Have multiple programs waiting in a queue ready to run.
    3. Programs are developed by more than one person.
    4. To increase CPU utilization.✅
    5. NONE.
3) For the following piece of code for a user program, which line(s) need to invoke a SYSTEM CALL to perform its required action? [Choose all that apply]
   - ```C#
     int sum = 0;
     void main() {
       1: Random rnd = new Random();
       2: int N = rnd.Next(1, 1000); // generate a random number between 1 & 1000
       3: int [] arr = new int[N];
       4: for (int i = 0; i < N; i++) {
       5:    arr[i] = Math.Pow(i, 2);
       6:    sum += arr[i]; }
       7: Console.Writeline(sum.ToString());
     }
     ```
   - **ANSWER**: 1, 3 => new allocation, 7.