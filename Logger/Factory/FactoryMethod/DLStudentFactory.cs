using Logger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory.FactoryMethod
{
    public class DLStudentFactory : BaseStudentFactory
    {
        public DLStudentFactory(Student student)
            : base(student)
        {

        }
        public override IStudent Create()
        {
            DLStudent dLStudent = new DLStudent();
            _student.ExaminationFee = dLStudent.ExaminationFees();
            return dLStudent;
        }
    }
}
