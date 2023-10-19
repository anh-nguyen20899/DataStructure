namespace CTDL;
using System.Collections;
class Program
{
    public const int MaxLength = 12;
    static void Main(string[] args)
    {
        Stack my_stack = new Stack();
 
        // Adding elements in the Stack
        // Using Push method
        my_stack.Push("Geeks");
        my_stack.Push("geeksforgeeks");
        my_stack.Push("geeks23");
        my_stack.Push("GeeksforGeeks");
         if (my_stack.Contains("GeeksforGeeks") == true) 
        {
            Console.WriteLine("Element is found...!!");
        }
 
        else
        {
            Console.WriteLine("Element is not found...!!");
        }
    }
}
