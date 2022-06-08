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
            Console.WriteLine("1.Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query ");
            linqQuestions.To_find_the_positive_numbers_from_a_list();
            Console.WriteLine();
            Console.WriteLine("2.	Write a program in C# Sharp to display the number and frequency of number from given array.");
            linqQuestions.To_display_the_number_and_frequency_of_number();
            Console.WriteLine();
            Console.WriteLine("3.	Write a program in C# Sharp to display the characters and frequency of character from giving string");

            linqQuestions.To_display_the_characters_and_frequency_of_character_from_giving_string();
            Console.WriteLine();
            Console.WriteLine("4.	Write a program in C# Sharp to find the string which starts and ends with a specific character");

            Console.WriteLine("please enter the Starting Character");
            string start = Console.ReadLine();
            Console.WriteLine("please enter the Ending Character ");
            string end = Console.ReadLine();

            linqQuestions.To_find_the_string_which_starts_and_ends_with_aspecific_character(start, end);
            Console.WriteLine();
            Console.WriteLine("5.	Write a program in C# Sharp to display the top n-th records.");

            Console.WriteLine("Please enter the nth number to See top Nth number for Array");
            int nth = Convert.ToInt32(Console.ReadLine());
            linqQuestions.To_display_nth_top_number(nth);
            Console.WriteLine("6.	Write a program in C# Sharp to find the n-th Maximum grade point achieved by the students from the list of students.");
            Console.WriteLine("Enter number:");
            int number=Convert.ToInt32(Console.ReadLine()); 
            linqQuestions.To_find_the_n_th_Maximum_grade_point_achieved_by_the_students_from_the_list_of_students(number);
            Console.WriteLine();
            Console.WriteLine("7.	 linq statement for people with last name that starts with the letter D");

            linqQuestions.people_with_last_name_that_starts_with_the_letter_D("D");
            Console.WriteLine();
            Console.WriteLine("10.	Find the words in the collection that start with the letter 'L'");
            linqQuestions.Find_the_words_in_the_collection_that_start_with_the_letter_L();
            Console.WriteLine();
            Console.WriteLine("11.	Which of the following numbers are multiples of 4 or 6");
            linqQuestions.Which_of_the_following_numbers_are_multiples_of_4_or_6();
            

            Console.ReadKey();
        }
    }
}
