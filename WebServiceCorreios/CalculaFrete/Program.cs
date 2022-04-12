using System;

namespace CalculaFrete
{
    //Não sei qual dos dois irá vingar
    using ServiceReference1;
    using ServiceReference2;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void consultaFrete()
        {
            using (var tp =  new AtendeClienteClient())
            {

            }
        }

    }
}
