using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculodos.clases
{
    internal class areaCirculo
    {
        double radio {  get; set; } 
        double area { get; set; }

        public double calcular()
        {
            return this.radio=this.radio*this.radio*Math.PI;
        }
    }
}
