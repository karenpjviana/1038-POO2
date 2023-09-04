using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {
        public Revista(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
        }

        public void Emprestimo()
        {
            Console.WriteLine("Emprestando Revista");
        }
        public void DevolucaoItem()
        {
            Console.WriteLine("Devolvendo Revista");
        }
    }
}
