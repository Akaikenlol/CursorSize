using System;

namespace CursorSize
{
    class Program
    {
        public static void Main(string[] args)
        
        {
        string m0 = "THis Example increment the cursor size from 1% to 100%";
        string m1 = "Cursor size = {0}% . (Press any key to continue...)";
        int[] sizes = {1,10,20,30,40,50,60,70,80,90,100};
        int saveCursorSize;

        saveCursorSize = Console.CursorSize;
        Console.WriteLine(m0);
        foreach (int size in sizes)
        {
            Console.CursorSize = size;
            Console.WriteLine(m1,size);
            Console.ReadKey();
        }
        }
    }
}