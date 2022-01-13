using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        int m, s, ms;

        private void button2_Click(object sender, EventArgs e)
        {
            m = 0;
            s = 0;
            ms = 0;
            label1.Text = "00";
            label3.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label2.Visible)
            {
                if (s < 59)
                {
                    s++; //каждый раз увеличивается на единицу

                    if (s < 10)
                        label3.Text = "0" + s.ToString();
                    else
                        label3.Text = s.ToString();
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        if (m < 10)
                            label1.Text = "0" + m.ToString();
                        else

                            label1.Text = m.ToString();
                        s = 0;
                        label3.Text = "00";

                    }
                    else
                    {
                        m = 0;
                        label1.Text = "00";
                    }
                }
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "start";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "stop";
                button2.Enabled = false;
            }
        }
        
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 500;
            m = 0;
            s = 0;
            ms = 0;

            label1.Text = "00";
            label3.Text = "00";
            label2.Visible = true;
        }
    }
}
