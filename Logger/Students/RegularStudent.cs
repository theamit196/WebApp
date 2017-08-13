using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory
{
    class RegularStudent : IStudent
    {
        public void Create()
        {
            // write logic here like feestructure college rule etc
        }
        public decimal SemesterFees()
        {
            // write logic here like feestructure college rule etc
            decimal TutionFee = 30000;  //including examination fee
            decimal LibraryFee = 5000;
            decimal ExtraActivity = 15000;
            decimal SemesterFee = (TutionFee + LibraryFee + ExtraActivity);
            return SemesterFee;
        }
       public decimal HostelFees()
        {
            decimal Accmodation = 30000;
            decimal MesCharge = 15000;
            decimal ExtraActivity = 1000;
            decimal HostelFee = (Accmodation + MesCharge + ExtraActivity);
            return HostelFee;
        }
    }
}
