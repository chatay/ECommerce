using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.Core.CrossCuttingConcerns.Logging
{
    //log int string...
    public class LogParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public string Type { get; set; }
    }
}
