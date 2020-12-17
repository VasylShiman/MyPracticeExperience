using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobAndJoe
{
    [Serializable]
    class Guy
    {
        public string Name;
        public int Cash;
            public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("У меня не хватает денег " + amount, Name + "Говорит...");
                return 0;
            }
        }
            public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + "Мне не нужно", Name + "Говорит...");
                return 0;
            }
        }
    }
}
