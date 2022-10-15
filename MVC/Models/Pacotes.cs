using System;
using System.Collections.Generic;

namespace MVC.Models
{
    public class Pacotes
    {
        public string NomePacote { get; set; }
        public double Valor {get; set; }
        public string Destino {get; set;}

        public void ViewInfo()
        {
            Console.WriteLine($"Pacote: {NomePacote}");
            Console.WriteLine($"Valor: {Valor}");      
            Console.WriteLine($"Destino: {Destino}");  
        }
    }
}