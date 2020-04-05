using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class Supervisor : Trabajador
    {
        
        private string sector;
        public Supervisor(string nombre, string apellido, int rut, string nacion, string fdn, int salario, string horario, string sector): base( nombre, apellido, rut, nacion, fdn, salario, horario)
        {
            this.sector = sector;
        }

        

        public string InfoSV()
        {
            return (InfoTra() + ", Sector:  " + sector);
        }
        


    }
}
