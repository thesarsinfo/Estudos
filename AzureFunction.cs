using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace KimbleSenderEmail
{
    public class KimbleRemember
    {
        [FunctionName("KimbleRemember")]
        [return: SendGrid(ApiKey = "api")]
        public void Run([TimerTrigger("15 10 * * * *")]TimerInfo myTimer, ILogger log)
{
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("emaildaapi", "Thiago Saraiva"),
                Subject = "Lembrete Kimble",
                PlainTextContent = "Olá você recebeu email pra lembrar de preencher o seu Kimble",
                HtmlContent = "<strong>Não esqueça de preencher o kimble </strong>"
            };
            msg.AddTo(new EmailAddress("destino no email", "Thiago"));
            
            return msg;
        }
    }
}
