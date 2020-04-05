namespace lab3
{
    public class Cajero : Trabajador
    {
        private string caja;
        public Cajero(string nombre, string apellido, int rut, string nacion, string fdn, int salario, string horario, string caja) :base(nombre, apellido, rut, nacion, fdn, salario, horario)
        {
            this.caja = caja;
        }

    }
}
