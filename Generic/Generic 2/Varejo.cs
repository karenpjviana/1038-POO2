using Generic_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Varejo : Empresa
    {
        private readonly EnviarNotificacaoWhatsApp enviarNotificacaçãoWhatsapp;
        public Varejo(string nome, string endereco, string cnpj, EnviarNotificacaoWhatsApp enviarNotificacaçãoWhatsapp) : base(nome, endereco, cnpj)
        {
            this.enviarNotificacaçãoWhatsapp = enviarNotificacaçãoWhatsapp;
        }
        public override void realizarVenda()
        {
            Console.WriteLine("Realizando Venda no varejo");
            enviarNotificacaçãoWhatsapp.EnviarMensagemCliente();
        }
    }
}
