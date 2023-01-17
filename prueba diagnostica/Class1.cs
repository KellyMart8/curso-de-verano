using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_diagnostica
{
    internal class Class1
    {
        int cEmpleado, salario;

        public int CEmpleado { get; set; }
        public int Salario { get; set; }

        public double InssL()
        {
            return (Salario * (0.07));
        }

        public double InssP()
        {
            return (Salario * (0.21));
        }

        //public void InssL()
        //{
        //    double iL = Salario * (0.07);
        //}

        //public void InssP()
        //{
        //    double iP = Salario * (0.21);
        //}
    }
}
