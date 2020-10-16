using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMenu
{
    class Elephant
    {
        public string Name;
            public void TellMe(string message,Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }
                public void SpeakTo(Elephant whoToTalkTo,string message)
        {
            whoToTalkTo.TellMe(message,this);
        }
    }
}
