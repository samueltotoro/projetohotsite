﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;
using MySql.Data.MySqlClient;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            try
            {
            DatabaseService dbs = new DatabaseService();
            dbs.CadastraInteresse(cad);
            return Json(new{StatusCode="Ok",mensagem="Gravado com sucesso!"});
            }catch(Exception e)
            {
                _logger.LogError("Erro: " + e.Message);
                return Json(new {status="ERRO",mensagem="Falha ao gravar os dados, realize a ação mais tarde!"});
            }

        }

    }
}
