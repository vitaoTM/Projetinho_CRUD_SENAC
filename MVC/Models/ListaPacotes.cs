using System.Collections.Generic;
using System;


namespace MVC.Models
{
    public class ListaPacotes
    {
       List<Pacotes> ListaPacotes = new List<Pacotes>();

       public void Adicionar(Pacotes pacoteNovo)
       {
            ListaPacotes.Add(pacoteNovo);
       } 
       public Mostrar()
       {
            for(i = 0; i < listaPacotes.Count; i++)
            {

                Console.WriteLine("Pacotes Cadastrados");
                Console.WriteLine($"Pacote {listaPacotes[].NomePacote}");
                Console.WriteLine($"Valor: {listaPacotes[].Valor}");
                Console.WriteLine($"Destino: {listaPacotes[].Destino}");
            }
       }
    }
}