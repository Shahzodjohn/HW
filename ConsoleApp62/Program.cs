﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            //hw = 1
            //string word = "hello";
            //string newWord = string.Join(" ", word.Select(x => (x == 'a') ? '1' : (x == 'e') ? '2' : (x == 'i') ? '3' : (x == 'o') ? '4' : (x == 'u') ? '5' : x));

            //foreach (var item in newWord)
            //{
            //    Console.Write(item);
            //}



            // hw  = 2
            //string next = "h3 th2r2";
            //string newNext = string.Join("", next.Select(x => (x == '1') ? 'a' : (x == '2') ? 'e' : (x == '3') ? 'i' : (x == 4) ? 'o' : (x == 5) ? 'u' : x));
            //foreach (var item in newNext)
            //{
            //    Console.Write(item);
            //}


            //Hw3
            //reg = string.Join(null, Regex.Split(reg, "[^0-9-*-/-+-]"));
            //reg.Split('*');
            //Console.Write(regard);

           // HW 4

            //string[] Sumbol = new string[] { "+", "-", "*", "/" };
            //var TextQuery = new string((from ch in Console.ReadLine()
            //                            where Char.IsDigit(ch) || ch == '+' || ch == '-' || ch == '*' || ch == '/'
            //                            select ch).ToArray());
            //string sumbol = Sumbol.FirstOrDefault(S => TextQuery.Contains(S));
            //int Arg1 = int.Parse(new string(TextQuery.TakeWhile(ch => ch.ToString() != sumbol).ToArray()));
            //int Arg2 = int.Parse(new string(TextQuery.Reverse().TakeWhile(s => s.ToString() != sumbol).Reverse().ToArray()));
            //int result = 0;
            //switch (sumbol)
            //{
            //    case "+":
            //        {
            //            result = Arg1 + Arg2;
            //        }
            //        break;
            //    case "-":
            //        {
            //            result = Arg1 - Arg2;
            //        }
            //        break;
            //    case "*":
            //        {
            //            result = Arg1 * Arg2;
            //        }
            //        break;
            //    case "/":
            //        {
            //            result = Arg1 / Arg2;
            //        }
            //        break;
            //}
            //Console.WriteLine(result.ToString()); 

















            //hw = 4 "gdfgdf234dg54gf*23oP42"
            //string Mytext = "camelCase";


            //var chars = Mytext.ToString().SelectMany((x, i) => i > 0 && char.IsUpper(x) ? new char[] { ' ', x } : new char[] { x });

            //Console.WriteLine(new string(chars.ToArray()));















        }

    }
}
