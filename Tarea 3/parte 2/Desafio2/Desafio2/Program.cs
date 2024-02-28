public class Program
{
    public static void Main(string[] args)
    {
        Juego juego = new Juego();

        // Ejemplo de uso
        juego.RegistrarPuntaje(150, "Jugador1");
        Console.WriteLine();
        juego.RegistrarPuntaje(200, "Jugador2");
        Console.WriteLine();
        juego.RegistrarPuntaje(100, "Jugador3");
    }
}