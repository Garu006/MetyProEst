using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MontoPagar.clases
{
    internal class Factura
    {
        //get: otiene el valor
        //set: asigna ese valor
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double calcularMonto()
        {
            return this.Precio * this.Cantidad;
        }
        //los constructores son las maneras para crear los objetos
        public Factura()
        {

        } 
    }   
}
