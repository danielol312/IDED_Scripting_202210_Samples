using SourceSample.TreeSample;
using System;

namespace SourceSample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string test1 = "ABBA"; // true
            string test2 = "anitalavalatina"; // true
            string test4 = "ANTRAX"; // false
            string test3 = "AniTaLavaLaTina"; //???

            Console.WriteLine($"{test1} is Palindrome: {SampleAlgorithms.IsPalindrome(test1)}");
            Console.WriteLine($"{test2} is Palindrome: {SampleAlgorithms.IsPalindrome(test2)}");
            Console.WriteLine($"{test4} is Palindrome: {SampleAlgorithms.IsPalindrome(test4)}");
            Console.WriteLine($"{test3} is Palindrome: {SampleAlgorithms.IsPalindrome(test3)}");

            //Tree tree = new Tree();
            //Console.WriteLine($"Current value of tree root: {tree.root.Value}"); // 0
            //tree.WriteValue(tree.root, 76543);
            //Console.WriteLine($"Current value of tree root: {tree.root.Value}"); // 76543 --> 0


            Console.ReadKey();
        }
    }
}