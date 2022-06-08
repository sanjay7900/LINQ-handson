using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HandsOn
{
    
    public class LinqQuestions
    {
        public void To_find_the_positive_numbers_from_a_list()
        {
            int[] numbers=new int[] {1,3,-2,-4,-7,-3,-8,12,19,6,10,14};
            var positive=from num in numbers where num >0 select num;
            Console.Write("Positive number Are:  " );
            foreach (var number in positive)
            {
                Console.Write(number+"  ");
            }

        }
        public void To_display_the_number_and_frequency_of_number()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var number_frequency = from num in arr1 group num by num into fre select fre;
            Console.WriteLine("Numberr And Its FreQuency...");
            foreach (var number in number_frequency)
            {

                var frequenc = number.Count();
                var n = number.Key;
                Console.WriteLine("number " + n + " appears " + frequenc + " times");

            }
        }
        public void To_display_the_characters_and_frequency_of_character_from_giving_string()
        {
           string str = "apple";
           char[] data = str.ToCharArray();
            //
            var frequncy = from ch in data group ch by ch into fre select fre;
           foreach(var character in frequncy)
            {
                var frequenc = character.Count();
                var c = character.Key;
                Console.WriteLine("character " + c + " : " + frequenc + " times");

            
           }
        }
        public void To_find_the_string_which_starts_and_ends_with_aspecific_character(string start, string end)
        {
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI","AMSTERDAM","ABU DHABI","PARIS" };
            string a = "a";
            var cityLikewise=from city in cities where city.StartsWith(start)  && city.EndsWith(end) select city;
            Console.WriteLine("Start with "+start +" and end with "+ end);
            foreach(string city in cityLikewise)
            {
                Console.WriteLine(city);
            }
        }
        public void To_display_nth_top_number(int nth)
        {
            int[] number=new int[] {5,7,13,24,6,9,8,7};
            var topNth = number.OrderByDescending(n => n).Take(nth);
            Console.WriteLine(" top "+nth+"  number are ...");
            foreach(var num in topNth)
            {
                Console.WriteLine(num);
            }

        }

    }
}
