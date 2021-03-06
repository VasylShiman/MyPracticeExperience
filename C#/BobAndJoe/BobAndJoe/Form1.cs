﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BobAndJoe
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " имеет $" + joe.Cash;
            bobCashLabel.Text = bob.Name + " имеет $" + bob.Cash;
            bankCashLabel.Text = "В банке сейчас $" + bank;
        }
        public Form1()
        {
            InitializeComponent();
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;
            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
            UpdateForm();
        }

        private void giveToJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else MessageBox.Show("В банке нет денег.");
        }

        private void receiveFromBob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGiveBob_Click(object sender, EventArgs e)
        {
            bob.Cash += joe.GiveCash(10);
            UpdateForm();
        }

        private void bobGiveJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }

        private void saveJoe_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Guy_file.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void loadJoe_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Guy_file.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}
