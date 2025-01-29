using NAudio.Wave;
public class Program
{
    static void Main()
    {
        Task sonidoprincipal = Task.Run(() => Musc.Music());

        for (int i = 0; i < Laberinto.n; i++)
        {
            for (int j = 0; j < Laberinto.m; j++)
            {
                Laberinto.matriz[i, j] = "0";
            }
        }
        Console.Title = "EN BUSACA DE LAS GEMAS";
        Laberinto.Menu();
    }

}
