namespace CalculadoraOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu.MenuCalculadora();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Comando invalido, apenas tecle enter após informar apenas numeros");
            }

           
            
        }
    }
}
