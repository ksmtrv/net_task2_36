using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace net_task2_36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                textBox3.Clear();   
                string s = textBox1.Text;
                using (StreamReader stream = new StreamReader(s + ".txt"))
                {
                    while (!stream.EndOfStream)                                                      
                    {
                        string line = stream.ReadLine();
                        textBox2.Text += line + "\r\n";
                    }
                }
                button2.Enabled = true;

            } catch {
                MessageBox.Show("Код ошибки: -1");
                button2.Enabled= false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            try {
                int i = 0;
                using (StreamReader r = new StreamReader(s + ".txt"))
                {
                    while (r.ReadLine() != null)
                    {
                        i++;
                    }
                }
                textBox3.Text = Convert.ToString(i);
            } catch {
                MessageBox.Show("Код ошибки: -1");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
