using Generic;

namespace Generic_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ## Exercício 1
            Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
            Construa um método para imprimir as informações da empresa.
            Construa um método abstrato void RealizarVenda()

            Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
            Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

            Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.

            ## Exercício 2
            Faça o mesmo exercício aplicando Interfaces.
            Crie a classe base para herdar as propriedades porém façam os métodos através de implementação de Interface.

            Na main, crie uma lista de interface.
            Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
            Invoque os métodos da lista.

            Me enviem o repositório no grupo do discord repositorios*/

            List<IEmpresa> empresas = new List<IEmpresa>();
            EnviarNotificacaoWhatsApp enviarNotificacaoWhatsApp = new();

            Empresa varejo = new Varejo("Varejo", "Rua a", "000000000001", enviarNotificacaoWhatsApp);
            Empresa empreitada = new Empreitada("Empeitada", "Rua b", "000000000002");

            empresas.Add(varejo);
            empresas.Add(empreitada);

            foreach (var emp in empresas)
            {
                emp.realizarVenda();
                emp.imprimirInformacoes();
            }
        }
    }
}