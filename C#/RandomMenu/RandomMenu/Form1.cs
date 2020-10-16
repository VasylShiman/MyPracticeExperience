using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMenu
{
    public partial class Form1 : Form
    {       Elephant lucinda;
            Elephant lloyd;
        public Form1()
        {
            
            InitializeComponent();
            lucinda = new Elephant { Name = "Lucinda" };
            lloyd = new Elephant { Name = "Lloyd" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi",lucinda);
            lloyd.SpeakTo(lucinda, "Hello");
        }
    }
}
