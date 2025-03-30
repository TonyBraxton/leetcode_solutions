using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {3,2,4};
            int target = 6;
            TwoSum(myArray,target);
            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int i;
            int j;

            int[] result = new int[2];
            for (i = 0; i <=nums.Length-1; i++)
            {
                for(j = 0; j <=nums.Length-1; j++)
                {
                    if(nums[i] + nums[j] == target && i !=j)
                    {
                        result[0] = i;
                        result[1] = j;
                        Console.WriteLine($"{result[0]}," + $"{result[1]}");
                        return result;
                    }
                }
            }
            return result;
        }
    }
   
}