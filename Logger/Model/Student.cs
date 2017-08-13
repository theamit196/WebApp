using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Model
{
    public class Student
    {
        public int StudentType { get; set; }
        public decimal SemesterFee { get; set; }
        public decimal HostelFee { get; set; }
        public decimal ExaminationFee { get; set; }

        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string MobileNo { get; set; }
    }
}
