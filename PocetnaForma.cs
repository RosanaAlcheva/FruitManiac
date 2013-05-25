using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1.Resources
{
    public partial class PocetnaForma : Form
    {
        public List<Igrac> igraci = new List<Igrac>();
        //SoundPlayer sndPing;

        public PocetnaForma()
        {
            InitializeComponent();
            Play.Enabled = false;
            ime.Text = null;
        }


        private void ime_TextChanged(object sender, EventArgs e)
        {
            if (ime.Text.Trim().Length != 0)
            {
                Play.Enabled = true;
            }
            else
            {
                Play.Enabled = false;
            }
        }


        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 igra = new Form1(ime.Text.Trim() , this);
            if (igra.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                igraci.Add(igra.i1);
            ime.Text = "";
            Play.Enabled = false;
            this.Show();
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to move the basket with the mouse to collect as many fruits. But, it is necessary to avoid falling garbage along with fruit, because with ten collected game ends. Total number of levels is three. To move to another Level it is necessary to collect fifty fruits. Good Luck!", "Rules");
        }

      
        //ova e kodot za pesnata
        /*private void chb_CheckedChanged(object sender, EventArgs e)
        {
            if (chb.Checked == false)
            {
                sndPing = new SoundPlayer("Pesna.wav");
                sndPing.Stop();
            }
            else
            {
                sndPing.Play();
            }
        }*/



       

    }
}
