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
    }
}
