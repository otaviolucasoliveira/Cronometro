namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(" ----- MENU -----\n");
            Console.WriteLine("Selecione a opção que deseja\n");
            Console.WriteLine("S - segundos => 10s = 10 segundos");
            Console.WriteLine("M - Minutos => 10m = 10 minutos");
            Console.WriteLine("9 - Sair");

            string resposta = Console.ReadLine().ToLower(); //vai conerter para minúsculo os caracteres
            char tipo = char.Parse(resposta.Substring(resposta.Length - 1, 1)); //Substring pega uma parte dos caracteres, passando o valor inicial e quantidade de caracteres
            int tempo = int.Parse(resposta.Substring(0, resposta.Length - 1)); //Lenght pega o tamanho da string

            int multiplicador = 1;

            if (tipo == 'm')
            
                multiplicador = 60;

            if (tempo == 0)

                System.Environment.Exit(0);

            Inicio(tempo * multiplicador);
        }

        static void Inicio(int tempo)
        {
            
            int contador = 0;

            while (contador != tempo)
            {
                Console.Clear();

                contador++;

                Console.WriteLine(contador);
                Thread.Sleep(1000); //faz o programa "dormir" por x milisegundos, no caso 1000 = 1 segundo

            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado, voltando para o menu...");
            Menu();
        }
    }
}
