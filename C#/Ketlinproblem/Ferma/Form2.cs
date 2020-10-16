using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferma
{
    public partial class Form2 : Form
    {
        Ferma fermer;
        public Form2()
        {
            InitializeComponent();
            fermer = new Ferma(15,30) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows",fermer.BagsOfFeed, fermer.NumberOfCows);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fermer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fermer.FeedMultiplier = 5;  
        }
    }
}
