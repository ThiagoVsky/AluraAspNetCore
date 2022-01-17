using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}