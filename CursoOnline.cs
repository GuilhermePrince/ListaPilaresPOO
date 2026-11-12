
namespace ListaPilaresPOO
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(string nome, decimal preco, int qtdHoras) : base(nome, preco)
        {
            CargaHoraria = qtdHoras;
        }
    }
}