namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futebol futebol = new Futebol();
            Console.WriteLine(futebol.IniciarJogo());
            Console.WriteLine(futebol.FinalizarJogo());
            Console.WriteLine(futebol.ExibirDescricao());
            Console.ReadKey();
        }

    }

    public abstract class EsporteBase
    {

        public abstract int QuantidadeJogadoresPorTime { get; set; }
        public abstract int TempoDeJogoEmMinutos { get; set; }

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public abstract string ExibirDescricao();

    }

    public class Futebol : EsporteBase
    {
        public int quantidade = 11;
        public int tempo = 90;

        public override int QuantidadeJogadoresPorTime
        {
            get => quantidade;
            set => quantidade = value;
        }

        public override int TempoDeJogoEmMinutos
        {
            get => tempo;
            set => tempo = value;
        }

        public override string IniciarJogo()
        {
            return "O jogo foi iniciado";
        }

        public override string FinalizarJogo()
        {
            return "O jogo foi finalizado";
        }

        public override string ExibirDescricao()
        {
            return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempoDeJogoEmMinutos} minutos";
        }

    }
}