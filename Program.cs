using System;
using System.Collections.Generic;
//For question#4
using System.Linq;
//For question#4

namespace assignmentOne

{
    class Program
    {
        static void Main(string[]args)
        {
            //Question 1
            int[] marks = new int[] { 5, 6, 6, 9, 9, 12 };
            //Create new array
            bool inArray = false;
            //Create a boolean variable to determine if the target
            //is in the array and set accordingly

            Console.Write("[");
            //Write the first bracket to concatinate the final output

            //Run a loop to determine th length of the array and
            //assign value to index
            for (int i = 0; i < marks.Length; i++)

            {
                //If value in array equals target variable, then change boolean to true
                // and write the index value followed by a ","
                if (marks[i] == 9)

                {
                    if (inArray == true)

                    {
                        Console.Write(",");
                    }
                    Console.Write("{0}", i);
                    inArray = true;
                    //If the value exists multiple times in the array, then add a comma
                    //and continue adding the indexes.
                }

            }
            // If the target value is not in the array, set boolean to false
            // and return -1,-1.
            if (inArray == false)

            {
                Console.Write("-1,-1");
            }
            Console.Write("]");

            //Question - 4
            //You are given a string and your task is to sort the given string in decreasing order of frequency of occurrence of each character.
            //Example 1: Input : “Dell”Output: “llDe”
            //public static string FreqSort(string s)

            //Create string variables for the input and output
            string inString = "yYkk"; //eebhhh ; yYkk ; Dell
            string outString;

            //Create the words shown in the console with the input and output variables included
            Console.WriteLine("");
            Console.WriteLine("Question #4:::::::");
            Console.WriteLine("Given String to sort in decreasing order of frequency of occurence of each character:::::{0}", inString);


            outString = freqSort(inString);
            Console.WriteLine();
            Console.WriteLine("Converted String in the decreasing order of frequency of occurence of each character:::::{0}", outString);


            //Method created for sorting based on frequency
            static string freqSort(string inStrA)

            {
                //declare string variables and assign an empty value for the output
                //and assigning the input variable to string 'str'
                string str, outstr;
                str = inStrA;
                outstr = "";

                //Creating a dictionary to hold the characters
                Dictionary<char, int> findCharFrequency = new Dictionary<char, int>();


                for (int ctr = 0; ctr < str.Length; ctr++)

                {
                    int freq = str.Count(f => (f == str[ctr]));
                    findCharFrequency.TryAdd(str[ctr], freq);
                }
                //findCharFrequency contains unique characters and their occurance.
                //sort the given string in decreasing order of frequency of occurrence of each character

                var sortedList = findCharFrequency.ToList();
                var sortedDict = from entry in findCharFrequency
                orderby entry.Value descending
                select entry;


                foreach (var value
                in sortedDict)

                {
                    for (int ctr = 0; ctr < value.Value; ctr++)
                    {
                        outstr = outstr + value.Key;
                    }

                }

                return outstr; //return string to calling method
            }
            static string myReverse(string
            inputStr)

            {
                string str, revstr = ""; //for storing string value

                int len; //for counting length of given string

                str = inputStr;

                len = str.Length - 1; //storing the length of given string

                while (len >= 0) //loops the given string length

                {

                    revstr = revstr + str[len]; //performimg a reverse string according to length of given string

                    len--;

                }
                return revstr;

            }

        }

    }

}
        