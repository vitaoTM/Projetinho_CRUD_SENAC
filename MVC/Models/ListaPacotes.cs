using System.Collections.Generic;

namespace MVC.Models
{
    public class ListaPacotes
    {
       List<Pacotes> ListaPacotes = new List<Pacotes>();

       public void Adicionar(Pacotes pacoteNovo)
       {
            ListaPacotes.Add(pacoteNovo);
       } 
    }
}