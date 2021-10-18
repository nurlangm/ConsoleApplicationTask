using Console_Application_TASKKKK.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application_TASKKKK.Models
{
    class GroupClass
    {
        public static int count=200;
        public string No { get; set; }

        public StuCategory Category { get; set; }

        public IsOnline IsOnline { get; set; }

        public int Limit { get; set; } //B


        public List<Student> students = new List<Student>();


        public GroupClass(IsOnline isonline,StuCategory category)
        {
            IsOnline = isonline;
            count = 200;
            switch (category)
            {
                case StuCategory.Programming:
                    No = "P" + count;
                    break;
                case StuCategory.Design:
                    No = "D" + count;
                    break;
                case StuCategory.SystemAdminstration:
                    No = "S" + count;
                    break;
                default:
                    break;
            }
            Category = category;
            count++;
        }
        public override string ToString()
        {
            return $"No: {No}-Isonline: {IsOnline}-Category: {Category}";
        }
    }
}   
