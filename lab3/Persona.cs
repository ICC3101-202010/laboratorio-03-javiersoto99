namespace lab3
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int rut;
        private string nacion;
        private string fdn;

        public Persona(string nombre, string apellido, int rut, string nacion, string fdn)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.nacion = nacion;
            this.fdn = fdn;
        }

        public string InfoPer()
        {
            return ("Nombre:  " + nombre + ", Apellido:  " + apellido + ", RUT:  " + rut + ", Nacionalidad:  " + nacion + ", Fecha de Nacimiento:  " + fdn);
        }

    }
}
