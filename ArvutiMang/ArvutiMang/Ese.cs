using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    class Ese : Entity
    {
        int punktideArv;
        string nimetus;

        public Ese(int punktideArv, string nimetus)
        {
            this.punktideArv = punktideArv;
            this.nimetus = nimetus;
        }

        public int PunktideArv()
        {
            return punktideArv;
        }

        public string Nimetus()
        {
            return nimetus;
        }
    }
}
