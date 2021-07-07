using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label4.Text = "3";
            this.button2.Visible = true;
            this.button3.Visible = false;
            this.label5.Text = "5";
            this.button4.Visible = true;
            this.button5.Visible = false;
            this.label6.Text = "7";
            this.button6.Visible = true;
            this.button7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label4.Text=(Convert.ToInt32(this.label4.Text.ToString())-Convert.ToInt32(this.comboBox1.Text.ToString())).ToString();
            if(Convert.ToInt32(this.label4.Text.ToString()) == 0 && Convert.ToInt32(this.label5.Text.ToString()) == 0 && Convert.ToInt32(this.label6.Text.ToString()) == 0)
            {
                MessageBox.Show("甲输");
            }
            this.button2.Visible = false;
            if (Convert.ToInt32(this.label4.Text.ToString()) > 0)
            {
                this.button3.Visible = true;
            }
            this.button4.Visible = false;
            if (Convert.ToInt32(this.label5.Text.ToString()) > 0)
            {
                this.button5.Visible = true;
            }
            this.button6.Visible = false;
            if (Convert.ToInt32(this.label6.Text.ToString()) > 0)
            {
                this.button7.Visible = true;
            }
            this.comboBox1.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label4.Text = (Convert.ToInt32(this.label4.Text.ToString()) - Convert.ToInt32(this.comboBox1.Text.ToString())).ToString();
            if (Convert.ToInt32(this.label4.Text.ToString()) == 0 && Convert.ToInt32(this.label5.Text.ToString()) == 0 && Convert.ToInt32(this.label6.Text.ToString()) == 0)
            {
                MessageBox.Show("乙输");
            }
            if (Convert.ToInt32(this.label4.Text.ToString()) > 0)
            {
                this.button2.Visible = true;
            }
            this.button3.Visible = false;
            if (Convert.ToInt32(this.label5.Text.ToString()) > 0)
            {
                this.button4.Visible = true;
            }
            this.button5.Visible = false;
            if (Convert.ToInt32(this.label6.Text.ToString()) > 0)
            {
                this.button6.Visible = true;
            }
            this.button7.Visible = false;
            this.comboBox1.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label5.Text = (Convert.ToInt32(this.label5.Text.ToString()) - Convert.ToInt32(this.comboBox2.Text.ToString())).ToString();
            if (Convert.ToInt32(this.label4.Text.ToString()) == 0 && Convert.ToInt32(this.label5.Text.ToString()) == 0 && Convert.ToInt32(this.label6.Text.ToString()) == 0)
            {
                MessageBox.Show("甲输");
            }
            this.button4.Visible = false;
            if (Convert.ToInt32(this.label5.Text.ToString()) > 0)
            {
                this.button5.Visible = true;
            }
            this.button2.Visible = false;
            if (Convert.ToInt32(this.label4.Text.ToString()) > 0)
            {
                this.button3.Visible = true;
            }
            this.button6.Visible = false;
            if (Convert.ToInt32(this.label6.Text.ToString()) > 0)
            {
                this.button7.Visible = true;
            }
            this.comboBox2.Text = "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label5.Text = (Convert.ToInt32(this.label5.Text.ToString()) - Convert.ToInt32(this.comboBox2.Text.ToString())).ToString();
            if (Convert.ToInt32(this.label4.Text.ToString()) == 0 && Convert.ToInt32(this.label5.Text.ToString()) == 0 && Convert.ToInt32(this.label6.Text.ToString()) == 0)
            {
                MessageBox.Show("乙输");
            }
            if (Convert.ToInt32(this.label5.Text.ToString()) > 0)
            {
                this.button4.Visible = true;
            }
            this.button5.Visible = false;
            if (Convert.ToInt32(this.label4.Text.ToString()) > 0)
            {
                this.button2.Visible = true;
            }
            this.button3.Visible = false;
            if (Convert.ToInt32(this.label6.Text.ToString()) > 0)
            {
                this.button6.Visible = true;
            }
            this.button7.Visible = false;
            this.comboBox2.Text = "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label6.Text = (Convert.ToInt32(this.label6.Text.ToString()) - Convert.ToInt32(this.comboBox3.Text.ToString())).ToString();
            if (Convert.ToInt32(this.label4.Text.ToString()) == 0 && Convert.ToInt32(this.label5.Text.ToString()) == 0 && Convert.ToInt32(this.label6.Text.ToString()) == 0)
            {
                MessageBox.Show("甲输");
            }
            this.button6.Visible = false;
            if (Convert.ToInt32(this.label6.Text.ToString()) > 0)
            { 
                this.button7.Visible = true;
            }
            this.button2.Visible = false;
            if (Convert.ToInt32(this.label4.Text.ToString()) > 0)
            {
                this.button3.Visible = true;
            }
            this.button4.Visible = false;
            if (Convert.ToInt32(this.label5.Text.ToString()) > 0)
            {
                this.button5.Visible = true;
            }
            this.comboBox3.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label6.Text = (Convert.ToInt32(this.label6.Text.ToString()) - Convert.ToInt32(this.comboBox3.Text.ToString())).ToString();
            if (Convert.ToInt32(this.label4.Text.ToString()) == 0 && Convert.ToInt32(this.label5.Text.ToString()) == 0 && Convert.ToInt32(this.label6.Text.ToString()) == 0)
            {
                MessageBox.Show("乙输");
            }
            if (Convert.ToInt32(this.label6.Text.ToString()) > 0)
            {
                this.button6.Visible = true;
            }
            this.button7.Visible = false;
            if (Convert.ToInt32(this.label4.Text.ToString()) > 0)
            {
                this.button2.Visible = true;
            }
            this.button3.Visible = false;
            if (Convert.ToInt32(this.label5.Text.ToString()) > 0)
            {
                this.button4.Visible = true;
            }
            this.button5.Visible = false;
            this.comboBox3.Text = "1";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.comboBox1.Text.ToString())> Convert.ToInt32(this.label4.Text.ToString()))
            {
                this.comboBox1.Text = "1";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.comboBox2.Text.ToString()) > Convert.ToInt32(this.label5.Text.ToString()))
            {
                this.comboBox2.Text = "1";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.comboBox3.Text.ToString()) > Convert.ToInt32(this.label6.Text.ToString()))
            {
                this.comboBox3.Text = "1";
            }
        }
    }
}
