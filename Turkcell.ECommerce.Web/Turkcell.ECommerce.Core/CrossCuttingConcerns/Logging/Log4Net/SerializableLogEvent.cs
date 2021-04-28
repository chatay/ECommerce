

using System;
using System.Collections.Generic;
using System.Text;
using log4net.Core;

namespace Turkcell.ECommerce.Core.CrossCuttingConcerns.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        private LoggingEvent _loggingEvent;

        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }

        public object Message => _loggingEvent.MessageObject;
    }
}
