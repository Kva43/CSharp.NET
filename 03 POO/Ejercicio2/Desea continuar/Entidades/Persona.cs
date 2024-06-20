namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }


        //getters y setters
        public void SetNombre(string value)
        {
            this.nombre = value;
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        void GetFechaDeNacimiento(out DateTime fechaDeNacimiento)
        {
            fechaDeNacimiento = this.fechaDeNacimiento;
        }

        void SetDni(int dni)
        {
            this.dni = dni;
        }
        void GetDni(out int dni)
        {
            dni = this.dni;
        }


        private int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;

            int edad = hoy.Year - fechaDeNacimiento.Year;
            
            return edad;
        }

        public string Mostrar()
        {
            int edad = CalcularEdad();
            return $"Nombre: {nombre} - Fecha de Nacimiento: {fechaDeNacimiento.ToShortDateString()} - DNI: {dni} - Edad: {edad} años";
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();

            if(edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            { return "Es menor";  }
        }

    }
}