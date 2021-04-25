using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.ComplexTypes;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
