using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.MessageContracts
{
    public class RabbitMqConsts
    {
        public const string RabbitMqUri = "amqps://ksqcsvpk:28yPP9rAR3xXJUKfTNb9Ho6zoXKilaj_@cow.rmq2.cloudamqp.com/ksqcsvpk";
        public const string UserName = "ksqcsvpk";
        public const string Password = "28yPP9rAR3xXJUKfTNb9Ho6zoXKilaj_";
        public const string RegisterDemandServiceQueue = "registerdemand.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string ThirdPartyServiceQueue = "thirdparty.service";
    }
}
