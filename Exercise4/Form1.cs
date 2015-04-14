using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }
        bool stop=false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(stop==false)
            {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            textBox3.Text = listBox1.SelectedItem.ToString();
            textBox4.Text = listBox2.SelectedItem.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stop = true;            
            listBox3.Items.Add(listBox1.SelectedItem.ToString());
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
            int delIndex = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(delIndex);
            listBox2.Items.RemoveAt(delIndex);
            stop = false;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(stop==false)
            {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            textBox3.Text = listBox1.SelectedItem.ToString();
            textBox4.Text = listBox2.SelectedItem.ToString();
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop=true;
            listBox1.Items[listBox1.SelectedIndex] = textBox3.Text;
            listBox2.Items[listBox2.SelectedIndex] = textBox4.Text;
            stop=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stop = true;
            listBox1.Items.Add(listBox3.SelectedItem.ToString());
            listBox2.Items.Add(listBox4.SelectedItem.ToString());
            int delIndex = listBox3.SelectedIndex;
            listBox3.Items.RemoveAt(delIndex);
            listBox4.Items.RemoveAt(delIndex);
            stop = false;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stop == false)
            {
                listBox4.SelectedIndex = listBox3.SelectedIndex;                
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stop == false)
            {
                listBox3.SelectedIndex = listBox4.SelectedIndex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
