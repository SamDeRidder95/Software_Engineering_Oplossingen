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

        private bool keepDice0 = false;
        private bool keepDice1 = false;
        private bool keepDice2 = false;
        private bool keepDice3 = false;
        private bool keepDice4 = false;

        private int turnToTrow = 3;

        public DiceUI( DiceController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (keepDice0 == true)
            {
                keepDice0 = false;

                this.button0.BackColor = System.Drawing.Color.White;
                this.teerlingValue0.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice0 = true;

                this.button0.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue0.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (keepDice1 == true)
            {
                keepDice1 = false;

                this.button1.BackColor = System.Drawing.Color.White;
                this.teerlingValue1.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice1 = true;

                this.button1.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue1.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (keepDice2 == true)
            {
                keepDice2 = false;

                this.button2.BackColor = System.Drawing.Color.White;
                this.teerlingValue2.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice2 = true;

                this.button2.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue2.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (keepDice3 == true)
            {
                keepDice3 = false;

                this.button3.BackColor = System.Drawing.Color.White;
                this.teerlingValue3.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice3 = true;

                this.button3.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue3.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (keepDice4 == true)
            {
                keepDice4 = false;

                this.button4.BackColor = System.Drawing.Color.White;
                this.teerlingValue4.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice4 = true;

                this.button4.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue4.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            if (turnToTrow > 0)
            {
                int newValue = this.controller.throwDice();

                if (keepDice0 == false)
                {
                    this.teerlingValue0.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button0.Visible = true;
                }
                else
                {
                    this.button0.Visible = false;
                }
                if (keepDice1 == false)
                {
                    this.teerlingValue1.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button1.Visible = true;
                }
                else
                {
                    this.button1.Visible = false;
                }
                if (keepDice2 == false)
                {
                    this.teerlingValue2.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button2.Visible = true;
                }
                else
                {
                    this.button2.Visible = false;
                }
                if (keepDice3 == false)
                {
                    this.teerlingValue3.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button3.Visible = true;
                }
                else
                {
                    this.button3.Visible = false;
                }
                if (keepDice4 == false)
                {
                    this.teerlingValue4.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button4.Visible = true;
                }
                else
                {
                    this.button4.Visible = false;
                }
                this.buttonAll.Text = "werp alle overige teerlingen";
                if (turnToTrow < 2)
                {
                    button0.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;

                    this.teerlingValue0.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue1.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue2.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue3.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue4.BackColor = System.Drawing.Color.Gray;
                }
                turnToTrow--;
            }
        }

        private void DiceUI_Load(object sender, EventArgs e)
        {

        }
    }
}
