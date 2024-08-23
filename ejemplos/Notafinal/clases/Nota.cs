using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notafinal.clases
{
    internal class Nota
    {
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }

        public int calcularNota()
        {
            return (this.Nota1 + this.Nota2 + this.Nota3) / 3;
        }
        public Nota()
        {

        }
    }

}

    

