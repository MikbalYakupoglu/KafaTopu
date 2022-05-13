namespace KafaTopu;

public class Kafatopu
{
    private int uzunluk;
    private int genislik;
    private Saha saha;
    private Oyuncular oyuncu1;
    private Oyuncular oyuncu2;
    private ConsoleKeyInfo keyInfo;
    private ConsoleKey consoleKey;
    private Top top;



    public Kafatopu(int uzunluk,int genislik)
    {
        this.uzunluk = uzunluk;
        this.genislik = genislik;
        saha = new Saha(this.uzunluk, this.genislik);
        top = new Top((this.genislik / 2), ((this.uzunluk) / 2), uzunluk, genislik);
    }

    public void Setup()
    {
        oyuncu1 = new Oyuncular(2, uzunluk);
        oyuncu2 = new Oyuncular(genislik-2,uzunluk);

        keyInfo = new ConsoleKeyInfo();
        consoleKey = new ConsoleKey();

        top.X = genislik / 2;
        top.Y = uzunluk / 2;
        top.yon = 0;
    }

    void Input()
    {
        if (Console.KeyAvailable)
        {
            keyInfo = Console.ReadKey(true);
            consoleKey = keyInfo.Key;
        }
    }

    public void Run()
    {
        int skor1 = 0;
        int skor2 = 0;

        while (skor2 <= 2 && skor1 <= 2)
        {

            Console.Clear();
            Setup();
            saha.Ciz();
            oyuncu1.Ciz();
            oyuncu2.Ciz();
            top.Ciz();
            while (top.X != 0 && top.X != genislik)
            {

                if (top.X <= 1)
                {
                    skor2++;
                }
                else if (top.X >= genislik-1)
                {
                    skor1++;
                }
                Input();
                switch (consoleKey)
                {
                    case ConsoleKey.W:
                        oyuncu1.Yukari();
                        oyuncu2.Yukari();
                        break;
                    case ConsoleKey.S:
                        oyuncu1.Asagi();
                        oyuncu2.Asagi();
                        break;

                    case ConsoleKey.UpArrow:
                        oyuncu1.Yukari();
                        oyuncu2.Yukari();
                        break;
                    case ConsoleKey.DownArrow:
                        oyuncu1.Asagi();
                        oyuncu2.Asagi();
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }

                consoleKey = ConsoleKey.A;
                top.Logic(oyuncu1,oyuncu2);
                top.Ciz();
                Thread.Sleep(30);

            }

        }
        Console.Clear();
        if (skor1 > skor2)
        {
            Console.WriteLine("Tebrikler! Oyuncu 1 Kazandı.");
        }
        else if (skor2 > skor1)
        {
            Console.WriteLine("Tebrikler! Oyuncu 2 Kazandı.");
        }
        Console.WriteLine($"Oyuncu1 {skor1} - {skor2} Oyuncu2");
        Console.WriteLine("Tekrar Oynamak İçin -Enter- Tuşuna Basınız.");
        Console.WriteLine("Oyundan Çıkmak İçin -Esc- Tuşuna Basınız.");

        while (true)
        {
            Input();
            switch (consoleKey)
            {
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Enter:
                    Run();
                    break;
            }
        }
    }
}