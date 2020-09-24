using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greyhound
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public string GetDescription()
        {
            string message = $"{Bettor.Name} bets {Amount} on dog #{Dog}";
            return message;
        }
        public int PayOut(int winner)
        {
            if (Dog == winner)
            {
                return Amount * 2;
            }
            return -Amount;
        }
    }

}
