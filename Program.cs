using System;
using System.Diagnostics;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
class Program
{

    static void NaiveSearch(string text, string pattern)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Наивный поиск");
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        int n = text.Length;
        int m = pattern.Length;
        bool s = true;
        int kolich = 0;
        for (int i = 0; i < n - m; i++)
        {
            kolich++;
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



        static void test(out TimeSpan ts)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Thread.Sleep(1000);
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts1 = stopWatch.Elapsed;
        //Console.WriteLine(ts1);
        ts = ts1;
    }



    static void Main()
    {
        string a0 = "abbbbbbbbbbba";
        string b = "abbbbbbbbbbba";
        string b0 = "ba";
        string a1 = "abcdabdadddeeerd";
        string f = "gfmddeuddfddeuddspddeuddgddebubcddeuddrythpddeuddlustddeuddqderbeyczkmgfmddeudgfgfmddeuddfspggfmddeuddfspgddebubcddeuddrythpddeuddlustddeuddqderbeyczkmgfmddeudgfgfmddeuddfspgddebubcrythplustqderbeyczkmgfmddeudgfmddeuddfspgddebubcrythplustqdmddeuddfspgddebubcrythplustqderbeyczkmgfmddeuddeerbeyrы";
        string d = "г";
        //string d = "ddeudde";
        TimeSpan t;
        //test(out t);
        //NaiveSearch(a, b);
        //My123.NaiveSearch(a1, b);
        //test_algoritmov.My123.NaiveSearch(a1, b);
        //test_algoritmov.My123.FindSubstring(a1, b);
        //Console.WriteLine(j);
        //test_algoritmov.My1234.bm(a1, b);
        test_algoritmov.My123.FindSubstring(a0, b);
        test_algoritmov.My123.NaiveSearch(a0, b);
    }
}