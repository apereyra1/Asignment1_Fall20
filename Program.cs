using System;
using System.Linq;

namespace Assignment1_Fall20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintTriangle(n);

            int n2 = 5;
            PrintSeriesSum(n2);

            int[] A = new int[] { 1, 2, 2, 6 }; ;
            bool check = MonotonicCheck(A);
            Console.WriteLine(check);

            int[] nums = new int[] { 3, 1, 4, 1, 5 };
            int k = 2;
            int pairs = DiffPairs(nums, k);
            Console.WriteLine(pairs);

            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "dis";
            int time = BullsKeyboard(keyboard, word);
            Console.WriteLine(time);

            string str1 = "goulls";
            string str2 = "gobulls";
            int minEdits = StringEdit(str1, str2);
            Console.WriteLine(minEdits);

        }

        public static void PrintTriangle(int n)
        {
            try
            {
                Console.WriteLine("Please enter the number of rows:");
                int number = int.Parse(Console.ReadLine());
                string userInput = Console.ReadLine();

                int i, j, count = 1;using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1_ISM_6225
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintTriangle(n);

            int n2 = 5;
            PrintSeriesSum(n2);

            int[] A = new int[] { 1, 2, 2, 6 }; ;
            bool check = MonotonicCheck(A);
            Console.WriteLine(check);

            int[] nums = new int[] { 3, 1, 4, 1, 5 };
            int k = 2;
            int pairs = DiffPairs(nums, k);
            Console.WriteLine(pairs);

            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "dis";
            int time = BullsKeyboard(keyboard, word);
            Console.WriteLine(time);

            string str1 = "goulls";
            string str2 = "gobulls";
            int minEdits = StringEdit(str1, str2);
            Console.WriteLine(minEdits);

        }

        public static void PrintTriangle(int n)
        {
            try
            {
                Console.WriteLine("Please enter the number of rows:");
                int number = int.Parse(Console.ReadLine());
                string userInput = Console.ReadLine();

                int i, j, count = 1;
                count = n - 1;
                for (j = 1; j <= n; j++)
                {

                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;

                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
            }
        }

        public static void PrintSeriesSum(int n2)
        {
            try
            {
                int i, sum = 0;
                Console.WriteLine("\n\n");
                Console.WriteLine("Display the sum of n odd natural number:\n");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\n\n");

                Console.WriteLine("Input number of terms : ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe odd numbers are :");

                for (i = 1; i <= n2; i++)
                {
                    Console.WriteLine("{0} ", 2 * i - 1);
                    sum += 2 * i - 1;
                }
                Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n2, sum);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintSeriesSum()");
            }
        }

        public static bool MonotonicCheck(int[] A)
        {
            try
            {
                bool isIncreasing = false;
                bool isDecreasing = false;

                for (int i = 1; i < A.Length; i++)
                    if (!isIncreasing && A[i] > A[i - 1])
                        isIncreasing = true;
                    else if (!isDecreasing && A[i] < A[i - 1])
                        isDecreasing = true;

                return !(isIncreasing && isDecreasing);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing MonotonicCheck()");
                
            }
            return false;
        }

        public static int DiffPairs(int[] nums, int k)
        {
            try
            {
                int result = 0;

                // For k = 0 you have to just find if there are duplicate for an element and count them only once
                // hence just create dictionary to keep track of the same and increment the result when 2nd
                // element with same value exist.
                if (k == 0)
                {
                    var dictionary = new Dictionary<int, int>();
                    foreach (var x in nums)
                    {
                        if (dictionary.Keys.Contains(x))
                        {
                            dictionary[x]++;
                            if (dictionary[x] == 1)
                            {
                                result++;
                            }
                        }
                        else
                        {
                            dictionary.Add(x, 0);
                        }
                    }
                    return result;
                }

                // Cerate set and detect the pairs in the set by trying to find for each element
                // if there is another one with the difference in the same set.
                var hashSet = new HashSet<int>(nums);
                foreach (var x in hashSet)
                {
                    if (hashSet.Contains(x + k))
                    {
                        result++;
                    }
                }

                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing DiffPairs()");
            }

            return 0;
        }

        public static int BullsKeyboard(string keyboard, string word)
        {
            try
            {
                char[] chars = keyboard.ToCharArray();
                int[] countArray = new int[26];
                for (int i = 0; i < countArray.Length; i++)
                {
                    countArray[chars[i] - 'a'] = i;
                }

                int result = 0, position = 0;
                char[] charsWord = word.ToCharArray();
                for (int i = 0; i < charsWord.Length; i++)
                {
                    result = result + Math.Abs(countArray[charsWord[i] - 'a'] - position);
                    position = countArray[charsWord[i] - 'a'];
                }
                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing BullsKeyboard()");
            }

            return 0;
        }

        private static int min(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static int StringEdit(string str1, string str2)
        {
            try
            {
                if (str1 == str2)
                {
                    return 0;
                }
                else if (string.IsNullOrEmpty(str1))
                {
                    return str2.Length;
                }
                else if (string.IsNullOrEmpty(str2))
                {
                    return str1.Length;
                }

                var dp = new int[str1.Length + 1][];
                for (int i = 0; i < dp.Length; i++)
                {
                    dp[i] = new int[str2.Length + 1];
                    dp[i][0] = i;
                }

                for (int j = 0; j < dp[0].Length; j++)
                {
                    dp[0][j] = j;
                }

                for (int i = 1; i < dp.Length; i++)
                {
                    for (int j = 1; j < dp[0].Length; j++)
                    {
                        if (str1[i - 1] == str2[j - 1])
                        {
                            dp[i][j] = dp[i - 1][j - 1];
                        }
                        else
                        {
                            dp[i][j] = Math.Min(Math.Min(dp[i - 1][j], dp[i][j - 1]), dp[i - 1][j - 1]) + 1;
                        }
                    }
                }

                return dp[str1.Length][str2.Length];
            }
            catch
            {
                Console.WriteLine("Exception occured while computing StringEdit()");
            }

            return 0;
        }
    }
}

                count = n - 1;
                for (j = 1; j <= n; j++)
                {

                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;

                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
            }
        }

        public static void PrintSeriesSum(int n2)
        {
            try
            {
                int i, sum = 0;
                Console.WriteLine("\n\n");
                Console.WriteLine("Display the sum of n odd natural number:\n");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\n\n");

                Console.WriteLine("Input number of terms : ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe odd numbers are :");

                for (i = 1; i <= n2; i++)
                {
                    Console.WriteLine("{0} ", 2 * i - 1);
                    sum += 2 * i - 1;
                }
                Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n2, sum);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintSeriesSum()");
            }
        }

        public static bool MonotonicCheck(int[] A)
        {
            try
            {

                bool increasing = true;
                bool decreasing = false;

                for (int index = 0; index > A.Length - 1; index++)
                {


                    if (A[index + 1] < A[index])
                    {
                        if (!decreasing)
                        {
                            return true;
                        }
                     
                    }

                    else
                    {
                        if (!increasing)
                        {
                            return false;
                        }
                 
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing MonotonicCheck()");
            }
            return false;
        }
        public static int DiffPairs(int[] nums, int k)
        {
            try
            {
                // Stores the count of pairs 
                int answer = 0;

                // Sort the array 
                Array.Sort(nums);

                // Stores the minimum difference 
                // between adjacent pairs 
                int minDiff = 10000000;
                for (int i = 0; i < k - 1; i++)

                    // Update the minimum 
                    // difference between pairs 
                    minDiff = Math.Min(minDiff,
                                       nums[i + 1] -
                                       nums[i]);

                for (int i = 0; i < k - 1; i++)
                {
                    if (nums[i + 1] - nums[i] == minDiff)

                        // Increase count of 
                        // pairs with difference 
                        // equal to that of 
                        // minimum difference 
                        answer++;
                }

                // Return the final count 
                return answer;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing DiffPairs()");
            }

            return 0;
        }

        public static int BullsKeyboard(string keyboard, string word)
        {
            try
            {
                char[] chars = keyboard.ToCharArray();
                int[] countArray = new int[26];
                for (int i = 0; i < countArray.Length; i++)
                {
                    countArray[chars[i] - 'a'] = i;
                }

                int result = 0, position = 0;
                char[] charsWord = word.ToCharArray();
                for (int i = 0; i < charsWord.Length; i++)
                {
                    result = result + Math.Abs(countArray[charsWord[i] - 'a'] - position);
                    position = countArray[charsWord[i] - 'a'];
                }
                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing BullsKeyboard()");
            }

            return 0;
        }

        private static int min(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static int StringEdit(string str1, string str2)
        {
            try
            {
                int n = str1.Length;
                int m = str2.Length;
                int[,] d = new int[n + 1, m + 1];

                // Step 1
                if (n == 0)
                {
                    return m;
                }

                if (m == 0)
                {
                    return n;
                }

                // Step 2
                for (int i = 0; i <= n; d[i, 0] = i++)
                {
                }

                for (int j = 0; j <= m; d[0, j] = j++)
                {
                }

                // Step 3
                for (int i = 1; i <= n; i++)
                {
                    //Step 4
                    for (int j = 1; j <= m; j++)
                    {
                        // Step 5
                        int cost = (str1[j - 1] == str2[i - 1]) ? 0 : 1;

                        // Step 6
                        d[i, j] = Math.Min(
                            Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                            d[i - 1, j - 1] + cost);
                    }
                }
                // Step 7
                return d[n, m];
    }
            catch
            {
                Console.WriteLine("Exception occured while computing StringEdit()");
            }

            return 0;
        }
    }
}
