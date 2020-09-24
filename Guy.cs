using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButtom;
        public TextBox MyTextBox;
        public void UpdateTextBox()
        {
            MyTextBox.Text = $"{Name} bets {MyBet.Amount} bucks on dog #{MyBet.Dog+1}";
        }

        public void UpdateRadioButton()
        {
            MyRadioButtom.Text = $"{Name} has {Cash} bucks";
        }
        public void ClearBet()
        {
            MyBet = null;
        }
        public bool PlaceBet(int amount, int dog)
        {
            if (Cash < amount) return false;

            Cash = Cash - amount; // 手上的 Cash 會變成原本的錢 - 我投注的錢
            MyBet = new Bet()
            {
                Bettor = this,
                Amount = amount,
                Dog = dog
            };
            MyBet.Amount = amount; // 把我想投注的錢放去 MyBet
            MyBet.Dog = dog; // 把我想投注的狗給 MyBet
            UpdateTextBox();
            UpdateRadioButton();
            return true;
        }
        public void Collect(int winnerDog)
        {
            if (MyBet == null) return;
            Cash += MyBet.PayOut(winnerDog);
            UpdateRadioButton();
            ClearBet();
            return;
        }

    }
}

