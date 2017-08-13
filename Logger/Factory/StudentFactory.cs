using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory
{
    public class StudentSimpleFactory
    {
        /// <summary>
        /// Factory Class whic will return Student object based on condition
        /// </summary>
        /// <param name="StudentType"></param>
        /// <returns></returns>
        public IStudent GetStudent(int StudentType)//Call this method in controller and pass parameter from databaase or any where else
        {
            //Here we are returning the object of StudentType based on condition 
            //So if any changes occurs in studentClass we have no need to change 
            //logic in our controller whic is mainly aim to perform user action
            //But this is simple factory pattern not Factory method
            IStudent iStudent = null;
            switch (StudentType)
            {
                case 1:
                    iStudent = new RegularStudent();
                    break;
                case 2:
                    iStudent = new DLStudent();
                    break;
                case 3:
                    iStudent = new PrivateStudent();
                    break;
            }
            /*
            if (StudentType == 1)//Regular Student
            {
                iStudent = new RegularStudent();
            }
            else if (StudentType == 2)//DL Student
            {
                iStudent = new DLStudent();
            }
            else if (StudentType == 3)//Private Student
            {
                iStudent = new PrivateStudent();
            }*/
            return iStudent;
        }
    }
}
