using System;
using System.Diagnostics;

namespace test_algoritmov
{
	public class My123
	{
        public static void NaiveSearch(string text, string pattern)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Наивный поиск");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int n = text.Length;
            int m = pattern.Length;
            bool s = true;
            int kolich = 0;
            for (int i = 0; i <= n - m; i++)
            {
                //kolich++; ??????
                s = true;
                for (int j = 0; j < m; j++)
                {
                    kolich++;
                    if (text[i + j] != pattern[j])
                    {
                        s = false;
                        break;
                    }
                }

                if (s == true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine("сложность алгоритма = {0:d}, букв в слове = {1:d} ,букв в строке = {2:d}", kolich, n, m);
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            Console.WriteLine(ts1);
            if (s == false) Console.WriteLine("-1");

            Console.WriteLine("----------------------------");
        }


        private static int[] GetPrefix(string s)
        {
            
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                int k = result[i - 1];
                while (s[k] != s[i] && k > 0)
                {
                    k = result[k - 1];
                }
                if (s[k] == s[i])
                {
                    result[i] = k + 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            
            return result;
        }

        public static void FindSubstring(string text, string pattern)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("КМП");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int kolich = 0;
            int[] pf = GetPrefix(pattern);
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                kolich++;
                while (index > 0 && pattern[index] != text[i])
                {
                    index = pf[index - 1];
                    kolich++;
                }
                if (pattern[index] == text[i]) index++;
                if (index == pattern.Length)
                {
                    //return i - index + 1;
                    Console.WriteLine(i - index + 1);
                    break;
                    
                }
            }
            Console.WriteLine("сложность алгоритма = {0:d}, букв в слове = {1:d} ,букв в строке = {2:d}", kolich, text.Length, pattern.Length);

            //return -1;
            //Console.WriteLine("-1");
            TimeSpan ts1 = stopWatch.Elapsed;
            Console.WriteLine(ts1);

        }



    }

}

