using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO
{
    public class Menu : Operacoes
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

        public static void MenuCalculadora() 
        {
            
            Console.Clear();
         

            Console.WriteLine("Escolha uma opção para calculo");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("Quero sair - 5");
            Console.WriteLine("-----------------------");

            short res = short.Parse(lerNumeros());

            switch(res){

                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: System.Environment.Exit(0); break;

                default: MenuCalculadora(); break;
            }


        }

        public static void MenuPosResultado(float resultadoArmazenado)
        {
            Console.Clear();
            Console.WriteLine($"O que deseja fazer com o resultado?{resultadoArmazenado}");
            Console.WriteLine("1 - Convervar o resultado e usá-lo somado a ");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("Quero sair - 5");
            Console.WriteLine("-----------------------");

            short res = short.Parse(lerNumeros());

            switch (res)
            {

                case 1: SomaApos(resultadoArmazenado); break;

                case 2: SubtracaoApos(resultadoArmazenado); break;

                case 3: DivisaoApos(resultadoArmazenado); break;

                case 4: MultiplicacaoApos(resultadoArmazenado); break;

                case 5: System.Environment.Exit(0); break;

                default: MenuPosResultado(resultadoArmazenado); break;
            }
        }

        public static void MenuCalculadoraTransicao(float resultadoArmazenado) 
        {
            
            Console.Clear();

            Console.WriteLine($"O que deseja fazer esse novo resultado? {resultadoArmazenado}");
            Console.WriteLine("1 - Continuar somando");
            Console.WriteLine("2 - Subtrair o resultado");
            Console.WriteLine("3 - Dividir o resultado");
            Console.WriteLine("4 - Multiplicar o resultado");
            Console.WriteLine("5 - Limpar e voltar ao inicio");
            Console.WriteLine("Quero sair - 6");
            Console.WriteLine("-----------------------");

            short res = short.Parse(lerNumeros());

            switch(res){

                case 1: SomaApos(resultadoArmazenado); break;

                case 2: SubtracaoApos(resultadoArmazenado); break;

                case 3: DivisaoApos(resultadoArmazenado); break;

                case 4: MultiplicacaoApos(resultadoArmazenado); break;

                case 5: MenuCalculadora(); break;

                case 6: System.Environment.Exit(0); break;

                default: MenuCalculadoraTransicao(resultadoArmazenado); break;
            }


        }
    }
}
