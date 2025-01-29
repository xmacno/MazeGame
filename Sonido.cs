using NAudio.Wave;
public class Musc
{
    static string ruta = AppDomain.CurrentDomain.BaseDirectory;
    static string rutamod = ruta.Replace('\\', '/').Replace("/bin/Debug/net8.0/", "");
    static string musc = rutamod + "/sonido/musica.mp3";
    static string point = rutamod + "/sonido/point.mp3";
    static string win = rutamod + "/sonido/win.mp3";
    static string tramp = rutamod + "/sonido/trampa.mp3";
    static string benef = rutamod + "/sonido/bene.mp3";
    static string selec = rutamod + "/sonido/menu.mp3";
    public static void Music()
    {
        do
        {
            using (var lector = new AudioFileReader(musc))
            using (var waveOut = new WaveOutEvent())
            {
                waveOut.Init(lector);
                waveOut.Play();
                lector.Volume = 0.2f;
                Thread.Sleep(203000);
            }

        } while (true);

    }
    public static void Point()
    {

        using (var lector = new AudioFileReader(point))
        using (var waveOut = new WaveOutEvent())
        {
            waveOut.Init(lector);
            waveOut.Play();
            lector.Volume = 0.80f;
            Thread.Sleep(2000);
        }

    }
    public static void Win()
    {
        using (var lector = new AudioFileReader(win))
        using (var waveOut = new WaveOutEvent())
        {
            waveOut.Init(lector);
            waveOut.Play();
            lector.Volume = 0.80f;
            Thread.Sleep(2000);
        }

    }
    public static void Tramp()
    {
        using (var lector = new AudioFileReader(tramp))
        using (var waveOut = new WaveOutEvent())
        {
            waveOut.Init(lector);
            waveOut.Play();
            lector.Volume = 1.0f;
            Thread.Sleep(2000);
        }
    }
    public static void Selec()
    {
        using (var lector = new AudioFileReader(selec))
        using (var waveOut = new WaveOutEvent())
        {
            waveOut.Init(lector);
            waveOut.Play();
            lector.Volume = 0.80f;
            Thread.Sleep(200);
        }
    }
    public static void Benf()
    {
        using (var lector = new AudioFileReader(benef))
        using (var waveOut = new WaveOutEvent())
        {
            waveOut.Init(lector);
            waveOut.Play();
            lector.Volume = 0.80f;
            Thread.Sleep(200);
        }
    }
    public static void Sonidos(int x)
    {
        if (x == 1)
        {
            Task sonidoprincipal = Task.Run(() => Selec());
        }
        if (x == 2)
        {
            Task sonidoprincipal = Task.Run(() => Point());
        }
        if (x == 3)
        {
            Task sonidoprincipal = Task.Run(() => Win());
        }
        if (x == 4)
        {
            Task sonidoprincipal = Task.Run(() => Tramp());
        }
        if (x == 5)
        {
            Task sonidoprincipal = Task.Run(() => Benf());
        }
    }

}