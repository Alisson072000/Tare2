namespace Tarea2
{
    class Cliente
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Producto Preferencia{ get;set; }

        public string Saludar()
        {
            return $" Buenos días\n ";
        }
        public string Informacion()
        {
            return $"Mi nombre es {Nombre} {Apellido} vivo en {Direccion}\n ";
        }
        public string productoPreferencia()
        {
            return $"Mi pan de preferencia es {Preferencia.Nombre}\n";
        }

    }
}
