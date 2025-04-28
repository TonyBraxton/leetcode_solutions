using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ValidParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString;
            Console.Write("Enter a string of characters containing only: ( or { or [ or ) or } or ] : ");
            myString = Console.ReadLine();
            Solution sol = new Solution();
            sol.IsValid(myString);
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            int openCurved = 0;
            int closeCurved = 0;
            int openCurly = 0;
            int closeCurly = 0;
            int openSquare = 0;
            int closeSquare = 0;
            List<char> myList= new List<char>();
            myList.Add('(');
            myList.Add(')');
            myList.Add('{');
            myList.Add('}');
            myList.Add('[');
            myList.Add(']');
            
            for (int i = 0; i <=s.Length-1; i++)
            {
                bool modl;
                

                if (myList.Contains(s[i]))
                {
                    if (s[0] == '(' || s[0] == '{' || s[0] == '[')
                    {
                        if (s[i] == '(')
                        {
                            openCurved++;

                            if (openSquare>=openCurved)
                            {
                                if (s.LastIndexOf(')') > s.LastIndexOf(']'))
                                {
                                    return false;
                                }
                                else
                                {

                                }
                            }
                            else if (openSquare<openCurved)
                            {
                                if (i == s.Length - 1)
                                {
                                    if (s.LastIndexOf(')') < s.LastIndexOf(']'))
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            Console.WriteLine("yes");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    
                                }
                                
                            }
                        }
                        else if (s[i] == ')')
                        {
                            closeCurved++;
                            if (openCurved == closeCurved)
                            {
                                if (openSquare > closeSquare)
                                {

                                    if (closeCurved > openSquare)
                                    {
                                        if (openCurved == closeCurved)
                                        {
                                            if (i == s.Length - 1)
                                            {
                                                if (s.IndexOf(s[i]) < s.LastIndexOf(']'))
                                                {
                                                    return false;
                                                }
                                            }
                                        }
                                        else if (openCurved != closeCurved)
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        if (i == s.Length - 1)
                                        {
                                            if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                            {
                                                Console.WriteLine("yes");
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                    }

                                }
                                else if (openCurly > closeCurly)
                                {
                                    if (closeCurved > openCurly && openCurved != closeCurved)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        if (i == s.Length - 1)
                                        {
                                            if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                            {
                                                Console.WriteLine("yes");
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (i == s.Length - 1)
                                    {
                                        if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            if (s.LastIndexOf(s[i]) < s.LastIndexOf(']'))
                                            {
                                                return false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("yes");
                                                return true;
                                            }
                                            
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                }

                            }
                            else if (openCurved == closeCurved && openCurly == closeCurly)
                            {
                                if (openSquare >= closeSquare)
                                {
                                    if (i == s.Length - 1)
                                    {
                                        if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            Console.WriteLine("yes");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                }
                                else
                                {
                                    return false;
                                }

                            }
                        }
                        else if (s[i] == '{')
                        {
                            if (i<s.Length-1 )
                            {
                                if( s[i + 1] != ')' && s[i + 1] != ']')
                                {
                                    openCurly++;
                                }
                            }
                            else
                            {
                                openCurly++;
                            }
                        }
                        else if (s[i] == '}')
                        {
                            closeCurly++;
                            if (openCurly == closeCurly)
                            {
                                if (openCurved == closeCurved || openSquare == closeSquare)
                                {
                                    if (i == s.Length - 1)
                                    {
                                        if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            Console.WriteLine("yes");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                }
                                
                            }
                            else if(openCurved == closeCurved && openSquare == closeSquare)
                            {
                                if(openCurly>=closeCurly)
                                {
                                    if (i == s.Length - 1)
                                    {
                                        if(openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            Console.WriteLine("yes");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                        
                                    }
                                }
                                else
                                {
                                    return false;
                                }

                            }
                            /*else
                            {
                                return false;
                            }*/
                        }
                        else if (s[i] == '[' )
                        {
                            if (i < s.Length - 1 )
                            {
                                if(s[i + 1] != ')' && s[i + 1] != '}')
                                {
                                    openSquare++;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                openSquare++;
                            }
                        }
                        else if (s[i] == ']')
                        {
                            closeSquare++;

                            if (openSquare == closeSquare)
                            {
                                if (openCurved > closeCurved)
                                {
                                    if(closeSquare>openCurved)
                                    {
                                        if(openSquare == closeSquare)
                                        {
                                            if(i == s.Length - 1)
                                            {
                                                if (s.IndexOf(s[i]) < s.LastIndexOf(')'))
                                                {
                                                    return false;
                                                }
                                            }
                                            
                                        }
                                        else if (openSquare != closeSquare)
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        if (i == s.Length - 1)
                                        {
                                            if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                            {
                                                Console.WriteLine("yes");
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                    }
                                    
                                }
                                else if(openCurly > closeCurly)
                                {
                                    if(closeSquare > openCurly)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        if (i == s.Length - 1)
                                        {
                                            if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                            {
                                                Console.WriteLine("yes");
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (i == s.Length - 1)
                                    {
                                        if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            Console.WriteLine("yes");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                }

                            }
                            else if (openCurved == closeCurved && openCurly == closeCurly)
                            {
                                if (openSquare >= closeSquare)
                                {
                                    if (i == s.Length - 1)
                                    {
                                        if (openCurly == closeCurly && openCurved == closeCurved && openSquare == closeSquare)
                                        {
                                            Console.WriteLine("yes");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                }
                                else
                                {
                                    return false;
                                }

                            }
                            /*else
                            {
                                return false;
                            }*/
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            Console.WriteLine("no");
            return false;
        }
    }
}
