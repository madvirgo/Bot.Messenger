using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class CallButton : PostbackButton
    {
        protected override ButtonType _Type
        {
            get
            {
                return ButtonType.phone_number;
            }
        }

    }
}
