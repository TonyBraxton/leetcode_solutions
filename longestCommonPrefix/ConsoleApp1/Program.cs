using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            Console.Write("Please enter the input:");
            input = Console.ReadLine().Split(',');
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestCommonPrefix(input));
        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string common="";
            string[] myString=new string[100];
            int b = -1;
            int i;
            int j;
            List<string> myList = new List<string>();
            string sum = "";
            for (i = 0; i <= strs[0].Length - 1; i++)
            {
                int count = 0;
                if (strs.Length > 1 && strs[0] != "")
                {
                    for (j = 0; j <= strs.Length - 2; j++)
                    {
                        //j= j + 1;
                        if (strs[0].Length <= strs[j + 1].Length)
                        {
                            //int difference = strs[0].Length - strs[j + 1].Length;
                            if (strs[0].Substring(i, 1) == strs[j + 1].Substring(i, 1))
                            {
                                count++;
                                //myList.Add(strs[0].Substring(i, 1));
                                //if (j == strs.Length - 2 /*&& myList.Contains(strs[0].Substring(i, 1))*/)
                                //{
                                    if (count == strs.Length - 1)
                                    {
                                        b++;
                                        myString[b] = (strs[0].Substring(i, 1));//Convert.ToChar(strs[i].Substring(j, 1));
                                        common = common + myString[b];
                                        while (i == strs[0].Length - 1 && j == strs.Length - 2)
                                        {
                                            return common;
                                        }
                                    }

                               // }

                            }
                            else
                            {
                                return common;
                            }
                        }
                        else
                        {
                            int difference = strs[0].Length - strs[j + 1].Length;
                            //ring a = strs[j + 1].Substring(i, 1);
                            if (i == Convert.ToInt16(strs[j + 1].Length))//Last().ToString())
                            {
                                return common;
                            }
                            else if (strs[0].Substring(i, 1) == strs[j + 1].Substring(i, 1))
                            {
                                //myList.Add(strs[0].Substring(i, 1));
                                count++;
                                //myList.Add(strs[0].Substring(i, 1));
                                //if (j == strs.Length - 2 /*&& myList.Contains(strs[0].Substring(i, 1))*/)
                                //{
                                if (count == strs.Length - 1)
                                {
                                    b++;
                                    myString[b] = (strs[0].Substring(i, 1));//Convert.ToChar(strs[i].Substring(j, 1));
                                    common = common + myString[b];
                                    while (i == strs[0].Length - 1 && j == strs.Length - 2)
                                    {
                                        return common;
                                    }
                                }

                                //}
                            }
                            else
                            {
                                return common;
                            }
                        }
                    }
                }
                else
                {
                    common = strs[0];
                    return common;
                }
            }
            
            return common;
        }
    }
}
