using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        int numberOfdeletions = 0;


        for (int i = 0; i < s.Length; i++)
        {
            if (i+1 <= s.Length-1  && s[i] == s[i + 1])
            {
                //s.Remove(i, 1);
                numberOfdeletions++;
            }
            
        }

        return numberOfdeletions;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
