using System.Collections.Generic;

namespace LivrosWeb
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha query", 12.99m));
            livros.Add(new Livro("002", "Fiquei rico com C#", 30.99m));
            livros.Add(new Livro("003", "Java para iniciantes", 24.99m));

            return livros;
        }
    }
}
