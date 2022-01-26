namespace CalculadoraOO
{


    public class Operacoes
    {
        

        public static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Você está somando");
            Console.WriteLine("Diga um valor para somar");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Diga o outro valor para somar");
            float valor2 = float.Parse(Console.ReadLine());
            float resultadoSoma = valor1 + valor2;

           
            Console.WriteLine($"O valor da soma é:{resultadoSoma}");
            
            Console.ReadKey();

            Menu.MenuPosResultado(resultadoSoma);

        }

        public static void SomaApos(float resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está somando");
            Console.WriteLine("Diga um valor para somar");
            float valor1 = float.Parse(Console.ReadLine());
            
            float resultadoTodos = resultadoAnterior + valor1;

           
            Console.WriteLine($"O valor da soma do anterior e o novo numero:{resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }

        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Você está subtraindo");
            Console.WriteLine("Diga um valor para subtrair");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Diga o outro valor para diminuir");
            float valor2 = float.Parse(Console.ReadLine());
            float resultadoSubtracao = valor1 - valor2;


            Console.WriteLine($"O valor da soma é:{resultadoSubtracao}");
            Console.ReadKey();

            Menu.MenuPosResultado(resultadoSubtracao);
        }

        public static void SubtracaoApos(float resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está subtraindo");
            Console.WriteLine("Diga um valor para subtrair");
            float valor1 = float.Parse(Console.ReadLine());
            
            float resultadoTodos = resultadoAnterior - valor1;

           
            Console.WriteLine($"O valor da subtração do anterior e o novo numero:{resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }



        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Você está dividindo");
            Console.WriteLine("Diga um valor a ser dividido");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Diga o valor divisor");
            float valor2 = float.Parse(Console.ReadLine());
            float resultadoDivisao = valor1 / valor2;


            Console.WriteLine($"O valor da soma é:{resultadoDivisao}");

            Console.ReadKey();
           
            Menu.MenuCalculadora();

           Menu.MenuPosResultado(resultadoDivisao);
        }
        
        public static void DivisaoApos(float resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está dividindo");
            Console.WriteLine("Diga o divisor");
            float valor1 = float.Parse(Console.ReadLine());
            
            float resultadoTodos = resultadoAnterior / valor1;

           
            Console.WriteLine($"O valor da divisão do valor anterior pelo divisor: {resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }

        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Você está multiplicando");
            Console.WriteLine("Primeiro valor");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ai moral");
            float valor2 = float.Parse(Console.ReadLine());

            float resultadoMultiplicacao = valor1 * valor2;

            Console.WriteLine($"Valor da multiplicação: {resultadoMultiplicacao}");
            Console.ReadKey();

           Menu.MenuPosResultado(resultadoMultiplicacao);
        }

        public static void MultiplicacaoApos(float resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está multiplicando");
            Console.WriteLine("Diga o multiplicador");
            float valor1 = float.Parse(Console.ReadLine());
            
            


            float resultadoTodos = resultadoAnterior * valor1;

           
            Console.WriteLine($"O valor da multiplicação do valor pelo multiplicador é: {resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }

     
    }
}
