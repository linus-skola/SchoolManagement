using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement
{
    public class SchoolClass
    {
        public Teacher[] Teachers
        {
            get => default;
            set
            {
            }
        }

        public Student[] Students
        {
            get => default;
            set
            {
            }
        }

        public void AddStudent()
        {
            throw new System.NotImplementedException();
        }

        public void AddTeacher()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveTeacher()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveStudent()
        {
            throw new System.NotImplementedException();
        }
    }
}