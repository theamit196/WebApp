using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory
{
    class PrivateStudent:IStudent
    {
        public void Create()
        {
            //write logic here like fee structure etc
        }
        public decimal SemesterFees()
        {
            // write logic here like feestructure college rule etc
            decimal TutionFee = 20000;
            decimal LibraryFee = 1000;
            decimal ExtraActivity = 5000;
            decimal SemesterFee = (TutionFee + LibraryFee + ExtraActivity);
            return SemesterFee;
        }
        public decimal ExaminationFees()
        {
            return 5000;  
        }  
    }
}
