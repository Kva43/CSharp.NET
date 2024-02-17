class Program
{
    static void Main(string[] args)
    {
        DateTime fechaDeNacimiento;
        Console.WriteLine("Ingrese su fecha de nacimiento (formato dd/MM/yyyy): ");

        // Dependiendo de la cultura o región, los formatos de fecha y hora pueden variar, por ejemplo, el orden de los componentes de la fecha
        // (día/mes/año vs mes/día/año), el separador utilizado (barra inclinada "/", guión "-", punto ".", etc.), o el símbolo para indicar AM/PM.
        // En este caso se utiliza el proveedor predeterminado del sistema, que se pasa como null. El proveedor predeterminado del sistema se adapta automáticamente
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaDeNacimiento))
        {
            int diasTranscurridos = CalcularDiasQuePasaronDesdeNacimiento(fechaDeNacimiento);
            Console.WriteLine("Días transcurridos desde su fecha de nacimiento: " + diasTranscurridos);
        }
        else
        {
            Console.WriteLine("Formato de fecha inválido. Asegúrese de ingresar la fecha en el formato dd/MM/yyyy.");
        }
    }

    //static int CalcularDiasQuePasaronDesdeNacimiento(DateTime fechaDeNacimiento)
    //{
    //    // Obtiene la fecha actual sin la hora y los segundos
    //    DateTime fechaActual = DateTime.Today;

    //    // Calcula la diferencia entre la fecha actual y la fecha de nacimiento
    //    TimeSpan tiempoTranscurrido = fechaActual.Subtract(fechaDeNacimiento);
         
    //    // Retorna el número de días transcurridos
    //    return tiempoTranscurrido.Days;
    //}

    static int CalcularDiasQuePasaronDesdeNacimiento(DateTime fechaDeNacimiento)
    {
        // Obtiene la fecha actual sin la hora y los segundos
        DateTime fechaActual = DateTime.Today;

        // Calcula la diferencia entre la fecha actual y la fecha de nacimiento
        // Se declara TimeSpan porque representa la diferencia entre dos instancias de tiempo
        TimeSpan tiempoTranscurrido = fechaActual.Date - fechaDeNacimiento.Date;

        // Calcula los días transcurridos redondeando hacia abajo
        // Este objeto TimeSpan tiene propiedades como Days, Hours, Minutes, Seconds, Milliseconds, etc., que representan la cantidad de cada unidad de tiempo en el intervalo total.
        // Al usar TotalDays, se obtiene la duración total del intervalo en días, incluso si hay fracciones de días involucradas.Por ejemplo, si el intervalo de tiempo representado por
        // tiempoTranscurrido es de 2 días y 12 horas, TotalDays devolverá 2.5 días, incluyendo la fracción de días de las horas restantes.
        // Math.Floor es para redondear el resultado hacia abajo
        int diasTranscurridos = (int)Math.Floor(tiempoTranscurrido.TotalDays);

        // Retorna el número de días transcurridos
        return diasTranscurridos;
    }
}