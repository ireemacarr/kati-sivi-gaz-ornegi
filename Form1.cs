using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            k = Convert.ToInt32(textBox1.Text);
           
            if(k<0)
            { label2.Text = "katı"; }
            else if(k>=0 && k<=100)
                        { label2.Text = "sıvı"; }
            else
            {
                label2.Text = "gaz";
                    }
        }
        
    }
}
