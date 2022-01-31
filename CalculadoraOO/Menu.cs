using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO
{
    public class Menu : Operacoes
    {

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

            // short res = short.Parse(lerNumeros());
            
            var res = lerNumeros();
            short resMenu = 5;

            if(!string.IsNullOrEmpty(res))
            {
                resMenu = short.Parse(res);
            }
            else
            {
                MenuCalculadora();
            }

            
            switch(resMenu){

                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: System.Environment.Exit(0); break;

                default: MenuCalculadora(); break;
            }


        }

        public static void MenuPosResultado(double resultadoArmazenado)
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer com o resultado?");
            Console.WriteLine($"   Resultado: {resultadoArmazenado}");
            Console.WriteLine("1 - Usá-lo somado a ");
            Console.WriteLine("2 - Usá-lo subtraido por");
            Console.WriteLine("3 - Usá-lo divido por");
            Console.WriteLine("4 - Usá-lo multiplicado por");
            Console.WriteLine("Quero sair - 5");
            Console.WriteLine("-----------------------");

            // short res = short.Parse(lerNumeros());

            var res = lerNumeros();
            short resMenu = 5;

            if(!string.IsNullOrEmpty(res))
            {
                resMenu = short.Parse(res);
            }
            else
            {
                MenuPosResultado(resultadoArmazenado);
            }

            switch (resMenu)
            {

                case 1: SomaApos(resultadoArmazenado); break;

                case 2: SubtracaoApos(resultadoArmazenado); break;

                case 3: DivisaoApos(resultadoArmazenado); break;

                case 4: MultiplicacaoApos(resultadoArmazenado); break;

                case 5: System.Environment.Exit(0); break;

                default: MenuPosResultado(resultadoArmazenado); break;
            }
        }

        public static void MenuCalculadoraTransicao(double resultadoArmazenado) 
        {
            
            Console.Clear();

            Console.WriteLine("O que deseja fazer esse novo resultado?");
            Console.WriteLine($"   Resultado: {resultadoArmazenado}");
            Console.WriteLine("1 - Continuar somando");
            Console.WriteLine("2 - Subtrair o resultado");
            Console.WriteLine("3 - Dividir o resultado");
            Console.WriteLine("4 - Multiplicar o resultado");
            Console.WriteLine("5 - Limpar e voltar ao inicio");
            Console.WriteLine("Quero sair - 6");
            Console.WriteLine("-----------------------");

            // short res = short.Parse(lerNumeros());

            var res = lerNumeros();
            short resMenu = 5;

            if(!string.IsNullOrEmpty(res))
            {
                resMenu = short.Parse(res);
            }
            else
            {
                MenuCalculadoraTransicao(resultadoArmazenado);
            }


            switch(resMenu){

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
