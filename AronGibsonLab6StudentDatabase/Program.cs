using System;
using System.Text.RegularExpressions;

namespace AronGibsonLab6StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] students = new string[14,3 ]
            {
                {"Justin","Wyoming,MI", " Baja Blast"},
                {"Matt","Flint,MI","Hot Wings" },
                {"Logan","Plymouth,MI","Fuyuns" },
                {"Raston","Zeeland, MI","Vanilla Instant Pudding" },
                {"Yousif","Oak Park, MI","Deep Dish Pizza" },
                {"Yash","Detroit,MI","Hot Cheeto Puffs" },
                {"Chris","Novi","Tacos" },
                {"Radeen","Warren, MI","Mexican" },
                {"Josh"," Northville","Naleśniki" },
                {"Aron","Berea, KY","sushi" },
                {"Kasean","Detroit, MI","steak" },
                {"Scott","Lansing, MI","Nashville Chicken" },
                {"Delmar","Detroit,Mi","vietnamese food" },
                {"Brandon","Novi","Sushi" }
            };

            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine($"{i+1} {students[i,0]}");
            }

            string again = "y";
            do {
                bool inputValid = false;
                int num;
                do {
                    Console.WriteLine("Enter number of student.");
                    num = int.Parse(Console.ReadLine())-1;


                    if (num < 0)
                    {
                        inputValid = false;
                        Console.WriteLine($"Must be between 1 and {students.GetLength(0)}");
                    }
                    else if (num > students.GetLength(0))
                    {
                        inputValid = false;
                        Console.WriteLine($"Must be between 1 and {students.GetLength(0)}");
                    }
                    else
                        inputValid = true;

                } while (!inputValid);

                InfoFinder(num,students);


                inputValid = false;
                do
                {
                    Console.WriteLine("Get info of another student? y or n.");
                    again = Console.ReadLine().Trim().ToLower();
                    if (again == "y")
                        inputValid = true;
                    else if (again == "n")
                        inputValid = true;
                    else
                    {
                        Console.WriteLine("Please enter y or n.");
                        inputValid = false;
                    }
                } while (!inputValid);

            } while (again=="y");


            
        }

        public static void InfoFinder(int studentNum, string[,] students) {

            string moreInfo ="y";
            do
            {
                bool validInfo = true;
                do
                {
                    Console.WriteLine($"What would you like to know about {students[studentNum, 0]}? (Home town, favorite food) ");
                    string selectedInfo = Console.ReadLine().ToLower().Trim();
                    switch (selectedInfo)
                    {
                        case "home town":
                            Console.WriteLine($"The home town of {students[studentNum, 0]} is {students[studentNum,1]}.");
                            validInfo = true;
                            break;
                        case "favorite food":
                            Console.WriteLine($"The favorite food of {students[studentNum, 0]} is {students[studentNum, 2]}.");
                            validInfo = true;
                            break;
                        default:
                            Console.WriteLine("Invalid.");
                            validInfo = false;
                            break;
                    }
                } 
                while (!validInfo);
                
                do
                {
                    validInfo = true;
                    Console.WriteLine("more info? y or n.");
                    moreInfo = Console.ReadLine().Trim().ToLower();
                    if (moreInfo!="y") 
                    {
                        if (moreInfo!="n") 
                        {
                            Console.WriteLine("Please enter y or n.");
                            validInfo = false;
                        }
                    }
                            

                } while (!validInfo);
                
                

            } while (moreInfo=="y");


        }
        




    }
}
