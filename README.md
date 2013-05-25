FruitManiac
===========

Околу играта ... каква е, како се игра?

     Играта Fruit Maniac е прилично едноставна игра, во која главна цел е собирање на што е можно повеќе овошки 
     како би се собрале што е можно повеќе поени.
     Вкупниот, и максимален број на поени кои можат да се соберат е 150, а истиот се добива доколку, 
     во текот на играта (која е составена од 3 нивоа), се фаќаат само овошки, а целосно е избегнато „ѓубрето“. 
     Всушност, со секоја фатена овошка во кошничката се добива 1 поен, а со секое фатено „ѓубре“ се одзема еден поен.
     Една кошничка се исполнува со фатени 10 овошки, при што истата се складира во делот со исполнети кошнички, 
     а на нејзино место доаѓа, нова празна кошничка. Преминувањето во наредно ниво, се реализира, 
     кога ќе бидат исполнети 5 кошнички, т.е. фатени 50 овошки. Меѓутоа, услов е, за време на секое ниво 
     да не бидат фатени 10 објекти од „ѓубрето“, бидејќи доколку бидат, играта ќе заврши. 
     Доколку се премине пак на следно ниво, бројот на претходно фатени објекти од „ѓубрето“ се ресетира, 
     и поставува на нула, а за сметка на тоа, се зголемува нивниот број при паѓање, 
     со што е поголема веројатноста да се фати некој ваков објект.
     Собирањето на овошките се реализира со поместување на кошничката, 
     со помош на клик и држење на глувчето (Mouse down).  
     Кошничката е ограничена, така да, доколку падне овошка, или било кој објект од „ѓубрето“ на 
     некој од нејзините рабови, истиот нема да биде фатен.
     По завршувањето на играта овозможен е преглед на поени и рангирање на играчите во делот со Scores.


Решение на проблемот

За реализација на играта, имплементиравме класа Fruit, во која е направена листа од слики, 
соодветни на овошките и „ѓубрето“ кои паѓаат.
     
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
            if (broj > 6) ovosje = false;
            else ovosje = true;
            
            br=rnd.Next(X);
            p = new Point(br, 5);
            X = br;
            Y = 5;
        }


         public void Draw(Graphics g)
        {
            fruitList.ImageSize = new Size(50, 50);
            g.DrawImage(fruitList.Images[broj], p);
        }

        public void Move()
        {
            p.Y += 10;
            Y = p.Y;
        }
}
Статичката променлива broj2, на која и е доделена вредноста 9, ни користи за создавање на сликичките во првото ниво, т.е. сите овошки и две сликички(објекти) од „ѓубрето“. Притоа, појавувањето на сликичките е random, исто како и нивното позиционирање на екранот. 
Условот
if (broj > 6) ovosje = false;
            else ovosje = true;
е ставен со цел да се определи дали објектот е овошје или „ѓубре“. Методот Draw ја исцртува сликичката на претходно утврдената позиција, додека пак, со методот Move, е овозможено движењето/паѓањето на овошјето/„ѓубрето“.
Останатиот дел од играта се состои од три форми и уште една класа.
Класа Igrac, која овозможува додавање на играч, во која се чуваат променливи за името на играчот и освоените поени.
Во PocetnaForma, претставува почетната форма која се отвора при уклучувањето на играта. Во нејзе морално е да се внесе името на играчот за да би се играла играта, и притоа кај истата е поставено копче Rules, преку кое можат да се прочитаат правилата.
Главната, и најзначајна форма за оваа игра е Form1, од која ќе ја објасниме следнава функција.
Boolean isHit(float x, float y)
        {
            float sirocina = 157 + x;

            foreach (Fruit f in fruits)
            {
                if (f.X > x && f.Y > y && f.X<this.Width && f.Y<this.Height && sirocina>f.X)
                {
                    if (f.ovosje == true) { fanat += 1; Result += 1; }
                    else { nepotrebni += 1; Result -= 1; }
                    fruits.Remove(f);
                    
                    return true;
                }
        } return false;
        }

Со оваа функција, всушност определуваме дали овошјето/„ѓубрето“ има паднато во кошничката. Зададените променливи x, y, се однесуваат на координатите каде кошничката се наоѓа. Притоа, за секој објект од класата Fruit во листата од fruits, се проверува дали неговата моментална позиција одговара на координатите и големината кои ја определуваат кошничката. Дополнителен услов е ставен со кој се проверува, т.е. се прави разлика дали објектот е овошје или е „ѓубре“, со тоа што, доколку е овошје променливата fanat се зголемува за еден (а таа определува колку овошки се имаат фатено), и воедно Result(која е променлива која на крај од играта го печати завршниот резултат) се зголемува за еден, инаку се зголемува бројот на nepotrebni(што во суштина ни претставува фатено „ѓубре“), а пак Result се намалува за еден.
Во оваа форма Form1, се искоритени два timer-а, од кои едниот е за создавање на нова овошка/ѓубре, а другиот за процесот на паѓање/движење на истите.
Третата и последна форма се однесува на можноста да се погледнат 5те најдобро остварени резултати, и во нејзе се прави објект од претходно дефинираната класа Igrac, за да подоцна може да се направи листа со рангирани играчи.
