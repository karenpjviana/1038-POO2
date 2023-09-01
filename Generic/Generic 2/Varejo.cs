using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Varejo : Empresa
    {
        public Varejo(string nome, string endereco, string cnpj) : base(nome, endereco, cnpj){ }

        public override void realizarVenda()
        {
            Console.WriteLine("Realizando Venda no varejo");
        }
    }
}
