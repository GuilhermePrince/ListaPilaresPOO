using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaPilaresPOO
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Esta mensagem é enviada via Push");    
        }
    }
}