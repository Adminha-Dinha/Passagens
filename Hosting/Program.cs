﻿using Passagens;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClienteService));

            //Criando um EndPoint
            Uri endereco = new Uri("http://localhost:8080/clientes");
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);

            try
            {
                host.Open(); //Abre o serviço
                ExibeInformacoesServico(host);
                Console.ReadLine();
                host.Close(); //Fecha o serviço

            }
            catch (Exception ex)
            {

                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}
