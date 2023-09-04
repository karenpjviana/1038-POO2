using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
        }

        public void Emprestimo()
        {
            Console.WriteLine("Emprestando Livro");
        }
        public void DevolucaoItem()
        {
            Console.WriteLine("Devolvendo Livro");
        }
    }
}
