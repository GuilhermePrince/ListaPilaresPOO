using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaPilaresPOO
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Esta é uma mensagem enviada para o Email");
        }
    }
}