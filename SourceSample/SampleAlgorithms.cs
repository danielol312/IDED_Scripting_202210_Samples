using System.Collections.Generic;

namespace SourceSample
{
    public class SampleAlgorithms
    {
        public static bool IsPalindrome(string sourceString)
        {
            bool result = true;
            string compareStr = sourceString.ToLower();

            Stack<char> sourceStack = FillStack(compareStr);
            Stack<char> compareStack = FillStackInversed(compareStr);            

            do
            {
                result = sourceStack.Pop() == compareStack.Pop();
                //char char1 = sourceStack.Pop();
                //char char2 = compareStack.Pop();

                //result = char1 == char2;
            }
            while (result && sourceStack.Count > 0);

            return result;
        }

        private static Stack<char> FillStackInversed(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                stack.Push(str[i]);
            }

            return stack;
        }

        private static Stack<char> FillStack(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }

            return stack;
        }
    }
}