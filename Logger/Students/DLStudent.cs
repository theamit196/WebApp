using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory
{
    class DLStudent:IStudent
    {
        public void Create()
        {
            //write Logic here like Fee structure course duration learning center etc
        }
        public decimal SemesterFees()
        {
            // write logic here like feestructure college rule etc\
            decimal TutionFee = 10000;
            decimal LibraryFee = 500;
            decimal ExtraActivity = 1000;
            decimal SemesterFee = (TutionFee + LibraryFee + ExtraActivity);
            return SemesterFee;
        }
        public decimal ExaminationFees()
        {
            return 5000;
        } 
    }
}
