using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logger;
using Logger.Factory;
using Logger.Model;
using Logger.Factory.FactoryMethod;
namespace Singelton.Controllers
{
    /// <summary>
    /// Base LogError is handling the exception of application
    /// </summary>
    public class HomeController : BaseLogErrorController
    {
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            var avgValue = GetAverageValue(400, 0);
            ViewBag.Value = avgValue;
            return View();
        }
        private int GetAverageValue(int TotalValue, int NoOfItem)
        {
            //Created runtime exception to log error in file using singeltion

            return  TotalValue / NoOfItem;
        }
        /// <summary>
        /// This is Simple Factory
        /// Which abstract the creation details of product
        /// It refers to the newly created object through an interface
        /// Any new type creation is handed with a change of code in factory class and 
        /// not at the clint code
        /// </summary>
        /// <param name="StudentType"></param>
        /// <returns></returns>
        public ActionResult CreateStudent(Student student)
        {
            //using simple factory method
           // StudentSimpleFactory studentSimpleFactory = new StudentSimpleFactory();
            //IStudent iStudent = studentSimpleFactory.GetStudent(student.StudentType);
            //student.SemesterFee = iStudent.SemesterFees();
            //But there is problem in this code we have not exposed the HostelFee and examinationFee through the IStudent
            //hence if we need to calculate hostel fees and examination fees at the point where simple factory is creating the IStudent
            //then we need to modify the simple factory which is voilating the creational principle
            //So wecan solve this issues by providing another layer of abstraction which takes care of computing the common interface operation
            //awa specific operation related to student types


            //Using Factory Method
            BaseStudentFactory studentFactory = new StudentFactory().CreateFactory(student);
            studentFactory.GetFees();
            
            return View(student);
        }
    }
}