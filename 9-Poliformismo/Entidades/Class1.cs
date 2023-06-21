namespace Entidades
{
    public class Animal
    {
        public virtual string EmitirSonido()
        {
            return "¡Roar!";
        }
    }

    public class Perro : Animal
    {
        public override string EmitirSonido()
        {
            return "¡Woof!";
        }
    }

    public class Gato : Animal
    {
        public override string EmitirSonido()
        {
            return "¡Miau!";
        }
    }
}