using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Singelton.Controllers
{
    //Single Responcibility Principle this class is only for handling exception
    public class BaseLogErrorController : Controller
    {
        //Created an instance of Ilogger controller
        private ILogger _ILogger;
        public BaseLogErrorController()
        {
            //initialized object of Log class into interface  which is based on singelton DP
            _ILogger = Log.GetLogInstance;
        }
        /// <summary>
        /// Overridding Onexception Method for handling exception of application which will capture 
        /// automatically from any action method or controller only we need to inhrit this controller
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            _ILogger.LogException(filterContext.Exception.ToString(), "ErrorLog");//calling method to write log in to file
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}