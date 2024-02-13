using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_02._13
{
    class Orszag
    {
        public string orszagnev;
        public string fovaros;
        public double terulet;

        public Orszag(string orszagnev, string fovaros, double terulet)
        {
            this.orszagnev = orszagnev;
            this.fovaros = fovaros;
            this.terulet = terulet;
        }
    }
}
