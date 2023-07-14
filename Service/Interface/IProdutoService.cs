using Domain.Entity;

namespace Service.Interface
{
    public interface IProdutoService 
    {
        Task<Produto> BuscarPorId(int id);
        Task<List<Produto>> BuscarTodos();
        Task<Produto> CriarNovoProduto(Produto produto);
        Task<Produto> AtualizarProduto(Produto produto);
        Task Delete(int id);
    }
}
