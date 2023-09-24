class Program
{
    static void Main(string[] args)
    {
        Sobrescrito objetoSobrescrito = new Sobrescrito();
        Perro perro = new Perro();

        Console.WriteLine(objetoSobrescrito.ToString());
        Console.WriteLine(objetoSobrescrito.Equals(perro));
        Console.WriteLine(objetoSobrescrito.GetHashCode());
    }
}

class Sobrescrito
{
    public override string ToString()
    {
        return "¡Este es mi método ToString sobrescrito!";
    }

    public override bool Equals(object obj)
    {
        return obj.GetType() == typeof(Sobrescrito);
    }

    public override int GetHashCode()
    {
        return 1142510181;
    }
}

class Perro
{

}

