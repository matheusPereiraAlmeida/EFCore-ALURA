using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    internal class ProdutoDAOEntity : IDisposable, IProdutoDAO
    {
        private LojaContext contexto;

        public ProdutoDAOEntity()
        {
            this.contexto = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            contexto.Produtos.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            contexto.Produtos.Update(p);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return contexto.Produtos.ToList();
            
        }

        public void Remover(Produto p)
        {
            contexto.Produtos.Remove(p);
            contexto.SaveChanges();
        }
    }
}