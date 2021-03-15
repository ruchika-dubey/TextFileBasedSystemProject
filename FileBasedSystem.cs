using System;
using System.Collections.Generic;
using System.Text;

namespace TextFileBasedSystemProject
{
    class FileBasedSystem
    {
        public static void Do()
        {
            string UserChoice;
            do
            {
                Console.WriteLine("*****Choose From The Below Options*****");
                Console.WriteLine("1.Store Teacher Data");
                Console.WriteLine("2.Retrive Teacher Data");
                Console.WriteLine("3.Update Teacher data");
                Console.WriteLine("4.Search By Id");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("*****Adding Data of a Teacher*****");
                        TeacherClass.AddTeacher();
                        break;
                    case 2:
                        Console.WriteLine("*****Displaying Teachers List*****");
                        TeacherClass.GetTeacherData();
                        break;
                    case 3:
                         Console.WriteLine("*****Updating Data of a Teacher*****");
                        Console.WriteLine("Input Id of the Teacher To Update... ");
                        TeacherClass.UpdateTeacher(Console.ReadLine());
                         break;
                    case 4:
                        Console.WriteLine("*****Search Data of a Teacher*****");
                        Console.WriteLine("Input Id of the Teacher To Search... ");
                        TeacherClass.SearchByName(Console.ReadLine());
                        break;



                    default:
                        Console.WriteLine("Incorrect Choice");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Want to continue?(Type yes/no)");
                UserChoice = Console.ReadLine().ToLower();
            } while (UserChoice.Equals("yes"));
        }
    }
}
