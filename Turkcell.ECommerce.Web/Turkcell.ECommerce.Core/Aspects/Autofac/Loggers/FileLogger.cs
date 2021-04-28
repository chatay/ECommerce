using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.CrossCuttingConcerns.Log4Net;

namespace Turkcell.ECommerce.Core.Aspects.Autofac.Loggers
{
    public class FileLogger : LoggerServiceBase
    {
        public FileLogger() : base("JsonFileLogger")
        {
        }
    }
}