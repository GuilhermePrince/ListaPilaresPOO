
namespace ListaPilaresPOO
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook(string nome, decimal preco, int paginas) : base(nome, preco)
        {
            QuantidadePaginas = paginas;
        }        
    }
}