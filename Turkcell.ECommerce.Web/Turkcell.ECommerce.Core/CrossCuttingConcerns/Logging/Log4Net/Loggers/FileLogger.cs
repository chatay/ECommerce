using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.Core.CrossCuttingConcerns.Log4Net.Loggers
{
    public class FileLogger : LoggerServiceBase
    {
        public FileLogger() : base("JsonFileLogger")
        {
        }
    }
}
