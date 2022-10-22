using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using MVC.Models;

namespace MVC.Controllers
//listagem
{
    public class PacotesController : Controller
    {
        public IActionResult TestarConexao() {
            ViewBag.mensagem = PacotesDB.TestarConexao();
            return View();
        }

        public IActionResult Cadastro()
        {
            if(HttpContext.Session.GetInt32("id") == null) {
                return RedirectToAction("Login", "Usuario");
            }

            if(HttpContext.Session.GetInt32("tipo") != 1) {
                return RedirectToAction("Privacy", "Home");
            }

            return View();
        }

        
        [HttpPost]
        public IActionResult Cadastro(Pacote novoPacote)
        {
            PacotesDB.Inserir(novoPacote);
            //ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            ViewBag.NomePacote = novoPacote.NomePacote;
            ViewBag.Destinno = novoPacote.Destinno;
            ViewBag.valor = novoPacote.valor;
            ViewBag.Observacao = novoPacote.Observacao;


            return View("Confirmacao");
        }
        
        public IActionResult Listagem()
        {
            List<Pacotes> listaCompleta = PacotesDB.Listar();
            //ViewBag.Total = ListaPacote.Calcular();
            return View(listaCompleta);
        }

        
        public IActionResult Editar(int id) {
            Pacotes pacote = PacotesDB.BuscarPorId(id);
            return View(pacote);
        }

        [HttpPost]
        public IActionResult Editar(Pacotes pacote) {
            PacotesDB.Atualizar(pacote);
            return RedirectToAction("Listagem");
        }

        public IActionResult Remover(int id) {
            PacotesDB.Remover(id);
            return RedirectToAction("Listagem");
        }
    }
}