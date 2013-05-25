using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Fruit
    {
        public ImageList fruitList { get; set; }
        
        Point p;
         int br;
        Random rnd = new Random();
        public int broj;
        public bool ovosje;
        public int X { get; set; }
        public int Y { get; set; }
        public int YY { get; set; }
        public static int broj2=9;


        public Fruit(float x, float y)
        {
            fruitList = new ImageList{ };
           
            
            
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.grozje);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.jagoda);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.banana);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.sliva);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.kruska);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.creski);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.ananas);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.beer);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.cd);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.riba);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.gavol);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.cekan);
            fruitList.Images.Add(WindowsFormsApplication1.Properties.Resources.balon);



            
            X = (int)x;
            Y = (int)y;
            YY = (int)y;
            broj = rnd.Next(broj2);
            //za da se znae koga se sobira ovoski
            if (broj > 6) ovosje = false;
            else ovosje = true;
            
           
            br=rnd.Next(X);
            p = new Point(br, 5);
            X = br;
            Y = 5;
        }


        
        

        public void Draw(Graphics g)
        {
           // broj = rnd.Next(3);
            fruitList.ImageSize = new Size(50, 50);
            
            

            g.DrawImage(fruitList.Images[broj], p);
            

            
        }

        public void Move()
        {
            p.Y += 10;
            Y = p.Y;
        }
 
    }
}
