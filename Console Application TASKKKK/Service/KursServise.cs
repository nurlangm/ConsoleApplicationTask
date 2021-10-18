using Console_Application_TASKKKK.Enums;
using Console_Application_TASKKKK.Interface;
using Console_Application_TASKKKK.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application_TASKKKK
{
    class KursServise : ICourseServise
    {
        private List<Student> _student = new List<Student>();
        public List<Student> Student => _student;


        private List<GroupClass> _group = new List<GroupClass>();
        public List<GroupClass> Group => _group;

        public void AllStuShow()
        {
            if (_student.Count == 0)
            {
                Console.WriteLine("Hal Hazirda telebe yoxdur");
                return;
            }
            foreach (Student stu in _student)
            {
                Console.WriteLine(stu);
            }
        }

        public string CreateGroup(IsOnline isonline,StuCategory category)//
        {
            GroupClass group = new GroupClass(isonline,category);/
            _group.Add(group);
            return group.No;


        }



        public string CreateStu(string fullname,string groupno,Qarantiya qarantiya)
        {
            GroupClass group = FindGroup(groupno);

            if (group == null)
            {
                Console.WriteLine($" *** {groupno} group does not exist ***");
            }
            Student student = new Student(fullname, groupno,qarantiya);
            _student.Add(student);
            return $"Fullname: {student.FullName}\nGorup No: {student.GroupNo}\nEdu type: {student.Type}\n";
        }

        public void EditGroup(string No, string newNo)
        {
            GroupClass grup = null;
            foreach (GroupClass group in _group)
            {
                if (group.No.ToLower().Trim() == No.ToLower().Trim())
                {
                    grup = group;
                    break;
                }
            }
            if (grup == null)
            {
                Console.WriteLine($"{No} group doesn't existed");
                return;
            }
            foreach (GroupClass group in _group)
            {
                if (newNo.ToLower().Trim() == group.No.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} has already existed");
                    return;
                }
            }
            grup.No = newNo.ToUpper();
            Console.WriteLine($"{No} succesfully updated to {newNo}");
        }
        public GroupClass FindGroup(string no)
        {
            foreach (GroupClass group in _group)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }

            }
            return null;
        }


        public void InGroupStu(string no)
        {
            GroupClass group = _group.Find(g => g.No.ToLower().Trim() == no.ToLower().Trim());
            if (group == null)
            {

                Console.WriteLine($"{no} group does not exist");

                return;
            }
            if (_student.Count == 0)
            {

                Console.WriteLine("There is no student");

                return;
            }
            foreach (Student std in _student)
            {
                Console.WriteLine(std);

            }
        }
        public void ShowGroup()
        {
            if (_group.Count == 0)
            {
                Console.WriteLine("There is no group ");
                return;
            }
            foreach (GroupClass group in _group)
            {
                Console.WriteLine(group);
            }
        }
    }

}
