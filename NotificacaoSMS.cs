
namespace ListaPilaresPOO
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Esta mensagem é enviada via sms");            
        }
    }
}