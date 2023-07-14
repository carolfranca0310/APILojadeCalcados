using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interface;
using Repository.Repository;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
       private IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public async Task<Produto> CriarNovoProduto(Produto produto)
        {
            Produto produtoNovo = await _repository.Create(produto);

            return produtoNovo;
        }

        public Task<Produto> AtualizarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
