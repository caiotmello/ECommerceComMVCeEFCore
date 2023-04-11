using System.Collections.Generic;

namespace LivrosWeb
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}