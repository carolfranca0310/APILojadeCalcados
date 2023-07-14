using Domain.Entity;
using Repository.Context;
using Repository.Interface;

namespace Repository.Repository
{
    public class ProdutoRepository: BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(BDContext context) : base(context) { }
        
    }
}
