using LAB2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Nivel2 : Form
    {
        bool right, hold = true;
        static Bitmap bmp;
        static Graphics g;
        private Color originalColor, colorpatrofeo, colorpafantasma;
        private Color colorpafantasma2, colorpafantasma3, colorpafantasma4, colorpafantasma5;


        public object MyResource { get; private set; }
        public Nivel2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
           

            bmp = new Bitmap(250, 250);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pictureBox2.Image = Resources.PACMAN;
            DrawMap();

        }


        
        private void DrawMap()
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Red);

            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (Caster.map0[x, y] != 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), x * 10, y * 10, 10, 10);
                    }
                    else
                        g.DrawRectangle(Pens.Yellow, x * 10, y * 10, 10, 10);
            }
        }

        private void MAIN_FORM_KeyDown(object sender, KeyEventArgs e)
        {
            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Right & hold)
                    {
                        if (pictureBox2.Location.X < bmp.Width - 20)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X + 4, pictureBox2.Location.Y);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = true;
                            hold = false;
                            pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y);
                            if (TROFEO.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.GANASTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA2.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA3.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA4.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA5.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }


                        }




                    }

            }
            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Left & hold)
                    {
                        if (pictureBox2.Location.X >= 0)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X - 4, pictureBox2.Location.Y);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = true;
                            hold = false;
                            pictureBox2.Location = new Point(pictureBox2.Location.X - 2, pictureBox2.Location.Y);
                            if (TROFEO.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.GANASTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA2.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA3.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA4.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA5.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }


                        }



                    }

            }
            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Up & hold)
                    {
                        if (pictureBox2.Location.Y > 2)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X, pictureBox2.Location.Y - 4);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = true;
                            hold = false;
                            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 2);
                            if (TROFEO.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.GANASTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA2.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA3.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA4.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA5.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                           
                        }



                    }

            }

            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Down & hold)
                    {
                        if (pictureBox2.Location.Y < bmp.Height - 15)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X, pictureBox2.Location.Y + 4);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = true;
                            hold = false;
                            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 2);
                            if (TROFEO.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.GANASTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA2.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA3.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA4.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {

                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                            if (FANTASMA5.Bounds.IntersectsWith(pictureBox2.Bounds))
                            {
                                pictureBox1.Image = Resources.PERDISTE;
                                button1.Enabled = true;
                            }
                          
                        }
                        


                    }

            }

        }

        private void MAIN_FORM_KeyUp(object sender, KeyEventArgs e)
        {

            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Right & !hold)
                    {
                        if (pictureBox2.Location.X < bmp.Width - 20)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X, pictureBox2.Location.Y);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = false;
                            hold = true;
                            pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);


                        }



                    }

            }
            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Left & !hold)
                    {
                        if (pictureBox2.Location.X >= 0)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X, pictureBox2.Location.Y);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = false;
                            hold = true;
                            pictureBox2.Location = new Point(pictureBox2.Location.X - 1, pictureBox2.Location.Y);


                        }



                    }

            }
            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Up & !hold)
                    {
                        if (pictureBox2.Location.Y > 2)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X, pictureBox2.Location.Y);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = false;
                            hold = true;
                            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);


                        }



                    }

            }

            for (int x = 0; x < Caster.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Caster.map0.GetLength(1); y++)
                    if (e.KeyData == Keys.Down & !hold)
                    {
                        if (pictureBox2.Location.Y < bmp.Height - 15)
                            originalColor = bmp.GetPixel(pictureBox2.Location.X, pictureBox2.Location.Y);
                        if (originalColor.R == 35 && originalColor.G == 35 && originalColor.B == 35)
                        {
                            right = false;
                            hold = true;
                            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 1);

                        }



                    }

            }
        }
        public Random r = new Random();
        private void changetrofeolocation()
        {
            int x = r.Next(0, 250);
            int y = r.Next(0, 250);
            TROFEO.Top = y;
            TROFEO.Left = x;
        }
        private void MoveUp()
        {
            colorpafantasma = bmp.GetPixel(FANTASMA.Location.X, FANTASMA.Location.Y);
            if (colorpafantasma.R == 35 && colorpafantasma.G == 35 && colorpafantasma.B == 35)
            {
                FANTASMA.Location = new Point(FANTASMA.Location.X, FANTASMA.Location.Y - 10);
            }
            else { FANTASMA.Location = new Point(FANTASMA.Location.X, FANTASMA.Location.Y + 10); moveRight(); }
        }
        private void MoveUp2()
        {
            colorpafantasma2 = bmp.GetPixel(FANTASMA2.Location.X, FANTASMA2.Location.Y);
            if (colorpafantasma2.R == 35 && colorpafantasma2.G == 35 && colorpafantasma2.B == 35)
            {
                FANTASMA2.Location = new Point(FANTASMA2.Location.X, FANTASMA2.Location.Y - 10);
            }
            else { FANTASMA2.Location = new Point(FANTASMA2.Location.X, FANTASMA2.Location.Y + 10); MoveRight2(); }
        }
        private void MoveUp3()
        {
            colorpafantasma3 = bmp.GetPixel(FANTASMA3.Location.X, FANTASMA3.Location.Y);
            if (colorpafantasma3.R == 35 && colorpafantasma3.G == 35 && colorpafantasma3.B == 35)
            {
                FANTASMA3.Location = new Point(FANTASMA3.Location.X, FANTASMA3.Location.Y - 10);
            }
            else { FANTASMA3.Location = new Point(FANTASMA3.Location.X, FANTASMA3.Location.Y + 10); MoveRight3(); }
        }
        private void MoveUp4()
        {
            colorpafantasma4 = bmp.GetPixel(FANTASMA4.Location.X, FANTASMA4.Location.Y);
            if (colorpafantasma4.R == 35 && colorpafantasma4.G == 35 && colorpafantasma4.B == 35)
            {
                FANTASMA4.Location = new Point(FANTASMA4.Location.X, FANTASMA4.Location.Y - 10);
            }
            else { FANTASMA4.Location = new Point(FANTASMA4.Location.X, FANTASMA4.Location.Y + 10); MoveRight4(); }
        }
        private void MoveUp5()
        {
            colorpafantasma5 = bmp.GetPixel(FANTASMA5.Location.X, FANTASMA5.Location.Y);
            if (colorpafantasma5.R == 35 && colorpafantasma5.G == 35 && colorpafantasma5.B == 35)
            {
                FANTASMA5.Location = new Point(FANTASMA5.Location.X, FANTASMA5.Location.Y - 10);
            }
            else { FANTASMA5.Location = new Point(FANTASMA5.Location.X, FANTASMA5.Location.Y + 10); MoveRight5(); }
        }
        private void moveRight()
        {
            colorpafantasma = bmp.GetPixel(FANTASMA.Location.X, FANTASMA.Location.Y);
            if (colorpafantasma.R == 35 && colorpafantasma.G == 35 && colorpafantasma.B == 35)
            {
                FANTASMA.Location = new Point(FANTASMA.Location.X + 10, FANTASMA.Location.Y);
            }
            else { FANTASMA.Location = new Point(FANTASMA.Location.X - 10, FANTASMA.Location.Y); MoveDown(); }
        }
        private void MoveRight2()
        {
            colorpafantasma2 = bmp.GetPixel(FANTASMA2.Location.X, FANTASMA2.Location.Y);
            if (colorpafantasma2.R == 35 && colorpafantasma2.G == 35 && colorpafantasma2.B == 35)
            {
                FANTASMA2.Location = new Point(FANTASMA2.Location.X + 10, FANTASMA2.Location.Y);
            }
            else { FANTASMA2.Location = new Point(FANTASMA2.Location.X - 10, FANTASMA2.Location.Y); MoveDown2(); }
        }
        private void MoveRight3()
        {
            colorpafantasma3 = bmp.GetPixel(FANTASMA3.Location.X, FANTASMA3.Location.Y);
            if (colorpafantasma3.R == 35 && colorpafantasma3.G == 35 && colorpafantasma3.B == 35)
            {
                FANTASMA3.Location = new Point(FANTASMA3.Location.X + 10, FANTASMA3.Location.Y);
            }
            else { FANTASMA3.Location = new Point(FANTASMA3.Location.X - 10, FANTASMA3.Location.Y); MoveDown3(); }
        }
        private void MoveRight4()
        {
            colorpafantasma4 = bmp.GetPixel(FANTASMA4.Location.X, FANTASMA4.Location.Y);
            if (colorpafantasma4.R == 35 && colorpafantasma4.G == 35 && colorpafantasma4.B == 35)
            {
                FANTASMA4.Location = new Point(FANTASMA4.Location.X + 10, FANTASMA4.Location.Y);
            }
            else { FANTASMA4.Location = new Point(FANTASMA4.Location.X - 10, FANTASMA4.Location.Y); MoveDown4(); }
        }
        private void MoveRight5()
        {
            colorpafantasma5 = bmp.GetPixel(FANTASMA5.Location.X, FANTASMA5.Location.Y);
            if (colorpafantasma5.R == 35 && colorpafantasma5.G == 35 && colorpafantasma5.B == 35)
            {
                FANTASMA5.Location = new Point(FANTASMA5.Location.X + 10, FANTASMA5.Location.Y);
            }
            else { FANTASMA5.Location = new Point(FANTASMA5.Location.X - 10, FANTASMA5.Location.Y); MoveDown5(); }
        }
        private void MoveLeft()
        {
            colorpafantasma = bmp.GetPixel(FANTASMA.Location.X, FANTASMA.Location.Y);
            if (colorpafantasma.R == 35 && colorpafantasma.G == 35 && colorpafantasma.B == 35)
            {
                FANTASMA.Location = new Point(FANTASMA.Location.X - 10, FANTASMA.Location.Y);
            }
            else { FANTASMA.Location = new Point(FANTASMA.Location.X + 10, FANTASMA.Location.Y); MoveUp(); }
        }
        private void MoveLeft2()
        {
            colorpafantasma2 = bmp.GetPixel(FANTASMA2.Location.X, FANTASMA2.Location.Y);
            if (colorpafantasma2.R == 35 && colorpafantasma2.G == 35 && colorpafantasma2.B == 35)
            {
                FANTASMA2.Location = new Point(FANTASMA2.Location.X - 10, FANTASMA2.Location.Y);
            }
            else { FANTASMA2.Location = new Point(FANTASMA2.Location.X + 10, FANTASMA2.Location.Y); MoveUp2(); }
        }
        private void MoveLeft3()
        {
            colorpafantasma3 = bmp.GetPixel(FANTASMA3.Location.X, FANTASMA3.Location.Y);
            if (colorpafantasma3.R == 35 && colorpafantasma3.G == 35 && colorpafantasma3.B == 35)
            {
                FANTASMA3.Location = new Point(FANTASMA3.Location.X - 10, FANTASMA3.Location.Y);
            }
            else { FANTASMA3.Location = new Point(FANTASMA3.Location.X + 10, FANTASMA3.Location.Y); MoveUp3(); }
        }
        private void MoveLeft4()
        {
            colorpafantasma4 = bmp.GetPixel(FANTASMA4.Location.X, FANTASMA4.Location.Y);
            if (colorpafantasma4.R == 35 && colorpafantasma4.G == 35 && colorpafantasma4.B == 35)
            {
                FANTASMA4.Location = new Point(FANTASMA4.Location.X - 10, FANTASMA4.Location.Y);
            }
            else { FANTASMA4.Location = new Point(FANTASMA4.Location.X + 10, FANTASMA4.Location.Y); MoveUp4(); }
        }
        private void MoveLeft5()
        {
            colorpafantasma5 = bmp.GetPixel(FANTASMA5.Location.X, FANTASMA5.Location.Y);
            if (colorpafantasma5.R == 35 && colorpafantasma5.G == 35 && colorpafantasma5.B == 35)
            {
                FANTASMA5.Location = new Point(FANTASMA5.Location.X - 10, FANTASMA5.Location.Y);
            }
            else { FANTASMA5.Location = new Point(FANTASMA5.Location.X + 10, FANTASMA5.Location.Y); MoveUp5(); }
        }
        private void MoveDown()
        {
            colorpafantasma = bmp.GetPixel(FANTASMA.Location.X, FANTASMA.Location.Y);
            if (colorpafantasma.R == 35 && colorpafantasma.G == 35 && colorpafantasma.B == 35)
            {
                FANTASMA.Location = new Point(FANTASMA.Location.X, FANTASMA.Location.Y + 10);
            }
            else { FANTASMA.Location = new Point(FANTASMA.Location.X, FANTASMA.Location.Y - 10); MoveLeft(); }
        }
        private void MoveDown2()
        {
            colorpafantasma2 = bmp.GetPixel(FANTASMA2.Location.X, FANTASMA2.Location.Y);
            if (colorpafantasma2.R == 35 && colorpafantasma2.G == 35 && colorpafantasma2.B == 35)
            {
                FANTASMA2.Location = new Point(FANTASMA2.Location.X, FANTASMA2.Location.Y + 10);
            }
            else { FANTASMA2.Location = new Point(FANTASMA2.Location.X, FANTASMA2.Location.Y - 10); MoveLeft2(); }
        }
        private void MoveDown3()
        {
            colorpafantasma3 = bmp.GetPixel(FANTASMA3.Location.X, FANTASMA3.Location.Y);
            if (colorpafantasma3.R == 35 && colorpafantasma3.G == 35 && colorpafantasma3.B == 35)
            {
                FANTASMA3.Location = new Point(FANTASMA3.Location.X, FANTASMA3.Location.Y + 10);
            }
            else { FANTASMA3.Location = new Point(FANTASMA3.Location.X, FANTASMA3.Location.Y - 10); MoveLeft3(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void FANTASMA2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Nivel3 f = new Nivel3();
            f.ShowDialog();

        }

        private void MoveDown4()
        {
            colorpafantasma4 = bmp.GetPixel(FANTASMA4.Location.X, FANTASMA4.Location.Y);
            if (colorpafantasma4.R == 35 && colorpafantasma4.G == 35 && colorpafantasma4.B == 35)
            {
                FANTASMA4.Location = new Point(FANTASMA4.Location.X, FANTASMA4.Location.Y + 10);
            }
            else { FANTASMA4.Location = new Point(FANTASMA4.Location.X, FANTASMA4.Location.Y - 10); MoveLeft4(); }
        }
        private void MoveDown5()
        {
            colorpafantasma5 = bmp.GetPixel(FANTASMA5.Location.X, FANTASMA5.Location.Y);
            if (colorpafantasma5.R == 35 && colorpafantasma5.G == 35 && colorpafantasma5.B == 35)
            {
                FANTASMA5.Location = new Point(FANTASMA5.Location.X, FANTASMA5.Location.Y + 10);
            }
            else { FANTASMA5.Location = new Point(FANTASMA5.Location.X, FANTASMA5.Location.Y - 10); MoveLeft5(); }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MoveUp();
            MoveUp2();
            MoveUp3();
            MoveUp4();
            MoveUp5();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            colorpatrofeo = bmp.GetPixel(TROFEO.Location.X, TROFEO.Location.Y);
            if (colorpatrofeo.R != 35 && colorpatrofeo.G != 35 && colorpatrofeo.B != 35)
            {
                changetrofeolocation();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            changetrofeolocation();

        }

        public class Caster
        {
            public static byte[,] map0 = new byte[,]
           {
           {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
          {0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
          {0,0,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,1,0,0,0},
          {0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,1,0,0,1,1,0,0,0},
          {0,0,0,0,0,0,1,0,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,0},
          {0,0,0,1,1,1,1,1,1,0,1,0,1,0,1,0,1,1,0,0,1,1,1,1,0},
          {0,0,0,1,1,1,1,0,1,0,0,0,0,0,0,0,1,1,0,0,1,0,0,0,0},
          {0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0},
          {0,0,0,8,0,0,1,0,1,0,0,0,0,0,0,0,1,1,0,0,1,0,0,0,0},
          {0,0,0,1,0,0,1,0,1,0,0,0,0,0,0,0,1,1,0,0,1,1,1,1,0},
          {0,0,0,1,0,0,1,0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,0},
          {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
          {0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0},
          {0,1,1,1,1,1,1,0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,0},
          {0,1,1,1,1,1,1,0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,0},
          {0,0,0,0,0,0,1,0,0,0,1,1,1,1,1,0,0,0,0,1,1,0,0,0,0},
          {0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,0,1,0,1,1,0,0,0,0},
          {0,0,0,0,0,0,0,1,1,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,0},
          {0,0,0,0,0,0,0,1,1,1,1,1,0,1,1,0,0,1,0,0,1,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,1,1,1,1,0},
          {0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,1,0,1,1,0},
          {0,0,0,0,0,0,0,0,0,1,0,0,0,1,1,1,0,1,0,1,1,0,1,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
           };
        }
    }
}
