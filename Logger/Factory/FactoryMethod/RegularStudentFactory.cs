using Logger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory.FactoryMethod
{
    public class RegularStudentFactory : BaseStudentFactory
    {
        public RegularStudentFactory(Student student)
            : base(student)
        {

        }
        public override IStudent CreateStudent()
        {
            RegularStudent regularStudent = new RegularStudent();
            _student.HostelFee = regularStudent.HostelFees();
            return regularStudent;
        }
    }
}
