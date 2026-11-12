
namespace ListaPilaresPOO
{
    public abstract class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Esta é uma mensagem genérica");
        }
    }
}