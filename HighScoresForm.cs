using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HighScoresForm : Form
    {
        List<Igrac> igraci = new List<Igrac>();

        public HighScoresForm(List<Igrac> i)
        {
            InitializeComponent();
            igraci = i;
            if (i.Count != 0)
            {
                Sortiraj(igraci);
                //smislete neshto pooptimalno tuka 
                if (i.Count >= 5)
                {
                    textBox1.Text = i[0].ToString();
                    textBox2.Text = i[1].ToString();
                    textBox3.Text = i[2].ToString();
                    textBox4.Text = i[3].ToString();
                    textBox5.Text = i[4].ToString();
                }
                else 
                {
                    if (i.Count == 1)
                        textBox1.Text = i[0].ToString();
                    if (i.Count == 2)
                    {
                        textBox1.Text = i[0].ToString();
                        textBox2.Text = i[1].ToString();
                    }
                    if (i.Count == 3)
                    {
                        textBox1.Text = i[0].ToString();
                        textBox2.Text = i[1].ToString();
                        textBox3.Text = i[2].ToString();
                    }
                    if (i.Count == 4)
                    {
                        textBox1.Text = i[0].ToString();
                        textBox2.Text = i[1].ToString();
                        textBox3.Text = i[2].ToString();
                        textBox4.Text = i[3].ToString();
                    }
                }
            }
        }

        private void Sortiraj(List<Igrac> t)
        {
            int n = t.Count();
            if (t.Count() > 1)
            {
                for (int i = 0; i < n-1; i++)
                    for (int j = i+1; j < n; j++)
                    {
                        if (t[j].poeni > t[i].poeni)
                        {
                            Igrac pomosen = t[i];
                            t[i] = t[j];
                            t[j] = pomosen;
                        }
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            //Close();
        }

        private void HighScoresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            //Close();
        }
        
        
    }
}
