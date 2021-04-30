using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.MessageContracts
{
    public interface IRegisterMessageCommand
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

    }
}
