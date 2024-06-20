using Entidades;

class Program
{
    static void Main(string[] args)
    {
        string dibujo;

        Boligrafo boligrafoUno = new Boligrafo(ConsoleColor.Red, 50);
        
        if(boligrafoUno.Pintar(6, out dibujo))
        {
            Console.BackgroundColor = boligrafoUno.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor();
        }
    }
}