using Console_Application_TASKKKK.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application_TASKKKK.Models
{
    class Student
    {
        public string FullName { get; set; }

        public string GroupNo { get; set; } //int de ola biler

        public Qarantiya Type { get; set; }
        

        public Student(string fullname,string groupno,Qarantiya qarantiya)
        {
            FullName = fullname;
            GroupNo = groupno;
            Type = qarantiya;
            
            
        }
        public override string ToString()
        {
            return $"{FullName}-{GroupNo}-{Type}";
        }
        ///////////////////Deyisiklik oldu
    }
}
