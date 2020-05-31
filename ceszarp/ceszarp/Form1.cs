using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceszarp
{
    public partial class Form1 : Form
    {
        public float x = 0;
        public float y = 0;
        private float wielk=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            button1.Location= new Point(ClientSize.Width / 2, ClientSize.Height - 30);
            Graphics g = this.CreateGraphics();
            float size = ClientSize.Width / 2;
            float[] koniec_kordy = new float[2];
            float[] koniec_kordy2 = new float[2];
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;
            koniec_kordy = sek_kordy(wielk, wielk);
            //koniec_kordy2 = sek_kordy(wielk/2, wielk/2);
            //Point srod = new Pofloat(ClientSize.Width / 2, ClientSize.Height / 2);
            wielk += 0.1f;
            SolidBrush blueBrush = new SolidBrush(Color.White);
            //Pen p = new Pen(Color.Black, 1f);
            //Pen p2 = new Pen(Color.White, 1f);
            //Rectangle rect = new Rectangle(x, y, koniec_kordy[0], koniec_kordy[1]);
            //g.DrawLine(p, srod, new Pofloat(koniec_kordy[0], koniec_kordy[1]));
            //g.DrawLine(p2, srod, new Pofloat(koniec_kordy2[0], koniec_kordy2[1]));
            //Rectangle rect = new Rectangle(koniec_kordy[0], koniec_kordy[1], koniec_kordy[0], koniec_kordy[1]);
            // Draw ellipse to screen.
            //g.DrawEllipse(p, rect);
            //g.DrawRectangle(p, rect);
            g.FillRectangle(blueBrush, koniec_kordy[0], koniec_kordy[1], 2, 2);
            //g.FillRectangle(blueBrush, rect);
        }

        private float[] sek_kordy(float val, float dl)
        {
            float[] kordy = new float[2];
            val *=3;

            if (val >= 0 && val <= 180)
            {
                kordy[0] = x + (float)(dl * Math.Sin(Math.PI * val / 180));
                kordy[1] = y - (float)(dl * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                kordy[0] = x - (float)(dl * -Math.Sin(Math.PI * val / 180));
                kordy[1] = y - (float)(dl * Math.Cos(Math.PI * val / 180));
            }
            return kordy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(ClientSize.Width / 2, ClientSize.Height - 30);
        }
    }
}
