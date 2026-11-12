
namespace ListaPilaresPOO
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}\nMarca: {Marca}\nQuantidade de portas: {QuantidadePortas}");
        }


    }
}