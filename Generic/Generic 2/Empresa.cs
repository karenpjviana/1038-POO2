using Generic_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal abstract class Empresa : IEmpresa
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Cnpj { get; set; }

        protected Empresa(string nome, string endereco, string cnpj)
        {
            Nome = nome;
            Endereco = endereco;
            Cnpj = cnpj;
        }

        public void imprimirInformacoes()
        {
            Console.WriteLine("Nome da Empresa: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cnpj: " + Cnpj);
        }

        public abstract void realizarVenda();
    }
}
