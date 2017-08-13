using Logger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory.FactoryMethod
{
    public abstract class BaseStudentFactory
    {
        protected Student _student;
        public BaseStudentFactory(Student student)
        {
            _student = student;
        }
        public Student GetFees()
        {
            IStudent _iStudent = this.Create();
            _student.SemesterFee = _iStudent.SemesterFees();
            return _student;
        }
        public abstract IStudent Create();
    }
}
