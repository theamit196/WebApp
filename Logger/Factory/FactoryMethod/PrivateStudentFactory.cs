using Logger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory.FactoryMethod
{
    public class PrivateStudentFactory : BaseStudentFactory
    {
        public PrivateStudentFactory(Student student)
            : base(student)
        {

        }
        public override IStudent Create()
        {
            PrivateStudent privateStudent = new PrivateStudent();
            _student.HostelFee = privateStudent.ExaminationFees();
            return privateStudent;
        }
    }
}
