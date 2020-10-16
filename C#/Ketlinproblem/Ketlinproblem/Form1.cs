using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketlinproblem
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox2.Checked, fancyBox.Checked) ;
           
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numericUpDownBirthday.Value, FancyBirthday.Checked, cakeWritingBirth.Text);
            DisplayBirthdayPartyCost();
            
        }
        

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.Healthyoption = checkBox2.Checked;
            DisplayDinnerPartyCost();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
          
            
            
        }
            private void DisplayDinnerPartyCost() { 
            decimal Cost = dinnerParty.Cost;
            label5.Text = Cost.ToString("c");
            
        }

        private void numericUpDownBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBirthday.Value;
            DisplayBirthdayPartyCost();
            
        }

        private void FancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = FancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWritingBirth_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWritingBirth.Text;
            DisplayBirthdayPartyCost();
        }
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            costBirthday.Text = cost.ToString("c");
            
        }

        
    }
    
}
