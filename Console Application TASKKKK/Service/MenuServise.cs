using Console_Application_TASKKKK.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Console_Application_TASKKKK.Service
{
    static class MenuService
    {
        public static KursServise KursServise = new KursServise();
        public static void CreateGroup()
        {
            Console.WriteLine("Zehmet Olmasa Ixtisas secin");
            foreach (var item in Enum.GetValues(typeof(StuCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            int category;
            string categoryStr = Console.ReadLine();
            bool categoryResult = int.TryParse(categoryStr, out category);
            //

            Console.WriteLine("Tehsiliniz Online yoxsa Offline olsun?");
            foreach (var atim in Enum.GetValues(typeof(IsOnline)))
            {
                Console.WriteLine($"{(int)atim}.{atim}");
            }
            Console.WriteLine("*********");
            int onlinee;
            string onlinenstr = Console.ReadLine();
            bool online = int.TryParse(onlinenstr, out onlinee);
            if (online)
            {
                switch (onlinee)
                {
                    case 1:
                        if (categoryResult)
                        {
                            switch (category)
                            {
                                case 1:
                                    string No = KursServise.CreateGroup(IsOnline.Online, StuCategory.Programming);
                                    Console.WriteLine($"{No} Qrupu Ugurla Yaradildi");
                                    break;
                                case 2:
                                    No = KursServise.CreateGroup(IsOnline.Online, StuCategory.Design);
                                    Console.WriteLine($"{No} Qrupu Ugurla Yaradildi");
                                    break;
                                case 3:
                                    No = KursServise.CreateGroup(IsOnline.Online, StuCategory.SystemAdminstration);
                                    Console.WriteLine($"{No} Qrupu Ugurla Yaradildi");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        if (categoryResult)
                        {
                            switch (category)
                            {
                                case 1:
                                    string No = KursServise.CreateGroup(IsOnline.Offline, StuCategory.Programming);
                                    Console.WriteLine($"{No} Qrupu Ugurla Yaradildi");
                                    break;
                                case 2:
                                    No = KursServise.CreateGroup(IsOnline.Offline, StuCategory.Design);
                                    Console.WriteLine($"{No} Qrupu Ugurla Yaradildi");
                                    break;
                                case 3:
                                    No = KursServise.CreateGroup(IsOnline.Offline, StuCategory.SystemAdminstration);
                                    Console.WriteLine($"{No} Qrupu Ugurla Yaradildi");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public static void EditGroup()//
        {
            Console.WriteLine("Zehmet olmasa deyiseceyiniz qrupun nomresini daxil edin:");

            string groupNo = Console.ReadLine();

            Console.WriteLine("Zehmet olmasa  yeni nomre daxil edin:");

            string newgroupNo = Console.ReadLine();

            KursServise.EditGroup(groupNo, newgroupNo);

        }

        public static void CreateStu()
        {
            Console.WriteLine("Telebe Ismi Girin");
            string fname = Console.ReadLine();
            Regex regex = new Regex(@"[A-Z][a-z]* [A-Z][a-z]*");
            if (!regex.IsMatch(fname))
            {
                Console.WriteLine($"Zehmet olmasa Gecerli Telebe ismi girin");
                return;
            }
            Console.WriteLine("Qrup Nomrenizi daxil edin");
            string grno = Console.ReadLine();
            Console.WriteLine("Tehsil sisteminizi secin");
            foreach (var cat in Enum.GetValues(typeof(Qarantiya)))
            {
                Console.WriteLine($"{(int)cat}.{cat}");
            }
            int category;
            string categoryStr = Console.ReadLine();
            bool categoryStrresult = int.TryParse(categoryStr, out category);
            if (categoryStrresult)
            {
                switch (category)
                {
                    case 1:
                        string info = KursServise.CreateStu(fname, grno, Qarantiya.Zemanetli);
                        Console.WriteLine($"{info} *** Student succesfully created ***");
                        break;
                    case 2:
                        info = KursServise.CreateStu(fname, grno, Qarantiya.Zemanetsiz);
                        Console.WriteLine($"{info} *** Student succesfully created ***");
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AllStu()
        {
            KursServise.AllStuShow();
        }//

        public static void GroupStu()//
        {
            Console.WriteLine("Zehmet olmasa qrup nomresi girin");
            string groupno = Console.ReadLine();
            KursServise.InGroupStu(groupno);
        }

        public static void ShowGroup()
        {
            KursServise.ShowGroup();
        }//
    }
}