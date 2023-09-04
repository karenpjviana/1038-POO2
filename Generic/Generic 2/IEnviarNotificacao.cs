using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_2
{
    internal interface IEnviarNotificacao
    {
        public void EnviarMensagemCliente();
    }
}

/*Vamos pegar o projeto de vcs da Empresa com interfaces!
Crie uma interface EnviarNotificacao com um método void EnviarMensagemCliente.
Crie uma classe EnviarNotificacaoWhatsApp, que implementa EnviarNotificacao e nela teremos o método EnviarMensagemCliente que printa a notificação: "Estou enviando uma mensagem no WhatsApp do Cliente!";

Dentro da classe Varejo, vamos incluir um private readonly EnviarNotificacaoWhatsApp que é recebido no construtor da classe.
Após Realizar a venda, utilizaremos o método de EnviarNotificacao.*/
