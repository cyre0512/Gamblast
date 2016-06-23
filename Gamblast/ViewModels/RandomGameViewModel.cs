using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gamblast.Models;


namespace Gamblast.ViewModels
{
    public class RandomGameViewModel
    {
        public Game Game { get; set; }
        public List<Player> Players { get; set; }
    }
}