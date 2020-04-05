namespace lab3
{
    public class Cajero : Trabajador
    {
        private int caja;
        public Cajero(string nombre, string apellido, int rut, string nacion, string fdn, int salario, string horario, int caja) :base(nombre, apellido, rut, nacion, fdn, salario, horario)
        {
            this.caja = caja;
        }

        public string InfoCaj()
        {
            return (InfoTra() + " , Cajero: " + caja);
        }
    }
}
