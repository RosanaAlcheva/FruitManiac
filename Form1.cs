using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Resources;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Fruit> fruits;
        Fruit fr;
        bool selected { get; set; }
        int fanat = 0;
        int nepotrebni = 0;
        int Result = 0;
        List<Igrac> igraci;
        String igracIme;
        PocetnaForma pf;
        public Igrac i1;
        int brojce = 1;
        
        public Form1(String ime, PocetnaForma pf)
        {
            InitializeComponent();
            igracIme = ime;
            this.igraci = pf.igraci;
            fruits = new List<Fruit>();
            toolStripStatusLabel1.Text = "";
            this.DoubleBuffered = true;
            selected = false;
            pf = new PocetnaForma();
            this.pf = pf;
            i1 = new Igrac(igracIme);

           
            timer1.Start();
            timer2.Start();


       //za kopceto  da bide okruglo i bez  border
       System.Drawing.Drawing2D.GraphicsPath ag = new System.Drawing.Drawing2D.GraphicsPath();
       ag.AddArc(0, 0, button1.Width, button1.Height, 0, 360);
       button1.Region = new Region(ag);
       button1.TabStop = false;
       button1.FlatStyle = FlatStyle.Flat;
       button1.FlatAppearance.BorderSize = 0;

      //za play kopceto
       System.Drawing.Drawing2D.GraphicsPath ag1 = new System.Drawing.Drawing2D.GraphicsPath();
       ag1.AddArc(0, 0, button2.Width, button2.Height, 0, 360);
       button2.Region = new Region(ag1);
       button2.TabStop = false;
       button2.FlatStyle = FlatStyle.Flat;
       button2.FlatAppearance.BorderSize = 0;
  
        }

        Boolean isHit(float x, float y)
        {
            float sirocina = 157 + x;

            foreach (Fruit f in fruits)
            {
                if (f.X>x && f.Y >y && f.X<this.Width && f.Y<this.Height && sirocina>f.X)
                {
                    if (f.ovosje == true) { fanat += 1; Result += 1; }
                    else { nepotrebni += 1; Result -= 1; }
                    fruits.Remove(f);
                    
                    return true;
                }
        }



            return false;
        }




        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //        g.Clear(Color.White);
           

            foreach (Fruit fr in fruits)
            {
                fr.Draw(g);
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < fruits.Count; i++ )
            {
                Fruit fr = fruits[i];
                fr.Move();
                if (isHit(kosnica.Location.X + 10, kosnica.Location.Y + 10))
                {
                    if (fanat == 0) label2.Visible = true;
                    else label2.Visible = false;
                    
                    
                        
                        if (fanat == 10)
                        {
                           
                            kosnicka1.Visible = true;
                            kosnicka2.Visible = false;
                            kosnicka3.Visible = false;
                            kosnicka4.Visible = false;
                            kosnicka5.Visible = false;
                            kosnica.Image = WindowsFormsApplication1.Properties.Resources.crvena;
                        }
                        if (fanat == 20)
                        {
                            kosnicka1.Visible = true;
                            kosnicka2.Visible = true;
                            kosnicka3.Visible = false;
                            kosnicka4.Visible = false;
                            kosnicka5.Visible = false;
                            kosnica.Image = WindowsFormsApplication1.Properties.Resources.plava;
                        }
                        if (fanat == 30)
                        {
                            kosnicka1.Visible = true;
                            kosnicka2.Visible = true;
                            kosnicka3.Visible = true;
                            kosnicka4.Visible = false;
                            kosnicka5.Visible = false;


                            kosnica.Image = WindowsFormsApplication1.Properties.Resources.zolta;
                        }
                        if (fanat == 40)
                        {
                            kosnicka1.Visible = true;
                            kosnicka2.Visible = true;
                            kosnicka3.Visible = true;
                            kosnicka4.Visible = true;
                            kosnicka5.Visible = false;
                            kosnica.Image = WindowsFormsApplication1.Properties.Resources.zelena;
                        }
                        if (fanat == 50)
                        {
                            kosnicka1.Visible = true;
                            kosnicka2.Visible = true;
                            kosnicka3.Visible = true;
                            kosnicka4.Visible = true;
                            kosnicka5.Visible = true;
                            kosnica.Image = WindowsFormsApplication1.Properties.Resources.bez_racka__1_;

                            //za game over 
                            if (brojce == 3)// imam 3 pati po 5kosnici
                            {
                                timer1.Stop();
                                timer2.Stop();
                                //ovdeka vo listata od igraci dodavam igrac so osvoenite vkupno poeni
                                i1.poeni = Result;
                                pf.igraci.Add(i1);
                                label2.Text = "Game over";
                                label2.Visible = true;
                                MessageBox.Show(i1.ToString(), "Good job!");
                                DialogResult dr = MessageBox.Show("Do you want to start new game?", "New game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == System.Windows.Forms.DialogResult.No)
                                {
                                    this.Close();  // megu drugoto i ja zatvaram formata
                                }
                                else
                                {
                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                    this.Close();
                                    //pf.Show();
                                }
                            }


                            brojce += 1;
                            fanat = 0;
                            label2.Text = "Level " + brojce;
                            label2.Visible = true;
                            nepotrebni = 0;
                            Fruit.broj2 += 2;
                                timer1.Interval -=60;

                            kosnicka1.Visible = false;
                            kosnicka2.Visible = false;
                            kosnicka3.Visible = false;
                            kosnicka4.Visible = false;
                            kosnicka5.Visible = false;

                        }

                        if (nepotrebni == 10)
                        {
                            timer1.Stop();
                            timer2.Stop();
                            //Ovde doagja do game over poradi fateno mnogu gjubre
                            i1.poeni = Result;
                            pf.igraci.Add(i1);
                            label2.Text = "Game over";
                            label2.Visible = true;
                            //MessageBox.Show(i1.ToString(), "The End!");
                            DialogResult dr = MessageBox.Show("Do you want to start new game?", "New game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == System.Windows.Forms.DialogResult.No)
                            {
                                this.Close();  // megu drugoto i ja zatvaram formata
                            }
                            else
                            {
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                                this.Close();
                                //pf.Show();
                            }
                        }
                   
                    toolStripStatusLabel1.Text = "Scores: " + fanat.ToString() + "      Garbage:  " + nepotrebni.ToString();
                    textBox1.Text = fanat.ToString();
                    textBox2.Text = Result.ToString();
                    gjubre.Text = nepotrebni.ToString();
                }
            }

            

            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fr = new Fruit(this.Width - 300, this.Height);
            fruits.Add(fr);
            //tie sto odat nadole da gi brise
            //foreach (Fruit f in fruits)
            //{
              //  if (f.Y > this.Height) fruits.Remove(f);
             //}


            Image img = pictureBox4.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox4.Image = img;
            // Invalidate();
        }

        int dx;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
       {

           //tuka izmislite nes za da ja kosnicata!!!
           
               if (e.Button == MouseButtons.Left)
               {
                  
                       dx = e.X - mousePos.X;
                  
                   kosnica.Location = new Point(kosnica.Left + dx, kosnica.Top);
               }
           
            
        
       }
        Point mousePos;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
           
            {
                mousePos = e.Location;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void scores_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            HighScoresForm hs = new HighScoresForm(igraci);
            if (hs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                timer1.Start();
                timer2.Start();
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            DialogResult dr = MessageBox.Show("Are you sure you want to start new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                i1.poeni = Result;
                this.Close();
               // pf.Show();
            }
        }

        private void rules_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            DialogResult d = MessageBox.Show("You need to move the basket with the mouse to collect as many fruits. But, it is necessary to avoid falling garbage along with fruit, because with ten collected game ends. Total number of levels is three. To move to another Level it is necessary to collect fifty fruits. Good Luck!", "Rules");
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                timer1.Start();
                timer2.Start();
            }
        }

            
        }

    }


