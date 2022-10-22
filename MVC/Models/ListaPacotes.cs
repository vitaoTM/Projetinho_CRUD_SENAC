using System.Collections.Generic;


// Referente a Dados

namespace MVC.Models
{
    public class ListaPacotes
    {
         private static List<Pacotes> listaPacotes = new List<Pacotes> ();       
 
         public static void Adicionar(Pacotes pacoteNovo)
         {
            listaPacotes.Add(pacoteNovo);
         }
 
         public static List<Pacotes> Total()
         {
             return listaPacotes;
         }
         
     }
 }


