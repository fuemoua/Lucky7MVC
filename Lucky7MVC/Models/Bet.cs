using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lucky7MVC.Models
{
    public class Bet
    {
        [Required(ErrorMessage = "You must enter an bet amount")]
        public int InitialBet { get; set; }
        public int RTotal { get; set; }
        public int RInitialBet { get; set; }
        public int RTotalRolls { get; set; }
        public int RHighestAmountWon { get; set; }
        public int RDieRollAtHighest { get; set; }
    }
}