namespace DataStructuresAndAlgorithmsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(LeetCodeQuestions.CountSeniors(["7868190130M7522", "5303914400F9211", "9273338290F4010"]));
            PrintArray(LeetCodeQuestions.TwoSum([3, 2, 4], 6));
            PrintArray(LeetCodeQuestions.TwoSum([2, 7, 11, 15], 9));
            Console.WriteLine(LeetCodeQuestions.LengthOfLongestSubstring("abcabcbb")); //3     
            Console.WriteLine(LeetCodeQuestions.LengthOfLongestSubstring("bbbbb")); //1   
            Console.WriteLine(LeetCodeQuestions.LengthOfLongestSubstring("pwwkew")); //3          
            Console.WriteLine(LeetCodeQuestions.LengthOfLongestSubstring("aab"));  //2         
            Console.WriteLine(LeetCodeQuestions.LengthOfLongestSubstring("abba"));  //2         
            Console.WriteLine(LeetCodeQuestions.CanBeEqual([1, 2, 3, 4], [2, 4, 1, 3]));  //true         
        }
        private static void PrintArray<T>(T[] arr)
        {
            Console.Write(string.Join(", ", arr));
            Console.WriteLine();
        }
    }
}
