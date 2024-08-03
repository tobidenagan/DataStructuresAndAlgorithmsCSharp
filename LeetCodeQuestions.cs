namespace DataStructuresAndAlgorithmsCSharp
{
    public static class LeetCodeQuestions
    {
        public static int CountSeniors(string[] details)
        {
            int count = 0;
            if (details.Length < 1) return count;
            if (!(details.Length < 101)) return count;
            foreach (string item in details)
            {
                string ageString = item.Substring(item.Length - 4, 2);
                 _ = int.TryParse(ageString, out int age);
                if(age > 60) count++;
            }
            return count;
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numAndIndex = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++ ) 
            {
                int complement = target - nums[i];
                if (numAndIndex.ContainsKey(complement))
                    return [numAndIndex[complement], i];
                numAndIndex[nums[i]] = i;
            }
            return [];
        }
        public static int[] TwoSum2(int[] nums, int target)
        {
            int numberOfLoops = nums.Length * nums.Length;
            int[] result = new int[2];
            int x = 0;
            int y = 0;
            for (int i = 0; i < numberOfLoops; i++)
            {
                if (i % nums.Length == 0) 
                {
                    x = 0;
                    y++;
                }
                if (x == y ) continue;
                if (nums[x] + nums[y] == target)
                {
                    result[0] = x;
                    result[1] = y;
                    return result;
                }
                x++;
            }
            return result;
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int start = 0;
            for (int end = 0; end < n; end++)
            {
                if (charIndexMap.ContainsKey(s[end]))
                {
                    // Move the start to the next position of the last occurrence of s[end]
                    start = Math.Max(charIndexMap[s[end]] + 1, start);
                }
                // Update the last occurrence of s[end]
                charIndexMap[s[end]] = end;
                // Calculate the length of the current substring
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
        }
        public static bool CanBeEqual(int[] target, int[] arr)
        {
            if (target.Length != arr.Length) return false;
            Array.Sort(target);
            Array.Sort(arr);
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != arr[i]) return false;
            }
            return true;
        }
    }
}
