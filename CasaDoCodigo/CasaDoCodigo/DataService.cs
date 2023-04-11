using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext _context;
        private readonly IProdutoRepository _produtoRepository;

        public DataService(ApplicationContext context,
            IProdutoRepository produtoRepository)
        {
            this._context = context;
            this._produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            this._context.Database.Migrate();

            List<Livro> livros = GetLivros();
            this._produtoRepository.SaveProdutos(livros);
        }


        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}


