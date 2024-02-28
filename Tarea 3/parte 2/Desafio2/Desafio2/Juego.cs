using System;

public class Juego
{
    private int puntajeMaximo;
    private string jugadorRecord;

    public Juego()
    {
        puntajeMaximo = 0;
        jugadorRecord = "";
    }

    public void RegistrarPuntaje(int puntaje, string nombreJugador)
    {
        if (puntaje > puntajeMaximo)
        {
            Console.WriteLine("La nueva puntuación más alta es " + puntaje);
            Console.WriteLine("La puntuación más alta fue lograda por " + nombreJugador);
            puntajeMaximo = puntaje;
            jugadorRecord = nombreJugador;
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + puntajeMaximo + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
        }
    }
}