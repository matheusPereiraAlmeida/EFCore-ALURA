using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
           // GravarUsandoEntity();
           // RecuperaProdutos();
           //ExcluirProdutos();
            AtualizarProdutos();
            Console.Read();
        }

        private static void AtualizarProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                Produto produto = repo.Produtos().First();
                produto.Nome = "Harry Potter e a Ordem da Fênix - Editado";
                repo.Atualizar(produto);
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAOEntity())
            {
                repo.Adicionar(p);
            }
        }
        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new ProdutoDAOEntity())
            {
                contexto.Adicionar(p);
            }
        }

        private static void RecuperaProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos().ToList();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }
        private static void ExcluirProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos().ToList();
                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
            }
        }
    }
}
