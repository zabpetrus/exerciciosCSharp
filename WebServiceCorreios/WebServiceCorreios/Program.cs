using System;

namespace WebServiceCorreios
{

    using ServiceReference1;

    class Program
    {
        static void Main(string[] args)
        {
            // Adicionar a api dos correios como dependencia

            //https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl


            //Ir em dependencias  -> Gerenciar Serviços compartilhados  -> Adicionar uma dependencia de servico
            //E aí coloca a url acima

            //Se der algum problema na execução, procure mudar o diretório de trabalho (de preferência de disco )

            //https://www.youtube.com/watch?v=jg4jxh3668Y

              Console.WriteLine("Informe o cep que deseja pesquisar! :");
                String cep = Console.ReadLine();
                if (!string.IsNullOrEmpty(cep))
                {
                    ConsultaCEP(cep);
                }
        }

       

        private static void ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);
                Console.Clear();
                Console.WriteLine(String.Format("Endereco: {0}", resposta.end));
                Console.WriteLine(String.Format("Bairro: {0}", resposta.bairro));
                Console.WriteLine(String.Format("Cidade: {0}", resposta.cidade));
                Console.WriteLine(String.Format("UF: {0}", resposta.uf));
                Console.WriteLine(String.Format("CEP: {0}", resposta.cep));
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para continuar...");


                Console.ReadKey();
            }
        }       
    }
}
