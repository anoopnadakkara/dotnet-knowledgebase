// This program demonstrates a memory leak by continuously allocating memory
// without releasing it, which can lead to increased memory usage over time.
internal class Program
{
    // A static list to hold references to objects, preventing GC
    private static List<byte[]> _leakList = new List<byte[]>();
    private static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to allocate more memory or 'q' to quit.");

         while (true)
        {
            string input = Console.ReadLine();
            if (input?.ToLower() == "q")
            {
                break;
            }

            // Allocate a large byte array and add it to the static list
            // This object will remain rooted in memory as long as _leakList holds a reference
            try
            {
                byte[] largeObject = new byte[1024 * 1024 * 1000]; // 1 GB  
                _leakList.Add(largeObject);
                Console.WriteLine($"Allocated {largeObject.Length / (1024 * 1024)} MB. Total items in list: {_leakList.Count}");
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine($"Out of Memory: {ex.Message}");
                break;
            }
        }

        Console.WriteLine("Exiting application.");
    }
}