﻿namespace lab3
{
    public class Auxiliar : Trabajador
    {
        private string pasillo;
        public Auxiliar(string nombre, string apellido, int rut, string nacion, string fdn, int salario, string horario, string pasillo) : base(nombre, apellido, rut, nacion, fdn, salario, horario)
        {
            this.pasillo = pasillo;
        }
    }
}
