namespace CalculadoraOO
{


    public class Operacoes
    {
        //Impedir que coloque diferente de numeros
        public static string lerNumeros()
        {
        ConsoleKeyInfo cki;
        string entrada = "";            
        while (true)
            if (Console.KeyAvailable)
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Backspace){
                    if (entrada.Length == 0) continue;
                    entrada = entrada.Remove(entrada.Length - 1);
                    Console.Write("\b \b"); //Remove o último caractere digitado
                }    
                if (cki.Key == ConsoleKey.Enter)
                {
                    break;
                }
                if ((ConsoleKey.D0 <= cki.Key) && (cki.Key <= ConsoleKey.D9) ||
                    (ConsoleKey.NumPad0 <= cki.Key) && (cki.Key <= ConsoleKey.NumPad9))
                {
                    entrada += cki.KeyChar;
                    Console.Write(cki.KeyChar);
                }

            }
        return entrada;
        }

        public static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Você está somando");
            Console.WriteLine("Diga um valor para somar");
            
            var valor1 = Console.ReadLine();


            double valorSoma1 = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorSoma1 = double.Parse(valor1);
            }
            else{
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }

            Console.WriteLine("Diga o outro valor para somar");
            var valor2 = Console.ReadLine();

            double valorSoma2 = 0;

            if(!string.IsNullOrEmpty(valor2))
            {
                valorSoma2 = double.Parse(valor2);
            }
            else{
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }
            


            double resultadoSoma = valorSoma1 + valorSoma2;

           
            Console.WriteLine($"O valor da soma é:{resultadoSoma}");
            
            Console.ReadKey();

            Menu.MenuPosResultado(resultadoSoma);

        }

        public static void SomaApos(double resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está somando");
            Console.WriteLine("Diga um valor para somar");
            var valor1 = Console.ReadLine();

            double valorSomaApos = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorSomaApos = double.Parse(valor1);
            }
            else{
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Console.WriteLine("Os valores inseridos anteriormente foram conservados");
                Thread.Sleep(2000);
                Menu.MenuPosResultado(resultadoAnterior);
            }
            

            
            double resultadoTodos = resultadoAnterior + valorSomaApos;

           
            Console.WriteLine($"O valor da soma do anterior e o novo numero:{resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }

        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Você está subtraindo");
            Console.WriteLine("Diga um valor para subtrair");

            var valor1 = Console.ReadLine();
            double valorSubtracao1 = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorSubtracao1 = double.Parse(valor1);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }


            Console.WriteLine("Diga o outro valor para diminuir");
            
            var valor2 = Console.ReadLine();
            double valorSubtracao2 = 0;

            if(!string.IsNullOrEmpty(valor2))
            {
                valorSubtracao2 = double.Parse(valor2);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }

            double resultadoSubtracao = valorSubtracao1 - valorSubtracao2;


            Console.WriteLine($"O valor da subtração é:{resultadoSubtracao}");
            Console.ReadKey();

            Menu.MenuPosResultado(resultadoSubtracao);
        }

        public static void SubtracaoApos(double resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está subtraindo");
            Console.WriteLine("Diga um valor para subtrair");
            var valor1 = Console.ReadLine();

            double valorSubtracaoApos = 0;
            
            if(!string.IsNullOrEmpty(valor1))
            {
                valorSubtracaoApos = double.Parse(valor1);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Console.WriteLine("Os valores inseridos anteriormente foram conservados");
                Thread.Sleep(2000);
                Menu.MenuPosResultado(resultadoAnterior);
            }


            double resultadoTodos = resultadoAnterior - valorSubtracaoApos;

           
            Console.WriteLine($"O valor da subtração do anterior e o novo numero:{resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }



        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Você está dividindo");
            Console.WriteLine("Diga um valor a ser dividido");

            var valor1 = Console.ReadLine();
            double valorDivisao1 = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorDivisao1 = double.Parse(valor1);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }


            Console.WriteLine("Diga o valor divisor");

            var valor2 = Console.ReadLine();
            double valorDivisao2 = 0;

            if(!string.IsNullOrEmpty(valor2))
            {
                valorDivisao2 = double.Parse(valor2);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }

            
            double resultadoDivisao = valorDivisao1 / valorDivisao2;


            Console.WriteLine($"O valor da soma é:{resultadoDivisao}");

            Console.ReadKey();

            Menu.MenuPosResultado(resultadoDivisao);
        }
        
        public static void DivisaoApos(double resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está dividindo");
            Console.WriteLine("Diga o divisor");
            var valor1 = Console.ReadLine();

            double valorDivisaoApos = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorDivisaoApos = double.Parse(valor1);
            }
            else{
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Console.WriteLine("Os valores inseridos anteriormente foram conservados");
                Thread.Sleep(2000);
                Menu.MenuPosResultado(resultadoAnterior);
            }
            
            double resultadoTodos = resultadoAnterior / valorDivisaoApos;

           
            Console.WriteLine($"O valor da divisão do valor anterior pelo divisor: {resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }

        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Você está multiplicando");
            Console.WriteLine("Primeiro valor");
            var valor1 = Console.ReadLine();
            double valorMultiplicacao1 = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorMultiplicacao1 = double.Parse(valor1);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }

            Console.WriteLine("Segundo valor ai moral");
            var valor2 = Console.ReadLine();
            double valorMultiplicacao2 = 0;

            if(!string.IsNullOrEmpty(valor2))
            {
                valorMultiplicacao2 = double.Parse(valor2);
            }
            else
            {
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Thread.Sleep(2000);
                Menu.MenuCalculadora();
            }

            double resultadoMultiplicacao = valorMultiplicacao1 * valorMultiplicacao2;

            Console.WriteLine($"Valor da multiplicação: {resultadoMultiplicacao}");
            Console.ReadKey();

           Menu.MenuPosResultado(resultadoMultiplicacao);
        }

        public static void MultiplicacaoApos(double resultadoAnterior)
        {
            Console.Clear();
            Console.WriteLine("Você está multiplicando");
            Console.WriteLine("Diga o multiplicador");
            var valor1 = Console.ReadLine();

            double valorMultiplicacaoApos = 0;

            if(!string.IsNullOrEmpty(valor1))
            {
                valorMultiplicacaoApos = double.Parse(valor1);
            }
            else{
                Console.WriteLine("Deu errado, não pode ser nulo ou vazio");
                Console.WriteLine("Os valores inseridos anteriormente foram conservados");
                Thread.Sleep(2000);
                Menu.MenuPosResultado(resultadoAnterior);
            }
            
            


            double resultadoTodos = resultadoAnterior * valorMultiplicacaoApos;

           
            Console.WriteLine($"O valor da multiplicação do valor pelo multiplicador é: {resultadoTodos}");
            
            Console.ReadKey();


            Menu.MenuCalculadoraTransicao(resultadoTodos);

        }

     
    }
}
