using Console_Application_TASKKKK.Service;
using System;

namespace Console_Application_TASKKKK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Welcome to The Course");
            Console.WriteLine();
            int selection;

            do
            {
                Console.WriteLine("1.Create Group");
                Console.WriteLine("***********************");
                Console.WriteLine("2.Show Groups");
                Console.WriteLine("***********************");
                Console.WriteLine("3.Edit Group");
                Console.WriteLine("***********************");
                Console.WriteLine("4.Get Group Students");
                Console.WriteLine("***********************");
                Console.WriteLine("5.Get All Students");
                Console.WriteLine("***********************");
                Console.WriteLine("6.Create Student");
                Console.WriteLine("***********************");
                Console.WriteLine("0.Exit");
                string selectStr = Console.ReadLine();

                bool result = int.TryParse(selectStr, out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuService.CreateGroup();
                            break;
                        case 2:
                            MenuService.ShowGroup();
                            break;
                        case 3:
                            MenuService.EditGroup();
                            break;
                        case 4:
                            MenuService.GroupStu();
                            break;
                        case 5:
                            MenuService.AllStu();
                            break;
                        case 6:
                            MenuService.CreateStu();
                            break;
                        case 0:
                            break;
                    }
                }

            } while (selection != 0);
        }
    }
}