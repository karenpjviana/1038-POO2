namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.cor = "Azul";
            retangulo.lado1 = 3.5;
            retangulo.lado2 = 2;
            Console.WriteLine(Teste.DetalhesFigura(retangulo));
            Console.ReadKey();
        }

        public abstract class Figura
        {
            public abstract string cor { get; set; }

            public abstract double area();
        }

        public class Retangulo : Figura
        {
            public double lado1;

            public double lado2;

            public string figuraCor;

            public override string cor
            {
                get => figuraCor;
                set => figuraCor = value;
            }

            public override double area()
            {
                return lado1 * lado2;
            }
        }

        public class Triangulo : Figura
        {
            public double _base;

            public double altura;

            public string figuraCor;

            public override string cor
            {
                get => figuraCor;
                set => figuraCor = value;
            }

            public override double area()
            {
                return _base * altura;
            }
        }

        public static class Teste
        {
            public static string DetalhesFigura(Figura figura)
            {
                return $"Cor da figura: {figura.cor} - Área da figura: {figura.area()}";
            }
        }
    }
}