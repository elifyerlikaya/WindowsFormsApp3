using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;


namespace WindowsFormsApp3
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            dikdörtgen a = new dikdörtgen();
            a.Boy = 150;
            a.En = 200;
            a.Nokta = new Point(20, 30);

            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(Pens.Blue, a.Nokta.X, a.Nokta.Y, (float)a.En, (float)a.Boy); // 120 en, 100 boy 0,0 ise kordinat sistemini temsil ediyor sol en üst köşe orijin kabul edilir. // dikdörtgen 
            dikdörtgen b = new dikdörtgen();
            b.Boy = 30;
            b.En = 50;
            b.Nokta = new Point(15, 85);
            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawRectangle(Pens.Blue, b.Nokta.X, b.Nokta.Y, (float)b.En, (float)b.Boy);

            Carpısma.DikdörtgenDikdörtgen(a, b);

            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
            }

        }

        private void button2_Click(object sender, EventArgs e) // nokta dikdörtgen çarpışma 
        {
            Point2D a = new Point2D();
            a.X = 40;
            a.Y =50 ;
            SolidBrush firca = new SolidBrush(Color.Red);
            Graphics graphics = this.CreateGraphics();
            graphics.FillEllipse(firca, (float)a.X+4, (float)a.Y+4,4, 4);

            dikdörtgen b = new dikdörtgen();
            b.Nokta = new Point(30, 40);
            b.En = 50;
            b.Boy = 80;
            Graphics graphics1= this.CreateGraphics();
            graphics1.DrawRectangle(Pens.Green, (float)b.Nokta.X, (float)b.Nokta.Y, (float)b.En, (float)b.Boy);

            Carpısma.NoktaDörtgen( a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
            }
        }

        private void button3_Click(object sender, EventArgs e) // nokta çember çarpışma
        {
            Point2D a = new Point2D();
            a.X = 40;
            a.Y = 50;   
            SolidBrush firca = new SolidBrush(Color.Red);
            Graphics graphics = this.CreateGraphics();
            graphics.FillEllipse(firca, (float)a.X + 4, (float)a.Y + 4, 4, 4);

            cember b= new cember();
            b.R = 50;
            b.M = new Point(50, 50);


            Graphics graphics1= this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, b.M.X, b.M.Y, (float)b.R, (float)b.R);
            Carpısma.NoktaCember( a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
            }


        }

        private void button4_Click(object sender, EventArgs e) // dikdörtgen çember
        {
            dikdörtgen a = new dikdörtgen();
            a.Boy = 100;
            a.En = 180;
            a.Nokta = new Point(20, 30);

            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(Pens.Blue, a.Nokta.X, a.Nokta.Y, (float)a.En, (float)a.Boy);

            cember b = new cember();
            b.R = 100;
            b.M = new Point(80, 100);


            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, b.M.X, b.M.Y, (float)b.R, (float)b.R);
            Carpısma.DikdörtgenCember( a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
            }


        }

        private void button5_Click(object sender, EventArgs e) // çember çember
        {
            cember b = new cember();
            b.R = 65;
            b.M = new Point(65, 85);


            Graphics graphics = this.CreateGraphics();
            graphics.DrawEllipse(Pens.Gray, b.M.X, b.M.Y, (float)b.R, (float)b.R);
            cember a = new cember();
            a.R = 100;
            a.M = new Point(80, 100);


            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, a.M.X, a.M.Y, (float)a.R, (float)a.R);
            Carpısma.CemberCember( a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
            }


        }

        private void button6_Click(object sender, EventArgs e) // nokta küre
        {
            Point3D a = new Point3D();
            a.X = 40;
            a.Y = 50;
            SolidBrush firca = new SolidBrush(Color.Red);
            Graphics graphics = this.CreateGraphics();
            graphics.FillEllipse(firca, (float)a.X + 4, (float)a.Y + 4, 4, 4);

            Küre b = new Küre();
            b.M.X = 100;
            b.M.Y = 100;
            b.M.Z = 100;
            b.R = 100;

            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.M.Y, (float)b.R, (float)b.R);

            Graphics graphics2 = this.CreateGraphics();
            graphics2.DrawEllipse(Pens.Gray, (float)b.M.X, 130, (float)b.M.Y, 40);
            Carpısma.KüreNokta(b, a);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
                graphics2.Clear(DefaultBackColor);
            }
        }

        private void button7_Click(object sender, EventArgs e) // dikdörtgen prizma nokta 
        {
            Point3D a = new Point3D();
            a.X = 40;
            a.Y = 50;
            SolidBrush firca4 = new SolidBrush(Color.Red);
            Graphics graphics1 = this.CreateGraphics();
            graphics1.FillEllipse(firca4, (float)a.X + 4, (float)a.Y + 4, 4, 4);

            dikdörtgenprizma b = new dikdörtgenprizma();
            b.Genişlik = 300;
            b.En = 100;
            b.Boy = 80;
            b.Nokta.X = 250;
            b.Nokta.Y = 160;
            b.Nokta.Z = 20;

            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(Pens.Gray, (float)(b.Nokta.X-(b.Genişlik/2)) , (float)(b.Nokta.Y+ (b.Boy / 2)), (float)b.En, (float)b.Boy);

            Graphics graphics2 = this.CreateGraphics();
            graphics2.DrawRectangle(Pens.Gray, (float)(b.Boy+(b.Nokta.Z/4)), (float)(b.Nokta.X-(b.En/4)), (float)b.En, (float)b.Boy);

            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)b.En, (float)(b.Nokta.Y + (b.Boy / 2)), (float)(b.Boy + (b.Nokta.Z / 4)), (float)(b.Nokta.X - (b.En / 4)));

            grafiknesne = this.CreateGraphics();
            Pen firca1 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca1, (float)(b.Nokta.Y + (b.Boy / 2)), (float)(b.Nokta.Y + (b.Boy / 2)), (float)(b.Boy + b.En + (b.Nokta.Z / 4)), (float)(b.Nokta.X - (b.En / 4)));

            Pen firca2 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca2, (float)(b.Nokta.Y + (b.Boy / 2)), (float)(2 *b.En+b.Boy), (float)(b.Boy+b.En+(b.Nokta.Z/4)), 305);

            Pen firca3 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca3, (float)b.En, (float)(2 * b.En + b.Boy), (float)(b.Boy + (b.Nokta.Z / 4)), (float)(b.Genişlik+(b.Nokta.Z/4)));

            Carpısma.DikdörtgenprizmaNokta(b, a);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);
                graphics2.Clear(DefaultBackColor);
            }

        }

        private void button8_Click(object sender, EventArgs e) // silindir nokta
        {
            Point3D a = new Point3D();
            a.X = 40;
            a.Y = 50;
            SolidBrush firca4 = new SolidBrush(Color.Red);
            Graphics graphics1 = this.CreateGraphics();
            graphics1.FillEllipse(firca4, (float)a.X + 4, (float)a.Y + 4, 4, 4);

            silindir b = new silindir();
            b.M.X = 10;
            b.M.Y = 20;
            b.M.Z = 30;
            b.H = 88;
            b.R = 18;

            Graphics graphics = this.CreateGraphics();
            graphics.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.M.X, (float)b.M.Z, (float)b.M.Y);

            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)b.M.X, (float)b.R, (float)b.M.X, (float)b.M.X*10);

            Graphics graphicss = this.CreateGraphics();
            graphicss.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.H, (float)b.M.Z, (float)b.M.Y);

            grafiknesne.DrawLine(firca, (float)(b.M.Y*2), (float)b.R, (float)(b.M.Y * 2), (float)b.M.X * 10);

            Carpısma.SilindirNokta(b, a);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);
                graphicss.Clear(DefaultBackColor);
            }



        }

        private void button9_Click(object sender, EventArgs e) // silindir silindir 
        {
            silindir b = new silindir();
            b.M.X = 10;
            b.M.Y = 20;
            b.M.Z = 30;
            b.H = 88;
            b.R = 18;
            silindir a = new silindir();
            a.M.X = 20;
            a.M.Y = 40;
            a.M.Z = 60;
            a.H = 176;
            a.R = 36;

            Graphics graphics = this.CreateGraphics();
            graphics.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.M.X, (float)b.M.Z, (float)b.M.Y);

            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)b.M.X, (float)b.R, (float)b.M.X, (float)b.M.X * 10);

            Graphics graphicss = this.CreateGraphics();
            graphicss.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.H, (float)b.M.Z, (float)b.M.Y);

            grafiknesne.DrawLine(firca, (float)(b.M.Y * 2), (float)b.R, (float)(b.M.Y * 2), (float)b.M.X * 10);




            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, (float)a.M.X, (float)a.M.X, (float)a.M.Z, (float)a.M.Y);

            System.Drawing.Graphics grafiknesne1;
            grafiknesne1 = this.CreateGraphics();
            Pen firca1 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)a.M.X, (float)a.R, (float)a.M.X, (float)(a.M.X * 5)+5);

            Graphics graphicss1 = this.CreateGraphics();
            graphicss1.DrawEllipse(Pens.Gray, (float)a.M.X, (float)b.H, (float)a.M.Z, (float)a.M.Y);

            grafiknesne1.DrawLine(firca1, (float)(a.M.Y * 2), (float)a.R, (float)(a.M.Y * 2), (float)(a.M.X * 5)+5);

              Carpısma.SilindirSilindir(a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);
                graphicss.Clear(DefaultBackColor);
                grafiknesne1.Clear(DefaultBackColor);
                
            }

        }

        private void button10_Click(object sender, EventArgs e) // küre silindir
        {
            
            silindir a = new silindir();
            a.M.X = 10;
            a.M.Y = 20;
            a.M.Z = 30;
            a.H = 88;
            a.R = 18;

            Graphics graphics = this.CreateGraphics();
            graphics.DrawEllipse(Pens.Gray, (float)a.M.X, (float)a.M.X, (float)a.M.Z, (float)a.M.Y);

            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)a.M.X, (float)a.R, (float)a.M.X, (float)a.M.X * 10);

            Graphics graphicss = this.CreateGraphics();
            graphicss.DrawEllipse(Pens.Gray, (float)a.M.X, (float)a.H, (float)a.M.Z, (float)a.M.Y);

            grafiknesne.DrawLine(firca, (float)(a.M.Y * 2), (float)a.R, (float)(a.M.Y * 2), (float)a.M.X * 10);

            Küre b = new Küre();
            b.M.X = 100;
            b.M.Y = 100;
            b.M.Z = 100;
            b.R = 100;

            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.M.Y, (float)b.R, (float)b.R);

            Graphics graphics2 = this.CreateGraphics();
            graphics2.DrawEllipse(Pens.Gray, (float)b.M.X, 130, (float)b.M.Y, 40);
            Carpısma.SilindirKüre(a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics.Clear(DefaultBackColor);
                graphics2.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);
            }


        }

        private void button11_Click(object sender, EventArgs e) // küre küre
        {
            Küre b = new Küre();
            b.M.X = 100;
            b.M.Y = 100;
            b.M.Z = 100;
            b.R = 100;

            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.M.Y, (float)b.R, (float)b.R);

            Graphics graphics2 = this.CreateGraphics();
            graphics2.DrawEllipse(Pens.Gray, (float)b.M.X, 130, (float)b.M.Y, 40);

            Küre a = new Küre();
            a.M.X = 150;
            a.M.Y = 150;
            a.M.Z = 150;
            a.R = 150;

           
            graphics1.DrawEllipse(Pens.Gray, (float)a.M.X, (float)a.M.Y, (float)a.R, (float)a.R);
            graphics2.DrawEllipse(Pens.Gray, (float)a.M.X, 195, (float)a.M.Y, 60);

            Carpısma.KüreKüre(a, b); 
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics2.Clear(DefaultBackColor);
                
            }


        }

        private void button12_Click(object sender, EventArgs e) // dikdörtgen prizma dikdörtgen prizma
        {
            dikdörtgenprizma b = new dikdörtgenprizma();
            b.Genişlik = 300;
            b.En = 100;
            b.Boy = 80;
            b.Nokta.X = 250;
            b.Nokta.Y = 160;
            b.Nokta.Z = 20;

            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(Pens.Gray, (float)(b.Nokta.X - (b.Genişlik / 2)), (float)(b.Nokta.Y + (b.Boy / 2)), (float)b.En, (float)b.Boy);

            Graphics graphics2 = this.CreateGraphics();
            graphics2.DrawRectangle(Pens.Gray, (float)(b.Boy + (b.Nokta.Z / 4)), (float)(b.Nokta.X - (b.En / 4)), (float)b.En, (float)b.Boy);

            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)b.En, (float)(b.Nokta.Y + (b.Boy / 2)), (float)(b.Boy + (b.Nokta.Z / 4)), (float)(b.Nokta.X - (b.En / 4)));

            grafiknesne = this.CreateGraphics();
            Pen firca1 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca1, (float)(b.Nokta.Y + (b.Boy / 2)), (float)(b.Nokta.Y + (b.Boy / 2)), (float)(b.Boy + b.En + (b.Nokta.Z / 4)), (float)(b.Nokta.X - (b.En / 4)));

            Pen firca2 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca2, (float)(b.Nokta.Y + (b.Boy / 2)), (float)(2 * b.En + b.Boy), (float)(b.Boy + b.En + (b.Nokta.Z / 4)), 305);

            Pen firca3 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca3, (float)b.En, (float)(2 * b.En + b.Boy), (float)(b.Boy + (b.Nokta.Z / 4)), (float)(b.Genişlik + (b.Nokta.Z / 4)));

            dikdörtgenprizma a = new dikdörtgenprizma();
            a.Genişlik = 600;
            a.En = 200;
            a.Boy = 160; 
            a.Nokta.X = 500;
            a.Nokta.Y = 320;
            a.Nokta.Z = 40;

            
            graphics.DrawRectangle(Pens.Gray, (float)(200), (float)(400), (float)200, (float)160);

            
            graphics2.DrawRectangle(Pens.Gray, (float)(170), (float)(450), (float)200, (float)160);
            grafiknesne = this.CreateGraphics();
            grafiknesne.DrawLine(firca, (float)200, (float)400, (float)(170), (float)450);
            grafiknesne = this.CreateGraphics();
            grafiknesne.DrawLine(firca1, (float)(400), (float)(400), (float)(370), (float)(450));
            grafiknesne.DrawLine(firca2, (float)(400), (float)(560), (float)370, 610);
            grafiknesne.DrawLine(firca3, (float)200, (float)(560), (float)(170), (float)610);

            Carpısma.DikdörtgenPrizmaPrizma(a, b);

            if (sayac % 2 == 0)
            {
                graphics.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);
                graphics2.Clear(DefaultBackColor);

            }



        }

        private void button13_Click(object sender, EventArgs e) // yüzey küre
        {

            yüzey a = new yüzey();
            a.En = 20;
            a.Nokta.X = 20;
            a.Nokta.Y = 20;
            a.Nokta.Z= 20;
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca3 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca3, (float)a.Nokta.X, 0, (float)a.Nokta.X, 5000);

            Pen firca4 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca4, (float)(a.Nokta.X+a.En), 0, (float)(a.Nokta.X+a.En), 5000);

            Küre b = new Küre();
            
            b.M.X = 100;
            b.M.Y = 100;
            b.M.Z = 100;
            b.R = 100;

            Graphics graphics1 = this.CreateGraphics();
            graphics1.DrawEllipse(Pens.Gray, (float)b.M.X, (float)b.M.Y, (float)b.R, (float)b.R);

            Graphics graphics2 = this.CreateGraphics();
            graphics2.DrawEllipse(Pens.Gray, (float)b.M.X, 130, (float)b.M.Y, 40);

            Carpısma.YüzeyKüre(a, b);
            if (sayac % 2 == 0)
            {
                graphics1.Clear(DefaultBackColor);
                graphics2.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);

            }

        }

        private void button14_Click(object sender, EventArgs e) // yüzey silindir
        {
            yüzey b= new yüzey();
            b.En = 20;
            b.Nokta.X = 20;
            b.Nokta.Y = 20;
            b.Nokta.Z = 20;
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca3 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca3, (float)b.Nokta.X, 0, (float)b.Nokta.X, 5000);

            Pen firca4 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca4, (float)(b.Nokta.X + b.En), 0, (float)(b.Nokta.X + b.En), 5000);

            silindir a = new silindir();
            a.M.X = 10;
            a.M.Y = 20;
            a.M.Z = 30;
            a.H = 88;
            a.R = 18;

            Graphics graphics = this.CreateGraphics();
            graphics.DrawEllipse(Pens.Gray, (float)a.M.X, (float)a.M.X, (float)a.M.Z, (float)a.M.Y);
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca, (float)a.M.X, (float)a.R, (float)a.M.X, (float)a.M.X * 10);

            Graphics graphicss = this.CreateGraphics();
            graphicss.DrawEllipse(Pens.Gray, (float)a.M.X, (float)a.H, (float)a.M.Z, (float)a.M.Y);


            grafiknesne.DrawLine(firca, (float)(a.M.Y * 2), (float)a.R, (float)(a.M.Y * 2), (float)a.M.X * 10);
            Carpısma.YüzeySilindir(b, a);

            if (sayac % 2 == 0)
            {
                graphics.Clear(DefaultBackColor);
                grafiknesne.Clear(DefaultBackColor);

            }


        }

        private void button15_Click(object sender, EventArgs e) // yüzey dikdörtgen prizma
        {
            yüzey b = new yüzey();
            b.En = 20;
            b.Nokta.X = 20;
            b.Nokta.Y = 20;
            b.Nokta.Z = 20;
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca3 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca3, (float)b.Nokta.X, 0, (float)b.Nokta.X, 5000);

            Pen firca4 = new Pen(System.Drawing.Color.Red, 1);
            grafiknesne.DrawLine(firca4, (float)(b.Nokta.X + b.En), 0, (float)(b.Nokta.X + b.En), 5000);

            dikdörtgenprizma a = new dikdörtgenprizma();
            a.Genişlik = 600;
            a.En = 200;
            a.Boy = 160;
            a.Nokta.X = 500;
            a.Nokta.Y = 320;
            a.Nokta.Z = 40;


            grafiknesne.DrawRectangle(Pens.Gray, (float)(200), (float)(400), (float)200, (float)160);


            grafiknesne.DrawRectangle(Pens.Gray, (float)(170), (float)(450), (float)200, (float)160);
            grafiknesne = this.CreateGraphics();
            grafiknesne.DrawLine(firca3, (float)200, (float)400, (float)(170), (float)450);
            grafiknesne = this.CreateGraphics();
            grafiknesne.DrawLine(firca3, (float)(400), (float)(400), (float)(370), (float)(450));
            grafiknesne.DrawLine(firca3, (float)(400), (float)(560), (float)370, 610);
            grafiknesne.DrawLine(firca3, (float)200, (float)(560), (float)(170), (float)610);

            Carpısma.YüzeyDikdörtgenprizma(b, a);
      

            if (sayac % 2 == 0)
            {
                grafiknesne.Clear(DefaultBackColor);
                
            }



        }
    }
}
public class Point2D
{
    double x, y;
    public Point2D()
    {
        x = 0;   //Default da x ve y'ye sıfır değeri atanır.
        y = 0;
    }
    public Point2D(double X, double Y)
    {
        x = X;
        y = Y;
    }
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }


}
public class Point3D : Point2D
{
    double z;
    public Point3D() : base() // Temel sınıfın ilk kurucu fonksiyonunu çalıştırmaya yarar.
    {
        z = 0;
    }
    public Point3D(double Z, double X, double Y)
    {        z = Z;
    }
    public double Z { get => z; set => z = value; }

}
public class Küre
{
    Point3D m;
    double r;
    public Küre()
    {
        m = new Point3D(0, 0, 0);
        r = 0;
    }
    public Küre(Point3D M, double R)
    {
        m = M;
        r = R;
    }
    public double R
    {
        get => r;
        set => r = value;
    }
    public Point3D M
    {
        get => m;
        set => m = value;
    }
}

public class silindir
{
    Point3D m; double r;
    double h;
    public silindir()
    {
        m = new Point3D();
        r = 0;
        h = 0;
    }

    public silindir(Point3D P, double R, double H)
    {
        m = P;
        r = R;
        h = H;
    }
    public double R
    {
        get => r;
        set => r = value;
    }
    public Point3D M
    {
        get => m;
        set => m = value;
    }
    public double H
    {
        get => h;
        set => h = value;
    }
}
public class cember
{

    Point m; double r;
    public cember()
    {
        m = new Point();
        r = 0;
    }

    public cember(Point P, double R)
    {
        m = P;
        r = R;
    }
    public double R
    {
        get => r;
        set => r = value;
    }
    public Point M
    {
        get => m;
        set => m = value;
    }
}
public class dikdörtgenprizma
{
    Point3D nokta;
    double en;
    double boy;
    double genişlik;

    public dikdörtgenprizma()
    {
        genişlik = 0;
        en = 0;
        boy = 0;
        nokta = new Point3D(0, 0, 0);
    }
    public dikdörtgenprizma(double En, double Boy, Point3D Nokta, double Genişlik)
    {
        genişlik = Genişlik;
        en = En;
        boy = Boy;
        nokta = Nokta;
    }
    public double En
    {
        get => en;
        set => en = value;
    }
    public double Boy
    {
        get => boy;
        set => boy = value;
    }
    public Point3D Nokta
    {
        get => nokta;
        set => nokta = value;
    }
    public double Genişlik
    {
        get => genişlik;
        set => genişlik = value;
    }
}

public class dikdörtgen
{

    Point nokta;
    double en;
    double boy;

    public dikdörtgen()
    {
        en = 0;
        boy = 0;
        nokta = new Point(0, 0);
    }

    public dikdörtgen(double En, double Boy, Point Nokta)
    {
        en = En;
        boy = Boy;
        nokta = Nokta;
    }
    public double En
    {
        get => en;
        set => en = value;
    }
    public double Boy
    {
        get => boy;
        set => boy = value;
    }
    public Point Nokta
    {
        get => nokta;
        set => nokta = value;
    }
}

public class yüzey
{

    Point3D nokta;
    double en;
   

    public yüzey()
    {
        en = 0;
        nokta = new Point3D(0, 0,0);
    }

    public yüzey (double En, Point3D Nokta)
    {
        en = En;
        nokta = Nokta;
    }
    public double En
    {
        get => en;
        set => en = value;
    }
  
    public Point3D Nokta
    {
        get => nokta;
        set => nokta = value;
    }
}




public static class Carpısma
{
   
    public static void NoktaDörtgen(Point2D a, dikdörtgen b)
    {
        double dx = Math.Abs(a.X - b.Nokta.X);
        double dy = Math.Abs(a.Y - b.Nokta.Y);

        if (dx <= b.En / 2 && dy <= b.Boy / 2)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur!");

    }
    public static void NoktaCember(Point2D a, cember b)
    {
        double mesafe = Sqrt((Pow(a.X, 2) - Pow(b.M.X, 2)) + (Pow(a.Y, 2) - Pow(b.M.Y, 2)));

        if (mesafe <= b.R)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur!");
    }
    public static void DikdörtgenDikdörtgen(dikdörtgen a, dikdörtgen b)
    {
      
        double dx = Abs(a.Nokta.X - b.Nokta.X);
        double dy = Abs(b.Nokta.Y - b.Nokta.Y);
        if (dx <= (a.En + b.En) / 2 && dy <= (a.Boy + b.Boy))
         MessageBox.Show("Çarpışma Vardır!");
            
        else
         MessageBox.Show("Çarpışma Yoktur!");


    }
    public static void DikdörtgenCember(dikdörtgen a, cember b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.Nokta.X, 2) - Math.Pow(b.M.X, 2)) + ((Math.Pow(b.M.Y, 2) - Math.Pow(a.Nokta.Y, 2))));
        if (merkezfark < b.R + a.En / 2 && merkezfark < b.R + a.Boy / 2)
            MessageBox.Show("Çarpışma Vardır!");
        else
            MessageBox.Show("Çarpışma Yoktur!");

    }
    public static void CemberCember(cember a, cember b)
    {

        double merkezfark = Math.Sqrt((Math.Pow(a.M.X, 2) - Math.Pow(b.M.X, 2)) + ((Math.Pow(a.M.Y, 2) - Math.Pow(b.M.Y, 2))));
        if (merkezfark < a.R + b.R)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur");

    }
    public static void KüreNokta(Küre a, Point3D b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.M.X, 2) - Math.Pow(b.X, 2)) + (Math.Pow(a.M.Z, 2) - Math.Pow(b.Z, 2)) + ((Math.Pow(a.M.Y, 2) - Math.Pow(b.Y, 2))));

        if (merkezfark < a.R)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur!");
    }
    public static void DikdörtgenprizmaNokta(dikdörtgenprizma a, Point3D b)
    {
        double dx = Abs(a.Nokta.X - b.X);
        double dy = Abs(a.Nokta.Y - b.Y);
        double dz = Abs(a.Nokta.Z - b.Z);
        if (dx <= a.En / 2 && dy <= a.Boy / 2 && dz <= a.Genişlik / 2)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur!");


    }
    public static void SilindirNokta(silindir a, Point3D b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.M.X, 2) - Math.Pow(b.X, 2)) + (Math.Pow(a.M.Z, 2) - Math.Pow(b.Z, 2)) + ((Math.Pow(a.M.Y, 2) - Math.Pow(b.Y, 2))));

        if (merkezfark <= a.H / 2 && merkezfark <= a.R)
            MessageBox.Show("Çarpışma Vardır!");
        else
            MessageBox.Show("Çarpışma Yoktur!");
    }
    public static void SilindirSilindir(silindir a, silindir b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.M.X, 2) - Math.Pow(b.M.X, 2)) + (Math.Pow(a.M.Z, 2) - Math.Pow(b.M.Z, 2)) + ((Math.Pow(a.M.Y, 2) - Math.Pow(b.M.Y, 2))));

        if (merkezfark <= (a.H + b.H) / 2 && merkezfark <= (a.R + b.R) / 2)
            MessageBox.Show("Çarpışma Yoktur");
        else
            MessageBox.Show("Çarpışma Vardır!");

    }
    public static void SilindirKüre(silindir a, Küre b)
    {
        double dx = Math.Abs(a.M.X - b.M.X);
        double dy = Math.Abs(a.M.Y - b.M.Y);
        double dz = Math.Abs(a.M.Z - b.M.Z);

        if (dx <= a.R + b.R && dy <= b.R + (a.H / 2) && dz <= a.R + b.R)
            MessageBox.Show("Çarpışma Yoktur!");
        else
            MessageBox.Show("Çarpışma Vardır!");

    }
    public static void DikdörtgenPrizmaPrizma(dikdörtgenprizma a, dikdörtgenprizma b)
    {
        double dx = Abs(a.Nokta.X - b.Nokta.X);
        double dy = Abs(a.Nokta.Y - b.Nokta.Y);
        double dz = Abs(a.Nokta.Z - b.Nokta.Z);
        if (dx <= (a.En + b.En) / 2 && dy <= (a.Boy + b.Boy) / 2 && dz <= (a.Genişlik + b.Genişlik) / 2)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur!");

    }
    public static void KüreKüre(Küre a, Küre b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.M.X, 2) - Math.Pow(b.M.X, 2)) + (Math.Pow(a.M.Z, 2) - Math.Pow(b.M.Z, 2)) + ((Math.Pow(a.M.Y, 2) - Math.Pow(b.M.Y, 2))));

        if (merkezfark < (a.R + b.R) / 2)
            MessageBox.Show("Çarpışma Yoktur!");

        else
            MessageBox.Show("Çarpışma Vardır!");
    }
    public static void YüzeyKüre(yüzey a, Küre b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.Nokta.X, 2) - Math.Pow(b.M.X, 2)) + (Math.Pow(a.Nokta.Z, 2) - Math.Pow(b.M.Z, 2)) + ((Math.Pow(a.Nokta.Y, 2) - Math.Pow(b.M.Y, 2))));

        if (merkezfark < (a.Nokta.X + b.R) / 2)
            MessageBox.Show("Çarpışma Vardır!");

        else
            MessageBox.Show("Çarpışma Yoktur");
    }
    public static void YüzeySilindir(yüzey a , silindir b)
    {
        double merkezfark = Math.Sqrt((Math.Pow(a.Nokta.X, 2) - Math.Pow(b.M.X, 2)) + (Math.Pow(a.Nokta.Z, 2) - Math.Pow(b.M.Z, 2)) + ((Math.Pow(a.Nokta.Y, 2) - Math.Pow(b.M.Y, 2))));

        if (merkezfark <= (a.En + b.H) / 2 && merkezfark <= (a.En + b.R) / 2)
            MessageBox.Show("Çarpışma Yoktur");
        else
            MessageBox.Show("Çarpışma Vardır!");


    }
    public static void YüzeyDikdörtgenprizma(yüzey a , dikdörtgenprizma b)
    {
        double dx = Abs(a.Nokta.X - b.Nokta.X);
        double dy = Abs(a.Nokta.Y - b.Nokta.Y);
        double dz = Abs(a.Nokta.Z - b.Nokta.Z);
        if (dx <= (a.En + b.En) / 2)
            MessageBox.Show("Çarpışma Vardır!");
       else
            MessageBox.Show("Çarpışma Yoktur!");
    }
}



