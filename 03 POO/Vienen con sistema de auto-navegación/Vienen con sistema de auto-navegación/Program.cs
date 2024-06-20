using Entidades;

class Program
{
    // Solucionar cuando piden un día donde ningún conductor trabajó
    // Solucionar que a la hora de pedir ConductorMayorRecorridoSemanal tengo 6 o 7 días trabajados cada conductor
    // Posibles mejoras:
    // Crear una opción para que el usuario una cantidad x de conductores
    // Crear una opción para que el usuario cargue kilometros randoms para todos los conductores
    // Crear una opción para que el usuario cargue manualmente los conductores y kilometros manualmente
    static void Main(string[] args)
    {
        Conductor conductorMayorRecorridoSemanal;
        Conductor conductorMayorRecorridoDelDia;


        float[] arrayParaConductorUno = new float[] { 2, 2, 2 };
        float[] arrayParaConductorDos = new float[] { 1, 1, 1 };
        float[] arrayParaConductorTres = new float[] { 2, 2 , 2 };

        int dia = 4;

        Conductor conductorUno = new Conductor("Carlos", arrayParaConductorUno);
        Conductor conductorDos = new Conductor("Miguel", arrayParaConductorDos);
        Conductor conductorTres = new Conductor("Marcos", arrayParaConductorTres);

        Conductor[] conductores = new Conductor[] { conductorUno, conductorDos, conductorTres }; // crear un for para agregar más instancias Conductor al array de los mismos

        conductorMayorRecorridoSemanal = Conductor.ConductorMayorRecorridoSemanal(conductores);

        conductorMayorRecorridoDelDia = Conductor.ConductorMayorRecorridoSegunDia(conductores, dia - 1);


        Console.WriteLine("Conductor mayor recorrido semanal es: " + conductorMayorRecorridoSemanal.Nombre);


        if (conductorMayorRecorridoDelDia != null)
        {
            Console.WriteLine($"Conductor mayor recorrido del día {dia} es: {conductorMayorRecorridoDelDia.Nombre}");
        }
        else
        {
            Console.WriteLine("Ninguno de los conductores trabajo ese día.");
        }

        // Solucionar el caso cuando los conductores hicieron el mismo recorrido el dia que reciben como parametro
        // La función retorna el primer caso
        // Debería notificar que dos o más son los de mayor kilometraje semanalmente

    }
}