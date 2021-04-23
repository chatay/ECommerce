using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.Core.Shared.Utilities.Results
{
    public interface IResult
    {
        public ResultStatus ResultStatus{ get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}
