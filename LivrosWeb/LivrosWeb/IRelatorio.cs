using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LivrosWeb
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}