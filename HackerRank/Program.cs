using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

    static int insertionSort(int[] arr)
    {
        var shifts = 0;
        var dicNumbers = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            shifts+=dicNumbers.Where(kvp => kvp.Key > arr[i]).Sum(kvp => kvp.Value);

            if(!dicNumbers.ContainsKey(arr[i]))
                dicNumbers.Add(arr[i],1);
            else
                dicNumbers[arr[i]]++;
        }

        return shifts;

    }

    static void Main(string[] args) {
        
        var testData = "test.txt";
        var testBase = @"c:\temp";

        var answer = 0;

        using (TextReader tr = new StreamReader(Path.Combine(testBase, testData)))
        {
            var value = tr.ReadLine();
            var arr = value.Split(' ').Select(int.Parse).ToArray();
            int result = insertionSort(arr);

            Console.WriteLine(result);
        }

        //int t = Convert.ToInt32(Console.ReadLine());

        //for (int tItr = 0; tItr < t; tItr++) {
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //        ;
        //    int result = insertionSort(arr);

        //    Console.WriteLine(result);
        }

}
