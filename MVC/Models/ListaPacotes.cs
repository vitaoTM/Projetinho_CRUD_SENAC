using System.Collections.Generic;
using System;

// Referente a Dados

namespace MVC.Models
{
    public class ListaPacotes
    {
       List<Pacotes> ListaPacotes = new List<Pacotes>();

        public void Adicionar(Pacotes pacoteNovo)
        {
            ListaPacotes.Add(pacoteNovo);
        } 
        public static List<ClasseAgendar> Total()
    
        {
            return dados;
        }
       
    }
}