using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var word = "abc ~/ .Ez";
            Console.WriteLine(Encipher(word, 1));

            var text = System.IO.File.ReadAllLines("./google-10000-english.txt");
            foreach (var line in text)
            {
                Console.WriteLine(line);
            }

        }

        public static string Encipher(string s, int n)
        {
            var letters = s.ToCharArray();
            ArrayList rotated = new ArrayList();
            foreach (var l in letters)
            {
                if (char.IsLetter(l))
                {
                    var d = char.IsUpper(l) ? "A" : "a";
                    var r = (char)(((((l + n) - Char.Parse(d)) % 26)) + Char.Parse(d));
                    
                        rotated.Add(r);

                }
                else
                {
                    rotated.Add(l);
                }
                
            }
            
            return string.Join("",rotated.ToArray());
        }

        static string Decipher(string s)
        {
            
            // import file - txt, json
            // read and convert to iterable 
            // loop rotation for each word from 1 to 26
            // for each rotation check if word is in file (if so, break)
            // and put in a final list and print
            return "";
        }
    }
}
