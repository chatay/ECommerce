using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.ComplexTypes;

namespace Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } // ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get; }
    }
}
