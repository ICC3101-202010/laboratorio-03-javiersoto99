namespace lab3
{
    public class Trabajador : Persona
    {
        private int salario;
        private string horario;
        public Trabajador(string nombre, string apellido, int rut, string nacion, string fdn, int salario, string horario) : base(nombre, apellido, rut, nacion, fdn)
        {
            this.salario = salario;
            this.horario = horario;
             
        }
    }
}
