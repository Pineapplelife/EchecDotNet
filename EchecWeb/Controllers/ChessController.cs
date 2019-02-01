using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fr.Coding.ChessMate;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace EchecWeb.Controllers
{
    [Route("chess")]
    public class ChessController : Controller
    {
        Partie game = new Partie();
        int[] coords = new int[4];

        [Route("plateau")]
        public IActionResult Index()
        {
            ViewData.Add("echiquier", game.plateau.echiquier);
            //sérialiser la liste des villes :
            string seria = JsonConvert.SerializeObject(coords);
            // stockage de la liste dans la session :
            HttpContext.Session.SetString("listeCoords", seria);

            ViewData.Add("listeCoords", coords);
            return View();
        }

        [Route("plateau/selectStart/{i}/{y}")]
        public IActionResult selectStart(int i, int y)
        {
            // je récupère ma liste dans la session (sous forme de string json):
            string deseria = HttpContext.Session.GetString("listeCoords");
            // je désérialise le json pour reconstiture mon objet :
            List<int> coords = JsonConvert.DeserializeObject<List<int>>(deseria);

            // j'ajoute la nouvelle ville à la liste :
            coords[0] = i;
            coords[1] = y;

            // je réécris dans la session :
            string seria = JsonConvert.SerializeObject(coords);
            HttpContext.Session.SetString("listeCoords", seria);
            Index();
            return View("SelectionEnd");
        }

        [Route("plateau/selectEnd/{i}/{y}")]
        public IActionResult selectEnd(int i, int y)
        {
            // je récupère ma liste dans la session (sous forme de string json):
            string deseria = HttpContext.Session.GetString("listeCoords");
            // je désérialise le json pour reconstiture mon objet :
            List<int> coords = JsonConvert.DeserializeObject<List<int>>(deseria);

            // j'ajoute la nouvelle ville à la liste :
            coords[2] = i;
            coords[3] = y;

            // je réécris dans la session :
            string seria = JsonConvert.SerializeObject(coords);
            HttpContext.Session.SetString("listeCoords", seria);
            Index();
            return View("Index");
        }

    }
}