using AutoService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private Manager MainManeger;

        private void Main_Load(object sender, EventArgs e)
        {
            MainManeger = new Manager(ActionsLog_TB, LinQ_TB)
            {
                Chance = Convert.ToInt32(NumOne.Value),
                CountAuto = Convert.ToInt32(NumTwo.Value)
            };

            MainManeger.AddOueue(new QueueCar(0, Queue_ListBox_1, Queue_prior_ListBox_1));
            MainManeger.AddOueue(new QueueCar(1, Queue_ListBox_2, Queue_prior_ListBox_2));
            MainManeger.AddOueue(new QueueCar(2, Queue_ListBox_3, Queue_prior_ListBox_3));
            MainManeger.AddOueue(new QueueCar(3, Queue_ListBox_4, Queue_prior_ListBox_4));

            MainManeger.AddService(new PlaceService(0, Wash_TB, 1));
            MainManeger.AddService(new PlaceService(1, Well_TB, 1));
            MainManeger.AddService(new PlaceService(2, Fluid_change_TB, 1));
            MainManeger.AddService(new PlaceService(3, Check_Electron_TB, 1));
        }

        private void Timer_T_Tick(object sender, EventArgs e)
        {
            MainManeger.OnTimer();
        }

        private void Do_Step_Click(object sender, EventArgs eventArgs)
        {
            Timer_T_Tick(this, eventArgs);
        }

        private void SetMode(object sender, EventArgs eventArgs)
        {
            Do_Step.Enabled = RB_Hand.Checked;
            Timer_T.Enabled = RB_Auto.Checked;
            Two_Group.Enabled = RB_Hand.Checked;
        }

        private void Two_Group_Click(object sender, EventArgs e)
        {
            MainManeger.SetStatService();
        }

        private void RB_Hand_CheckedChanged(object sender, EventArgs e)
        {
            Timer_T.Stop();

            Do_Step.Enabled = true;
        }

        private void RB_Auto_CheckedChanged(object sender, EventArgs e)
        {
            Timer_T.Start();

            Do_Step.Enabled = !RB_Auto.Checked;

        }

        private void NumOne_ValueChanged(object sender, EventArgs e)
        {
            MainManeger.Chance = Convert.ToInt32(NumOne.Value);
        }

        private void NumTwo_ValueChanged(object sender, EventArgs e)
        {
            MainManeger.CountAuto = Convert.ToInt32(NumTwo.Value);
        }
    }
}
