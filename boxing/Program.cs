// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int intValue = 420;
object boxedValue = intValue; // Boxing: converting int to object
                              // 400 times slow operation
//boxing is the process of converting a value type to a reference type .moving from stack to heap . putting vakue in a box and move to heap.
//unboxing is the process of converting a reference type to a value type . moving from heap to stack . taking value out of box and putting it in stack.
int unboxedValue = (int)boxedValue; // Unboxing: converting object back to int
Console.WriteLine(unboxedValue); // Output: 420
Console.WriteLine(boxedValue.GetType()); // Output: System.Int32
Console.WriteLine(intValue.GetType()); // Output: System.Int32
Console.WriteLine(boxedValue is int); // Output: True
Console.WriteLine(boxedValue is object); // Output: True
Console.WriteLine(intValue is int); // Output: True
Console.WriteLine(intValue is object); // Output: True
Console.WriteLine(boxedValue.Equals(intValue)); // Output: True
Console.WriteLine(boxedValue.Equals(420)); // Output: True
Console.WriteLine(boxedValue.Equals(421)); // Output: False
Console.WriteLine(boxedValue.Equals("420")); // Output: False
Console.WriteLine(boxedValue.Equals(null)); // Output: False
Console.WriteLine(boxedValue.GetHashCode()); // Output: Hash code of the boxed value
Console.WriteLine(intValue.GetHashCode()); // Output: Hash code of the int value
Console.WriteLine(boxedValue.ToString()); // Output: "420"
Console.WriteLine(intValue.ToString()); // Output: "420"    