
namespace ListaPilaresPOO
{
    public abstract class Jogo
    {
        public string Nome { get; set; }
        protected string Plataforma;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome}, {Plataforma}");
        }
    }
}