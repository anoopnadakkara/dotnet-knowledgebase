// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 1. Reference types are allocated on the heap.
// 2. value types are allocated on either the stack or heap according to their context.
// 3. The stack is a region of memory that stores value types and function call information.
// 4. The heap is a region of memory that stores reference types and dynamically allocated memory
// 5. The value type stored in stack if its created inside stack frame.
// 5. The value is stored in stack has an address, which is a pointer to the location in memory where the value is stored.
// 6. The address of a value type can be obtained using the `&` operator
// 7. Both heap and stack resides physically in RAM, but they are managed differently by the runtime.
// 8. The stack is managed automatically by the runtime, while the heap is managed by the garbage collector.
// 9. The stack is faster than the heap because it has a simple allocation  
// 10. The stack is a last-in-first-out (LIFO) data structure, while the heap is a more complex data structure that allows for dynamic memory allocation and deallocation.
// 11. The stack is limited in size, while the heap can grow and shrink dynamically

int number = 42;
// Its unsafe to use pointers in C# but it can be useful in some scenarios like interop with unmanaged code or performance-critical applications.
// To use pointers, you need to enable unsafe code in your project settings or use the `unsafe` keyword in your code.
// To enable unsafe code, you can add `<AllowUnsafeBlocks>true</AllowUnsafeBlocks>` in your project file (.csproj) or use the command line option `-p:AllowUnsafeBlocks=true` when building the project.
unsafe
{
    int* pointerToNumber = &number; // Pointer to the address of number
    Console.WriteLine($"Address of number: {(long)pointerToNumber:X}"); // Print
}
