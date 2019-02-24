using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendanc_Times
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            int duration_M, Att_M = 8, Leav_M, Leav_H, duration_H, Att_H = 0;
            duration_H = int.Parse(textBox1.Text);
            duration_M = int.Parse(textBox2.Text);
            if(textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter a valied data","Notification");
                textBox3.Focus();
            }
            else
            {
                if(int.Parse(textBox3.Text) < 24 || int.Parse(textBox4.Text) < 60)
                {
                   Att_H = int.Parse(textBox3.Text);
                   Att_M = int.Parse(textBox4.Text);
                 }
                else
                {
                    MessageBox.Show("Please enter a valied data", "Notification");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox3.Focus();
                }
    }

            Leav_H = duration_H + Att_H;
            if(Att_H >= 8)
            {
                if(Att_H >= 9 & Att_M >= 30) {
                    Leav_H = 6;
                    Leav_M = 00;
                }
                else
                {
                    if(Leav_H > 12)
                        Leav_H -= 12;
                    Leav_M = duration_M + Att_M;
                    if(Leav_M >= 60)
                    {
                        Leav_M -= 60;
                        Leav_H += 1;
                    }
                }
            }
            else {
                Leav_H = 4;
                Leav_M = 30;
            } if(textBox3.Text == "" || textBox4.Text == "")
            {
            textBox3.Focus();
                textBox5.Text = "0";
                textBox6.Text = "0";
            }
            else
            {
                textBox5.Text = Leav_H.ToString();
                textBox6.Text = Leav_M.ToString();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
        }

        }
}
