using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Pacotes outroPacote = new Pacotes();
                outroPacote.Cadastrar();
                outroPacote.ViewInfo();

                ListaPacotes lista = new ListaPacotes();
                lista.Adicionar(outroPacote);
            }
            // CreateHostBuilder(args).Build().Run();
            // string resposta;
            // do {
            //     Pacotes 
            // }
        }

        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>();
        //         });
    }
}
