using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement
{
    public class Student : Person, IComments
    {
        public int StudentID
        {
            get => default;
            set
            {
            }
        }

        public void Comment(string comment)
        {
            throw new NotImplementedException();
        }
    }


    public class Teacher : Person
    {
    }

    
}