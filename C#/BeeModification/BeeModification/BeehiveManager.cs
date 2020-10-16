using BeeModification.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeModification
{
    public partial class BeehiveManager : Form
    {
        private Queen queen;

        public BeehiveManager()
        {

            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            
            Worker[] workers = new Worker[4];
            
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" },149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers,275);

            IWorker[] bees = new IWorker[3];

            bees[0] = new NectarStinger();

            bees[1] = new RoboBee();

            bees[2] = new Worker();

            for (int i = 0; i < bees.Length; i++)
            {
                if (bees[i] is INectarCollector)
                {
                    INectarCollector thisCollector;

                    thisCollector = bees[i] as INectarCollector;

                    thisCollector.GatherNectar();
                }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if(queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show($"Для этой работы рабочих нету {workerBeeJob.Text}, Матка говорит");
            }
            else
            {
                MessageBox.Show($"Задание {workerBeeJob.Text} будет закончено через {shifts.Value} , Матка говорит");
            }
        }

        

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
