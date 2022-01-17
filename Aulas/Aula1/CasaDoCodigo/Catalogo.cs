using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Mexeu na Query", 12.99m));
            livros.Add(new Livro("002", "Rico com C#", 29.99m));
            livros.Add(new Livro("003", "Java baixinhos", 25.99m));
            return livros;
        }
    }
}
