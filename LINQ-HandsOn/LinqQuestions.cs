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
        public void To_find_the_n_th_Maximum_grade_point_achieved_by_the_students_from_the_list_of_students(int n)
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            var nthmaxGrPoint = (from stu in stulist orderby stu.GrPoint descending group stu by stu.GrPoint into student select student).Take(n).Reverse().Take(1);
            foreach (var gr in nthmaxGrPoint)
            {
                //Console.WriteLine(gr.Key + " " + gr.Count());


                foreach (var student in gr)
                {
                    Console.WriteLine(student.StuId + " " + student.StuName + " " + student.GrPoint);
                }

            }
         

        }
        public void people_with_last_name_that_starts_with_the_letter_D(string latter)
        {
             List<Person>people = new List<Person>()
             {
                 new Person("Bill", "Smith", 41),
                 new Person("Sarah", "Jones", 22),
                 new Person("Stacy","Baker", 21),
                 new Person("Vivianne","Dexter", 19 ),
                 new Person("Bob","Smith", 49 ),
                 new Person("Brett","Baker", 51 ),
                 new Person("Mark","Parker", 19),
                 new Person("Alice","Thompson", 18),
                 new Person("Evelyn","Thompson", 58 ),
                 new Person("Mort","Martin", 58),
                 new Person("Eugene","DeLauter", 84 ),
                 new Person("Gail","Dawson", 19 ),

             };
            var peopleWithlastname = from per in people where per.LastName.StartsWith(latter) select per.LastName;
            foreach (var person in peopleWithlastname)
            {
                
                Console.WriteLine(person);
            }
            int num = (from per in people where per.LastName.StartsWith(latter) select per.LastName).Count();


            Console.WriteLine("number of people whose lastname start with D  :"+num);


            
            Console.WriteLine(" 9.	Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name");
            var names = from per in people orderby per.FirstName ascending where per.Age>40 select per.FirstName;
            foreach(var person in names)
            {
                Console.Write(person+" ");  
            }
        }
        public void Find_the_words_in_the_collection_that_start_with_the_letter_L()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var names = fruits.Where(fr => fr.StartsWith("L")).Select(fr => fr);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void Which_of_the_following_numbers_are_multiples_of_4_or_6()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var multiple_of_4_6 = mixedNumbers.Where(multiple => multiple % 4 == 0 && multiple % 6 == 0).Select(multiple => multiple);
            foreach (var number in multiple_of_4_6)
            {
                Console.WriteLine(number);
            }
        }

    }
}
