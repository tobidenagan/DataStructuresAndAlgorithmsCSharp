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
        }
        private static void PrintArray<T>(T[] arr)
        {
            Console.Write(string.Join(", ", arr));
            Console.WriteLine();
        }
    }
}
