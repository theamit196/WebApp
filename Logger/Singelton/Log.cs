using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Logger
{
    public sealed class Log : ILogger
    {
        //Make constructor private to prevent creating object
        //out side of the class scope
        private Log()
        {
        }
        /// <summary>
        /// Create object of class as static redonly to ensure that 
        /// further we can not instatiate it and decorate it with lazy keyword 
        /// to create the object if rally needed and for parallel processing
        /// </summary>
        private static readonly Lazy<Log> log = new Lazy<Log>(() => new Log());
        //Create static property whic will return the class object to the client
        public static Log GetLogInstance
        {
            get
            {
                return log.Value;//if we will use Lazy keyword then we need to return object value
            }
        }
        /// <summary>
        /// simple method to write exception in file
        /// </summary>
        /// <param name="ErrorMessage">Pass error message in parameter</param>
        /// <param name="SubFolder">Pass folder name </param>
        public void LogException(string ErrorMessage,string SubFolder)
        {
          var appdirectory=  AppDomain.CurrentDomain.BaseDirectory;
          bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(SubFolder));
          if (!exists)
              System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(SubFolder));
            string FileName = String.Format("{0}_{1}.log", "Exception", DateTime.Now.ToShortDateString());
            string FilePath = String.Format(@"{0}\{1}\{2}", appdirectory, SubFolder, FileName);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("------------------------------------------------------------");
            stringBuilder.Append(DateTime.Now.ToString());
            stringBuilder.Append(ErrorMessage);
            using (StreamWriter streamWriter = new StreamWriter(FilePath,true))
            {
                streamWriter.Write(stringBuilder.ToString());
                streamWriter.Flush();
            }
        }
    }
}
