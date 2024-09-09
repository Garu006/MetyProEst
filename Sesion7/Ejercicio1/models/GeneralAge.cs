using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class GeneralAge
    {
        //modificador de acceso: permiten el acceso o no acceso a un objeto
        private int[] ages = new int[10];
        public void AddElement(int age, int pos)
        {
            ages[pos] = age;
        }
        public int[] GetElements()
        {
            return ages;
        }
    }
}
