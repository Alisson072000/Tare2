namespace Tarea2
{
    class Panaderia
    {
        int id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
 

        private Empleado trabajador;
        public Empleado Trabajador
        {
            get { return trabajador; }
            set
            {
                trabajador = value;
                trabajador.Trabaja = this;
            }
        }

        public string Informacion()
        {
            return $"La Panaderia {Nombre}" +
                $" esta ubicada {Direccion} puedes contactarnos {Telefono} ";
        }
        public string Producir()
        {
            return $"La Panaderia {Nombre} produce varios tipos de panes ";
        }
    }
}
