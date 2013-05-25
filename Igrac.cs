using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Igrac
    {
        public String ime;
        public int poeni { set; get; }

        public Igrac(String ime)
        {
            this.ime = ime;
            poeni = 0;
        }

        public override string ToString()
        {
            return ime + "    " + poeni + " points";
        }
    }
}
