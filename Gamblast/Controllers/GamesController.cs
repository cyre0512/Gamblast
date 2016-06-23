using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gamblast.Models;
using Gamblast.ViewModels;

namespace Gamblast.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Random()
        {
            var game = new Game() { Name = "World of Warcraft!" };

            var players = new List<Player>
            {
                new Player { Name = "Player 1" },
                new Player { Name = "Player 2" }
            };

            var viewModel = new RandomGameViewModel
            {
                Game = game,
                Players = players
            };
              return View(viewModel);
           
        }


    }

}