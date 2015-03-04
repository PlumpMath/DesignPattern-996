using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateII
{
    class Program
    {
        static void Main()
        {

            var systemOperator = new SystemOperator
            {
                CellPhone = "145616456",
                Email = "system@operator.com",
                Name = "Super Operator",
                Pager = "465565456"
            };
            var message = new Message();

            message.Sender = new SmsNotificationSender(systemOperator);
            message.Send();

            message.Sender = new MailNotificationSender(systemOperator);
            message.Send();
        }
    }
}
