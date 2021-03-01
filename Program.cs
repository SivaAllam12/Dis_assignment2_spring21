using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            //int[] arr2 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n1 = 3;
            if (ar1.Length % 2 == 0)//input validation
            {
                ShuffleArray(ar1, n1);
                Console.WriteLine("");
            }
            else
                Console.WriteLine("array length should be a multiple of 2");


            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 2, 0, 3, 0, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };

            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            //int[] ar4 = { 2, 7, 11, 15 };
            int[] ar4 = { 3, 2, 4 };
            int target = 6;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "USF";
            int[] indices = { 0, 1, 2 };
            if (indices.Length == s5.Length)//input validation
            {
                RestoreString(s5, indices);
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("please give string and indices of same length");
                Console.WriteLine();
            }


            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "ab";
            string s62 = "aa";
            if (s61.Length == s62.Length)//input validation
            {
                if (Isomorphic(s61, s62))
                {
                    Console.WriteLine("Yes the two strings are Isomorphic");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No, the given strings are not Isomorphic");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Please input strings of same length");

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            int[,] scores2 = { { 1, 100 }, { 7, 100 }, { 1, 100 }, { 7, 100 }, { 1, 100 }, { 7, 100 }, { 1, 100 }, { 7, 100 }, { 1, 100 }, { 7, 100 } };
            HighFive(scores2);
            Console.WriteLine();
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 6;
            if (n8 >= 1)//input validation
            {
                if (HappyNumber(n8))
                {
                    Console.WriteLine("{0} is a happy number", n8);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0} is not a happy number", n8);
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Please enter a positive integer");

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 8;
            if (!(n10 <= 0))//input validation
            {
                Stairs(n10);
            }
            else
                Console.WriteLine("please enter any positive number");
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                //intialize two new arrays
                int[] nums1 = new int[n];
                int[] nums2 = new int[n];
                //resultant array initialization
                int[] result = new int[2 * n];
                int j = 0, k = 0, l = 0;
                //Assign values to nums1
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums[i];
                }
                //Assign values to nums2
                for (int i = n; i < 2 * n; i++)
                {
                    nums2[j] = nums[i];
                    j++;
                }
                //Generate values for resultant array
                for (int i = 0; i < 2 * n; i = i + 2)
                {
                    result[i] = nums1[k];
                    k++;
                }
                for (int i = 1; i < 2 * n; i = i + 2)
                {
                    result[i] = nums2[l];
                    l++;
                }
                //Display resultant array
                Console.Write("[");
                for (int i = 0; i < result.Length; i++)
                {
                    if (i != result.Length - 1)
                    {
                        Console.Write("{0},", result[i]);
                    }
                    else
                        Console.WriteLine("{0}]", result[i]);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                //intialize a loop.
                for (int i = 0; i < ar2.Length; i++)
                {
                    //initialize a loop to traverse through entire array
                    for (int j = 1; j < ar2.Length - i; j++)
                    {
                        //checke whether any element in the array is zero
                        if (ar2[j - 1] == 0)
                        {
                            //swap the values
                            ar2[j - 1] = ar2[j];
                            ar2[j] = 0;
                        }
                    }
                }
                //Display the final array
                Console.Write("[");
                for (int i = 0; i < ar2.Length; i++)
                {
                    if (i != ar2.Length - 1)
                        Console.Write("{0},", ar2[i]);
                    else
                        Console.Write("{0}]", ar2[i]);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                int count, result, sum = 0;
                //initialize a dictionary
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    //check count of each number
                    count = nums.Count(s => s == nums[i]);
                    if (!dict.ContainsKey(nums[i]))
                    {
                        //add the counts to dictionary
                        dict.Add(nums[i], count);
                    }
                }
                var vals = dict.Values;
                foreach (var val in vals)
                {
                    //apply the formula to get cool pairs
                    result = val * (val - 1) / 2;
                    sum = sum + result;
                }
                //print the final output
                Console.WriteLine(sum);

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                //loop over the given numbers
                foreach (int num in nums)
                {
                    //calculate the required number
                    int req_num = target - num;
                    //check whether required number exists or not
                    if (req_num == num)
                    {
                        //count the required numbers
                        int c = nums.Count(s => s == req_num);
                        if (c >= 2)
                        {
                            Console.WriteLine("[{0},{1}]", Array.IndexOf(nums, num), Array.LastIndexOf(nums, req_num));
                            break;
                        }
                    }
                    //check whether required number exists or not
                    else if (Array.Exists(nums, s => s == req_num))
                    {
                        Console.WriteLine("[{0},{1}]", Array.IndexOf(nums, num), Array.IndexOf(nums, req_num));
                        break;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //initialize a dictionary
                Dictionary<int, char> restore_dict = new Dictionary<int, char>();
                int i = 0;
                for (i = 0; i < indices.Length; i++)
                {
                    //assign values to dictionary
                    restore_dict[indices[i]] = s[i];
                }
                //initialize a new list
                List<int> restoreKeys_list = new List<int>();
                //Convert keys to list
                restoreKeys_list = restore_dict.Keys.ToList();
                //sort the list
                restoreKeys_list.Sort();
                foreach (var val in restoreKeys_list)
                {
                    Console.Write(restore_dict[val]);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                //initialize a dictionary
                Dictionary<char, char> char_map = new Dictionary<char, char>();
                for (int i = 0; i < s1.Length; i++)
                {
                    //checked whether dictionary already contains the value or not
                    if (char_map.ContainsValue(s2[i]))
                    {
                        //get the key of a value and check with current one
                        if (char_map.FirstOrDefault(s => s.Value == s2[i]).Key == s1[i])
                            continue;
                        else
                            return false;
                    }
                    else
                    {
                        //assign values to dictionary
                        char_map[s1[i]] = s2[i];
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                //initialize a dictionary
                Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
                //loop through given array
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    //check the dictionary keys 
                    if (dict.ContainsKey(items[i, 0]))
                    {
                        //add the values dictionary
                        dict[items[i, 0]].Add(items[i, 1]);
                    }
                    else
                    {
                        //add the elemnts into dictionary
                        dict.Add(items[i, 0], new List<int>());
                        dict[items[i, 0]].Add(items[i, 1]);
                    }
                }
                //loop the dictionary
                for (int i = 0; i < dict.Count(); i++)
                {
                    //sort the values in the dictionary
                    dict.ElementAt(i).Value.Sort();
                    dict.ElementAt(i).Value.Reverse();
                    var top5 = dict.ElementAt(i).Value.Take(5);
                    if (i == 0)
                    {
                        Console.Write("[");
                        Console.Write("[{0},{1}],", dict.ElementAt(i).Key, Convert.ToInt32(top5.Average()));
                    }
                    else if (i != dict.Count - 1)
                    {
                        Console.Write("[{0},{1}],", dict.ElementAt(i).Key, Convert.ToInt32(top5.Average()));
                    }
                    else
                    {
                        Console.Write("[{0},{1}]", dict.ElementAt(i).Key, Convert.ToInt32(top5.Average()));
                        Console.Write("]");
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                //start a while loop
                while (n != 1)
                {
                    //take the coefficient
                    int n1 = n / 10;
                    //take the reminder
                    int n2 = n % 10;
                    //add coefficient and reminder
                    n = n1 + n2;
                    if (n1 == 0)
                        //break the loop when coefficient is zero
                        break;
                };
                if (n == 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                //assume min as first item
                int min = prices[0], pf = 0;
                //loop over the prices array
                for (int i = 0; i < prices.Length; i++)
                {
                    if (min > prices[i])
                    {
                        //change the min value
                        min = prices[i];
                    }
                    if (pf < prices[i] - min)
                        //calculate profit
                        pf = prices[i] - min;
                }
                return pf;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                //initialize a list with 0,1,2
                List<int> fibSeries = new List<int>() { 0, 1, 2 };
                //Loop over the for loop to get required fib value
                for (int i = 3; i <= steps; i++)
                {
                    //calculate the required fib num
                    int num = fibSeries[i - 1] + fibSeries[i - 2];
                    //add values to fibseries
                    fibSeries.Add(num);
                }
                int output = fibSeries[steps];
                //display the output
                Console.WriteLine(output);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
