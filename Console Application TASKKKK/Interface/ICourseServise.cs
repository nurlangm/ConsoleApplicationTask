using Console_Application_TASKKKK.Enums;
using Console_Application_TASKKKK.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application_TASKKKK.Interface
{
    interface ICourseServise
    {
        public List<GroupClass> Group { get; }
        public List<Student> Student { get; }/////

        public string CreateGroup(IsOnline isonline, StuCategory category);//IsOnline

        public void EditGroup(string no, string newNo);

        public void ShowGroup();

        public void InGroupStu(string no);

        public void AllStuShow();   

        public string CreateStu(string fullname, string groupno, Qarantiya qarantiya);

    }
}
