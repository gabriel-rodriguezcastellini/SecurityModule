using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services.Extensions.Mail
{
    public class MailSender
    {
        private readonly MailConfiguration configuration;
        private readonly ILogger logger;

        public MailSender(MailConfiguration configuration, ILogger logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }

        public async Task EnviarMailAsync(Message message)
        {
            await EnviarMailAsync(GetMessage(message));
        }
        
        private MimeMessage GetMessage(Message message)
        {
            var mimeMessage = new MimeMessage();            
            mimeMessage.From.Add(new MailboxAddress(configuration.From));
            mimeMessage.To.AddRange(message.Para);
            mimeMessage.Subject = message.Asunto;
            mimeMessage.Body = new TextPart(TextFormat.Text) { Text = message.Contenido };            
            return mimeMessage;
        }

        private async Task EnviarMailAsync(MimeMessage message)
        {
            var smtpClient = new SmtpClient()
            {
                CheckCertificateRevocation = false
            };
            try
            {
                logger.InicioMetodo("EnviarMailAsync");
                logger.LogInformation("Asunto: {asunto}", message.Subject);
                logger.LogInformation("Mensaje: {mensaje}", message.GetTextBody(TextFormat.Text));
                logger.LogInformation("Enviando mail para:");
                foreach (var item in message.To)
                {
                    logger.LogInformation(item.ToString());
                }
                await smtpClient.ConnectAsync(configuration.SmtpServer, configuration.Port, true);
                await smtpClient.AuthenticateAsync(configuration.UserName, configuration.Password);
                await smtpClient.SendAsync(message);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Ocurrió un error en EnviarMailAsync");
            }
            finally
            {
                await smtpClient?.DisconnectAsync(true);
                smtpClient?.Dispose();
                logger.FinMetodo("EnviarMailAsync");
            }
        }
    }
}
