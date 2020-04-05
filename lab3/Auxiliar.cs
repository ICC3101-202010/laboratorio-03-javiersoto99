namespace lab3
{
    public class Auxiliar : Trabajador
    {
        private int pasillo;
        public Auxiliar(string nombre, string apellido, int rut, string nacion, string fdn, int salario, string horario, int pasillo) : base(nombre, apellido, rut, nacion, fdn, salario, horario)
        {
            this.pasillo = pasillo;
        }

        public string InfoAux()
        {
            return (InfoTra() + ", Pasillo : " + pasillo);
        }
    }
}
