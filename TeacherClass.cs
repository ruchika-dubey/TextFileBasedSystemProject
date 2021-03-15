using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextFileBasedSystemProject
{
    class TeacherClass
    {
        public static string GetPath()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\TeacherData.txt";
            return path;
        }
        public static void AddTeacher()
        {
           
            string filename = GetPath();
            StreamWriter wrt;
            if (!File.Exists(filename))
            {
                wrt = File.CreateText(filename);
            }
            else
            {
                 wrt =  File.AppendText(filename);
            }
           
            Console.WriteLine("Enter the Id");
                wrt.Write(Console.ReadLine()+",");
                Console.WriteLine("Enter the Name");
                wrt.Write(Console.ReadLine() + ",");
                Console.WriteLine("Enter the Class and Section");
                wrt.WriteLine(Console.ReadLine());
                wrt.Close();
                Console.WriteLine("*****Content lines have been added into file*****");
            
        }
        public static void GetTeacherData()
        {
            string filename = GetPath();
            if (File.Exists(filename))
            {
                string[] contents = File.ReadAllLines(filename);
                Print(contents);
            }

            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        public static void SearchByName(string id)
        {
            string filename = GetPath();
            if (File.Exists(filename))
            {

                string[] contents = File.ReadAllLines(filename);

                int flag = 0;
                foreach (var content in contents)
                {
                 string[] details = content.Split(",");
                    if (id.Equals(details[0]))
                    {
                        Console.WriteLine("*****data exists*****");
                        Console.WriteLine("ID:" + details[0] + "\tName:" + details[1] + "\tClass And Section:" + details[2]);
                       
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("no data found corresponding to the Id!");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

        }
      
        public static void UpdateTeacher(string id)
        {
            string filename = GetPath();

            int flag = 0;
            string[] content = File.ReadAllLines(filename);
            StreamWriter wrt = File.CreateText(filename);
            if (File.Exists(filename))
            {

                foreach (string line in content)
                {
                    string[] details = line.Split(",");
                    if (id.Equals(details[0]))
                    {
                        Console.WriteLine("Enter Name To Update:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Class and Section To Update:");
                        string ClassAndSection = Console.ReadLine();


                        wrt.WriteLine(details[0]+ "," + name + "," +ClassAndSection);
                        flag = 1;
                    }
                    else
                    {
                        wrt.WriteLine(details[0]+ "," + details[1] + "," + details[2]);
                    }
                }
                if(flag==0)
                    Console.WriteLine("no data found corresponding to the Id!");
                wrt.Close();
                
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        private static void Print(string[] contents)
        {
            foreach (string line in contents)
            {
                string[] details = line.Split(",");
                Console.WriteLine("ID:" + details[0] + "\tName:" + details[1] + "\tClass And Section:" + details[2]);
            }     

        }

    }
}
