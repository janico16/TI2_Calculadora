﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Inicializar o código da ViewBag
            ViewBag.Resposta = 0;
            return View();
        }

        // POST: Home
        [HttpPost]
        public ActionResult Index(string visor, string bt)
        {
            //vars.auxiliares
            string resposta = visor;
            //Avaliar o valor do botão que foi carregado
            switch (bt) {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    //determinar se o visor começa com 'zero'
                    if (resposta == "0")  //resposta.Equals(0)
                    {
                        resposta = bt;
                    }
                    else {
                        resposta += bt;
                    }

                    break;
            }
            //devolver a resposta para o  visor
            ViewBag.Resposta = resposta;
            return View();
        }
    }
}