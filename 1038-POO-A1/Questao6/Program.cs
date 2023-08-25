namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiaDosNamorados namorados = new DiaDosNamorados("karen");
            namorados.ShowMessage();
            Natal natal = new Natal("karen");
            natal.ShowMessage();
            Aniversario aniversario = new Aniversario("karen");
            aniversario.ShowMessage();
            Console.ReadKey();
        }

        public abstract class CartaoWeb
        {

            public string Destinatario;

            public CartaoWeb(string destinatario)
            {
                this.Destinatario = destinatario;
            }

            public abstract void ShowMessage();
        }

        public class DiaDosNamorados : CartaoWeb
        {

            public DiaDosNamorados(string destinatario) : base(destinatario) { }

            public override void ShowMessage()
            {
                Console.WriteLine($"Feliz Dia dos Namorados, {Destinatario}!");
            }
        }
        public class Natal : CartaoWeb
        {
            public Natal(string destinatario) : base(destinatario) { }

            public override void ShowMessage()
            {
                Console.WriteLine($"Feliz Natal, {Destinatario}!");
            }
        }

        public class Aniversario : CartaoWeb
        {
            public Aniversario(string destinatario) : base(destinatario) { }

            public override void ShowMessage()
            {
                Console.WriteLine($"Feliz Aniversário, {Destinatario}!");
            }
        }
    }
}