using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Bitmap buf;
        Pen a = new Pen(Color.FloralWhite, 3);
        Pen Black = new Pen(Color.Black);
        Pen Orange = new Pen(Color.Orange, 5);
        Pen Brown = new Pen(Color.Brown, 5);

        SolidBrush redBrush = new SolidBrush(Color.DarkRed);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush greenBrush = new SolidBrush(Color.LawnGreen);
        int sprite = 0;

        private void drawCloud(int x, int y)
        {
            x -= 50;
            g.FillEllipse(grayBrush, x, y, 50, 50);
            g.FillEllipse(grayBrush, x + 30, y + 5, 50, 50);
            g.FillEllipse(grayBrush, x + 70, y, 50, 50);
            g.FillEllipse(grayBrush, x + 15, y - 20, 50, 50);
            g.FillEllipse(grayBrush, x + 55, y - 15, 50, 50);
        }
        private void drawPict()
        {
            g.Clear(Color.Blue);

            g.DrawRectangle(Orange, 190, 450, 120, 10);//низ
            g.DrawLine(Orange, 240, 450, 240, 90); //правая нога
            g.DrawLine(Orange, 255, 450, 255, 90); //левая нога

            g.DrawLine(Black, 255, 90, 390, 130);//крыша крыши цепь1
            g.DrawLine(Orange, 255, 90, 240, 90);//крыша крыши
            g.DrawLine(Black, 240, 90, 390, 130);//крыша крыши цепь1

            g.DrawLine(Black, 240, 90, 155, 130);
            g.DrawLine(Black, 255, 90, 155, 130);

            g.DrawLine(Orange, 90, 150, 255, 150); //левая нижняя полоска
            g.DrawLine(Orange, 90, 150, 155, 130); //левый угловой
            g.DrawLine(Orange, 155, 130, 390, 130);//крыша
            g.DrawLine(Orange, 470, 150, 255, 150);//правая нижняя
            g.DrawLine(Orange, 390, 130, 470, 150);//правый угловой
            g.DrawRectangle(Orange, 390, 150, 10, 40);//держатель цепи

            g.FillRectangle(greenBrush, -200, 464, 1200, 800);

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
            buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(buf);
                g = pictureBox1.CreateGraphics();

                drawPict();


                timer1.Enabled = true;

            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            drawPict();
            if (sprite == 1)
                {
                g.DrawRectangle(Black, 395, 190, 3, 230);//цепь
                g.DrawRectangle(Brown, 380, 420, 30, 30);//цепь
                sprite = 0;
                }
                else
                {
                g.DrawRectangle(Black, 395, 190, 3, 200);//цепь
                g.DrawRectangle(Brown, 380, 390, 30, 30);//цепь
                sprite = 1;
                }

            
        }

    }

}
