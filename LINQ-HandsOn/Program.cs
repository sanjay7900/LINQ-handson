using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqQuestions linqQuestions = new LinqQuestions();
            linqQuestions.To_find_the_positive_numbers_from_a_list();
            Console.WriteLine();
            linqQuestions.To_display_the_number_and_frequency_of_number();
            Console.WriteLine();
            linqQuestions.To_display_the_characters_and_frequency_of_character_from_giving_string();
            Console.WriteLine();
            Console.WriteLine("please enter the Starting Character");
            string start=Console.ReadLine();
            Console.WriteLine("please enter the Ending Character ");
            string end=Console.ReadLine();
            linqQuestions.To_find_the_string_which_starts_and_ends_with_aspecific_character(start, end);
            Console.WriteLine();
            Console.WriteLine("Please enter the nth number to See top Nth number for Array");
            int nth=Convert.ToInt32(Console.ReadLine());    
            linqQuestions.To_display_nth_top_number(nth);
            Console.ReadKey();
        }
    }
}
