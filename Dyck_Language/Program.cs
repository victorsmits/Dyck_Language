using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using System.Linq.Expressions;

namespace Dyck_Language
{
    class MainClass
    {
        public static void Main()
        {

        }
        /*
        * @pre -
        * @post The returned value contains true if ’s’ is a Dyck word
        * given that the alphabet only contains ’(’ and ’)’
        * and false otherwise
        */
        public static bool IsDyckString(string s, Dictionary<string, string> alphabet)
        {
            Stack pile = new Stack();
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    var elem = s[i].ToString();

                    if (alphabet.ContainsKey(elem))
                    {
                        pile.Push(s[i]);
                    }
                    else if (alphabet.ContainsValue(elem))
                    {
                        var last = pile.Peek().ToString();

                        if (s[i].ToString() == alphabet[last])
                        {
                            pile.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return pile.Count == 0;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
    }

}
