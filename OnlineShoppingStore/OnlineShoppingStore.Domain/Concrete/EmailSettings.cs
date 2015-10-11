using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "connect2ankitbansal@gmail.com";
        public string MailFromAddress = "connect2ankitbansal@gmail.com";
        public bool UseSsl = true;
        public string UserName = "connect2ankitbansal@gmail.com";
        public string Password = "";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
