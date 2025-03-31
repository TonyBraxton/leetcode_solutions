using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int inputArr_size = int.Parse(Console.ReadLine());
            int[] inputArr = new int[inputArr_size];
            input = Console.ReadLine().Split(' ');
            for (int idx = 0; idx < inputArr_size; idx++)
            {
                inputArr[idx] = int.Parse(input[idx]);
            }

            duplicateElement(inputArr);
        }

        public static void duplicateElement(int[] inputArr)
        {
            // Write your code here
            List<int> myList = new List<int>();
            List<int> duplicates = new List<int>();
            int[] arr = new int[myList.Count()];

            int i = 0;
            for (i = 0; i <= inputArr.Length - 1; i++)
            {
                string b = inputArr[i].ToString();
                int count = 0;
                count++;
                if (myList.Contains(inputArr[i]))
                {
                    duplicates.Add(inputArr[i]);
                }
                else
                {
                    myList.Add(inputArr[i]);
                }
                if (i == inputArr.Length - 1)
                {
                    Console.WriteLine(duplicates.Min());
                }
            }
        }
    }
}
