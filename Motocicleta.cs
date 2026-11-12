
namespace ListaPilaresPOO
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}\nMarca: {Marca}\nCilindradas: {Cilindradas}cc");
        }

    }
}