using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloSeguridad.Services.Extensions.Mail
{
    public class Message
    {
        public List<MailboxAddress> Para { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }

        public Message(string para, string asunto, string contenido)
        {
            Para = new List<MailboxAddress>
            {
                MailboxAddress.Parse(para)
            };
            Asunto = asunto;
            Contenido = contenido;
        }
    }
}