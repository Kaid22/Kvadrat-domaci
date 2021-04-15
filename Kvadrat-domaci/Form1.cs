using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvadrat_domaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color boja=Color.Black;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.ShowDialog();
            boja = MyDialog.Color;
            pictureBox1.BackColor = boja;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = boja;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Kvadrat k = new Kvadrat();
            if (radioButton1.Checked)
            {
                k.Postavi(e.X, e.Y, int.Parse(textBox1.Text), boja);
            }  
            else if (radioButton2.Checked)
            {
                k.Postavi(e.X, e.Y, 20, boja);
            }
            else if (radioButton3.Checked)
            {
                k.Postavi(e.X, e.Y, int.Parse(textBox1.Text),Color.Red);
            }
            Graphics g = CreateGraphics();
            k.Crtaj(g);
        }
    }
}
