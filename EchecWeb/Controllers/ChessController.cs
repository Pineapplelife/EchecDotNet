using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fr.Coding.ChessMate;
using Newtonsoft.Json;

namespace EchecWeb.Controllers
{
    [Route("partie")]
    public class ChessController : Controller
    {

        [Route("plateau")]
        public IActionResult Index()
        {
            Partie game = new Partie();
            ViewData.Add("plateau", game.plateau.echiquier);
            //string seria = JsonConvert.SerializeObject(game.plateau.echiquier);
            
            return View();
        }

    }
}