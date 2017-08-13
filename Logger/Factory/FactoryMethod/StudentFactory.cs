using Logger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory.FactoryMethod
{
    public class StudentFactory
    {
        public BaseStudentFactory CreateFactory(Student student)
        {
            BaseStudentFactory baseStdFactory = null;
            if (student.StudentType == 1)
            {
                baseStdFactory = new RegularStudentFactory(student);
            }
            else if (student.StudentType == 2)
            {
                baseStdFactory = new DLStudentFactory(student);
            }
            else if (student.StudentType == 3)
            {
                baseStdFactory = new PrivateStudentFactory(student);
            }
            return baseStdFactory;
        }
    }
}
