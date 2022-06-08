# LINQ-handson
Linq Hands on:

1.	Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
Input: 
int[] n1 = {  
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14  
            };

2.	Write a program in C# Sharp to display the number and frequency of number from given array.
Input: 
        int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };  


Output:
The numbers in the array  are :                                                                               
 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2                                                              
The number and the Frequency are :                                                                            
Number 5 appears 3 times                                                                                      
Number 9 appears 2 times                                                                                      
Number 1 appears 1 times                                                                                      
Number 2 appears 2 times                                                                                      
Number 3 appears 2 times                                                                                      
Number 7 appears 3 times                                                                                      
Number 6 appears 3 times                                                                                      
Number 8 appears 1 times                                                                                      
Number 4 appears 1 times

3.	Write a program in C# Sharp to display the characters and frequency of character from giving string

Input the string: apple
Expected Output:
The frequency of the characters are :
Character a: 1 times
Character p: 2 times
Character l: 1 times
Character e: 1 times

4.	Write a program in C# Sharp to find the string which starts and ends with a specific character

Input:
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
Input starting character for the string : A
Input ending character for the string : M
Expected Output :
The city starting with A and ending with M is : AMSTERDAM

5.	Write a program in C# Sharp to display the top n-th records.

Input :
The members of the list are :
5
7
13
24
6
9
8
7
How many records you want to display ? : 3
Expected Output :
The top 3 records from the list are :
24
13
9


6.	Write a program in C# Sharp to find the n-th Maximum grade point achieved by the students from the list of students.
Input:
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

Expected Output:
Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : 3 
                                                                    
 Id : 7,  Name : David,  achieved Grade Point : 750                 
 Id : 10,  Name : Jenny,  achieved Grade Point : 750


7.	 linq statement for people with last name that starts with the letter D

Input:
var people = new List<Person>()
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

Expected Output:
Dexter
Dawson
DeLauter

8.	Number of people whose last name starts with the letter D

Output: 3

9.	Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name

Output: Bill, Bob, Brett, Evelyn, Mort, Eugene



10.	Find the words in the collection that start with the letter 'L'

Input:

List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };


11.	Which of the following numbers are multiples of 4 or 6



List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };






