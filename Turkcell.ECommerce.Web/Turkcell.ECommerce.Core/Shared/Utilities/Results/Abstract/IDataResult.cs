using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>: IResult
    {
        public T Data { get;}
    }
}
