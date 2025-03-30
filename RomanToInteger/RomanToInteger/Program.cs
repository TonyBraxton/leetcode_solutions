using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman;
            Console.Write("Enter a value for s:");
            roman = Console.ReadLine();
            Solution solution = new Solution();
            int Numerical = solution.RomanToInt(roman);
            Console.Write(Numerical);
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            string I="1";
            string V="5";
            string X ="10";
            string L = "50";
            string C = "100";
            string D = "500";
            string M = "1000";
            
           
            int sum = 0;
            string[] arr = new string[s.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = s.Substring(i, 1);
                if (arr[i].ToUpper() =="I")
                {
                    arr[i]="1";
                    sum = (sum + Convert.ToInt32(arr[i]));

                }
                else if(arr[i].ToUpper() == "V")
                {
                    if (i==0)
                    {
                        arr[i] = "5";
                        sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                    }
                    else
                    {
                        if (arr[i-1]!=I)
                        {
                            arr[i] = "5";
                            sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                        }
                        else
                        {
                            //arr[i] = "4";
                            sum = sum+(Convert.ToInt32(V) - Convert.ToInt32(arr[i-1])-Convert.ToInt32(I));
                        }
                    }

                }
                else if(arr[i].ToUpper() == "X")
                {
                    if (i == 0)
                    {
                        arr[i] = "10";
                        sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                    }
                    else
                    {
                        if (arr[i - 1] != I)
                        {
                            arr[i] = "10";
                            sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                        }
                        else
                        {
                            //arr[i] = "9";
                            sum = sum + (Convert.ToInt32(X) - Convert.ToInt32(arr[i - 1]) - Convert.ToInt32(I));
                        }
                    }

                }
                else if(arr[i].ToUpper() == "L")
                {
                    if (i == 0)
                    {
                        arr[i] = "50";
                        sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                    }
                    else
                    {
                        if (arr[i - 1] != X)
                        {
                            arr[i] = "50";
                            sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                        }
                        else
                        {
                            //arr[i] = "40";
                            sum = sum + (Convert.ToInt32(L) - Convert.ToInt32(arr[i - 1]) - Convert.ToInt32(X));
                        }
                    }

                }
                else if(arr[i].ToUpper() == "C")
                {
                    if (i == 0)
                    {
                        arr[i] = "100";
                        sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                    }
                    else
                    {
                        if (arr[i - 1] != X)
                        {
                            arr[i] = "100";
                            sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                        }
                        else
                        {
                            arr[i] = "90";
                            sum = sum + (Convert.ToInt32(C) - Convert.ToInt32(arr[i - 1]) - Convert.ToInt32(X));
                        }
                    }
                }
                else if(arr[i].ToUpper() == "D")
                {
                    if (i == 0)
                    {
                        arr[i] = "500";
                        sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                    }
                    else
                    {
                        if (arr[i - 1] != C)
                        {
                            arr[i] = "500";
                            sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                        }
                        else
                        {
                            arr[i] = "400";
                            sum = sum + (Convert.ToInt32(D) - Convert.ToInt32(arr[i - 1]) - Convert.ToInt32(C));
                        }
                    }
                }
                else if(arr[i].ToUpper() == "M")
                {
                    if (i == 0)
                    {
                        arr[i] = "1000";
                        sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                    }
                    else
                    {
                        if (arr[i - 1] != C)
                        {
                            arr[i] = "1000";
                            sum = Convert.ToInt32(sum + Convert.ToInt32(arr[i]));
                        }
                        else
                        {
                           // arr[i] = "4";
                            sum = sum + (Convert.ToInt32(M) - Convert.ToInt32(arr[i - 1]) - Convert.ToInt32(C));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    return 0;
                }
            }
            return sum;            
        }
    }
}
