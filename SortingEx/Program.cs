using System;

namespace SortingEx
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new Sort();
            Console.Write("Input the string : ");
            var text = Console.ReadLine();
            Console.WriteLine(sort.SortText(text));
            Console.ReadLine();
        }
    }
}
