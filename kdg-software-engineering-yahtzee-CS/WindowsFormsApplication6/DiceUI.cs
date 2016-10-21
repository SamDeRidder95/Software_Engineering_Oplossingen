using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class DiceUI : UserControl
    {
        private DiceController controller;

        public DiceUI( DiceController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newValue = this.controller.throwDice();
            this.teerlingValue1.Text = newValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int newValue = this.controller.throwDice();
            this.teerlingValue2.Text = newValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int newValue = this.controller.throwDice();
            this.teerlingValue3.Text = newValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int newValue = this.controller.throwDice();
            this.teerlingValue4.Text = newValue.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int newValue = this.controller.throwDice();
            this.teerlingValue5.Text = newValue.ToString();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            int newValue = this.controller.throwDice();
            this.teerlingValue1.Text = newValue.ToString();
            newValue = this.controller.throwDice();
            this.teerlingValue2.Text = newValue.ToString();
            newValue = this.controller.throwDice();
            this.teerlingValue3.Text = newValue.ToString();
            newValue = this.controller.throwDice();
            this.teerlingValue4.Text = newValue.ToString();
            newValue = this.controller.throwDice();
            this.teerlingValue5.Text = newValue.ToString();
            this.buttonAll.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
        }

        private void DiceUI_Load(object sender, EventArgs e)
        {

        }

        private void Aces_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
