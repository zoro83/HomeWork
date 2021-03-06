﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Advance.Right.Bracket
{
    class Program
    {
        public static string OnlyBrackets(string str)
        {
            string onlyBrackets = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{' || str[i] == '}' || str[i] == '['
                || str[i] == ']' || str[i] == '<' || str[i] == '>'
                || str[i] == '(' || str[i] == ')')
                {
                    onlyBrackets += str[i];
                }
            }
            return onlyBrackets;
        }
        public static bool ChackRightBrackets(string inputStr)
        {
            string str = OnlyBrackets(inputStr);
            while (str.Contains("{}") || str.Contains("[]") || str.Contains("<>") || str.Contains("()"))
            {
                str = str.Replace("{}", "");
                str = str.Replace("[]", "");
                str = str.Replace("<>", "");
                str = str.Replace("()", "");
            }

            return (str == "") ? true : false;
        }

        static void Main(string[] args)
        {
            string str = "{ld0(pp)<k[loop]flor{hi}>(pi[<>pool])}";
            Console.WriteLine(str);
            Console.WriteLine(ChackRightBrackets(str)); // Output true or false
            Console.ReadKey();
        }
    }
}
